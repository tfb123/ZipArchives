using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.Threading;
using SevenZip;

namespace Zipulia_ZipArchives_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string source;
        string destination;

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Title = "Select Archive",
                Filter = GetAllSupportedFormats(),
                Multiselect = false,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
                ShowArchive(ofd.FileName);
            }
        }
        private void ShowArchive(string path)
        {
            listBox1.Items.Clear();
            ZipArchive zipArchive = ZipFile.OpenRead(path);
            foreach (var item in zipArchive.Entries)
            {
                listBox1.Items.Add(item.FullName);
            }
        }

        private void CreateZipButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog()
            {
                Description = "Select Folder for ahrchiving",
                ShowNewFolderButton = false
            };

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                source = fbd.SelectedPath;
                SaveFileDialog sfd = new SaveFileDialog()
                {
                    Title = "Select where to save ",
                    Filter = GetAllSupportedFormats(),
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    destination = sfd.FileName;
                    Thread thread = new Thread(StartZipProcess);// чтобы работало больше application , чтоб не нагруж сист. (трэды делать ПОЛЕЗНО)
                    thread.Start();
                }
            }
        }
        private void StartZipProcess(object obj)
        {
            ZipFile.CreateFromDirectory(source,destination, System.IO.Compression.CompressionLevel.Optimal,false);
            MessageBox.Show("Completed");
        }

        private void ExtractZipButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Title = "Select Archive",
                Filter = GetAllSupportedFormats(),
                Multiselect = false
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                source = ofd.FileName;
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    destination = fbd.SelectedPath;
                    ZipFile.ExtractToDirectory(source,destination);
                    MessageBox.Show("Completed");
                }
            }
        }

        private string GetAllSupportedFormats()
        {
            var names = Enum.GetNames(typeof(OutArchiveFormat));
            string filter = "";

            foreach (var item in names)
            {
                if (item.ToLower().Contains("seven"))
                {
                    filter += $"{item} file|*.7z|";
                }
                else
                {
                    filter += $"{item} file|*.{item}|";
                }
            }
            return filter = filter.Remove(filter.LastIndexOf('|'));
        }

        private void ExtractZipButton7z_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Title = "Select Archive",
                Filter = GetAllSupportedFormats(),
                Multiselect = false
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                source = ofd.FileName;
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    destination = fbd.SelectedPath;
                    SevenZipExtractor.SetLibraryPath(Application.StartupPath + @"\x86\7z.dll");
                    SevenZipExtractor sevenZipExtractor = new SevenZipExtractor(source);
                    sevenZipExtractor.Extracting += sevenZipExtracting;
                    sevenZipExtractor.ExtractionFinished += sevenZipExtractionFinished;

                    sevenZipExtractor.ExtractArchive(destination);
                }
            }
        }
        void sevenZipExtractionFinished(object sender,EventArgs e)
        {
            MessageBox.Show("Completed");
            progressBar1.Value = 0;
        }

        void sevenZipExtracting(object sender,ProgressEventArgs e)
        {
            progressBar1.Value = e.PercentDone; 
        }

        private void CreateZipButton7z_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog()
            {
                Description = "Select Folder for ahrchiving",
                ShowNewFolderButton = false
            };
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                source = fbd.SelectedPath;
                SaveFileDialog sfd = new SaveFileDialog()
                {
                    Title = "Select where to save ",
                    Filter = GetAllSupportedFormats(),
                };
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    destination = sfd.FileName;
                    SevenZipCompressor.SetLibraryPath(Application.StartupPath + @"\x86\7z.dll");
                    SevenZipCompressor sevenZipCompressor = new SevenZipCompressor();
                    sevenZipCompressor.Compressing += sevenZipCompressing;
                    sevenZipCompressor.CompressionFinished += sevenZipCompressorFinisher;

                    sevenZipCompressor.CompressionLevel = SevenZip.CompressionLevel.Ultra;
                    sevenZipCompressor.CompressionMethod = SevenZip.CompressionMethod.Lzma2;
                    sevenZipCompressor.CompressionMode = SevenZip.CompressionMode.Create;

                    sevenZipCompressor.CompressDirectory(source, destination);
                }
            }
        }
        void sevenZipCompressorFinisher(object sender , EventArgs e)
        {
            MessageBox.Show("Completed");
            progressBar1.Value = 0;
        }
        //===========================
        // THREAD 2
        void sevenZipCompressing(object sender, ProgressEventArgs e)
        {
            if (InvokeRequired)
            {
                // call function from THREAD 1
                BeginInvoke(new UpdateProgressBarHandler(UpdateProgressBar), e.PercentDone);
            }
        }
        delegate void UpdateProgressBarHandler(int value);
        private void UpdateProgressBar(int value)
        {
            progressBar1.Value = value;
        }
    }
}
