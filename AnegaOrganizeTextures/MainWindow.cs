using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AnegaOrganizeTextures
{
    public partial class MainWindow : Form
    {
        IEnumerable<string> sourceFileList;
        IEnumerable<string> targetFileList;

        string defaultSource = "C:\\Daten\\Anega\\UMABlender\\ClothSets";
        string defaultTarget = "C:\\Daten\\Entwicklung\\UMA2 Test\\Assets\\UMAClothing\\_NEW";
        struct Source2target
        {
            public string sourceFile;
            public string tagetFile;
            public Source2target(string source, string target)
            {
                sourceFile = source;
                tagetFile = target;
            }
        }
        List<Source2target> finalFileList = new List<Source2target>();

        public MainWindow()
        {
            InitializeComponent();
        }


        private void FindSourceDirectory_Click(object sender, EventArgs e)
        {
            openFileDialogDir.InitialDirectory = (ioSourceDir.Text.Length == 0?defaultSource:ioSourceDir.Text);
            openFileDialogDir.Title = "Select source directory for textures";
            DialogResult result = openFileDialogDir.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                ioSourceDir.Text = Path.GetDirectoryName(openFileDialogDir.FileName);

                DirectoryInfo dir = new DirectoryInfo(ioSourceDir.Text);
                //Define the file names here
                sourceFileList = Directory.EnumerateFiles(ioSourceDir.Text, "*.*", SearchOption.AllDirectories)
                    .Where(s => s.EndsWith("_diffuse.png") || s.EndsWith("_normal.png") || s.EndsWith("_metall.png"));

                AddLogText(string.Format("Found {0} files in source directory", sourceFileList.Count()));
            }
        }

        private void FindTargetDirectory_Click(object sender, EventArgs e)
        {
            openFileDialogDir.InitialDirectory = (ioTargetDir.Text.Length == 0 ? defaultTarget : ioTargetDir.Text);
            openFileDialogDir.Title = "Select target directory for textures (unity Asset)";
            DialogResult result = openFileDialogDir.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                ioTargetDir.Text = Path.GetDirectoryName(openFileDialogDir.FileName);

                DirectoryInfo dir = new DirectoryInfo(ioTargetDir.Text);
                //Define the file names here
                targetFileList = Directory.EnumerateFiles(ioTargetDir.Text, "*.*", SearchOption.AllDirectories)
                    .Where(s => s.EndsWith("_diffuse.png") || s.EndsWith("_normal.png") || s.EndsWith("_metall.png"));

                if (targetFileList.Count() > 0)
                {
                    string firstFile = targetFileList.First() + ".meta";
                    if (!File.Exists(firstFile))
                    {
                        AddLogText(string.Format("ERROR: This is most probably not a Unity asset folder"), true);
                        targetFileList = null;
                        return;
                    }
                }

                AddLogText(string.Format("Found {0} files in target directory", targetFileList.Count()));
            }
        }

        private void ButtonCompare_Click(object sender, EventArgs e)
        {
            if (targetFileList is null || sourceFileList is null)
            {
                AddLogText(string.Format("ERROR: Source or target directory not selected"), true);
                return;
            }

            finalFileList.Clear();
            int iCount = 0;
            progressBar.Minimum = 0;
            progressBar.Maximum = targetFileList.Count();
            progressBar.Value = 0;
            progressBar.Visible = true;

            foreach (string target in targetFileList)
            {
                string source = "";
                int sourceCount = 0;
                string targetFileName = Path.GetFileName(target);
                foreach (string sourceListEntry in sourceFileList)
                {
                    if (targetFileName == Path.GetFileName(sourceListEntry))
                    {
                        source = sourceListEntry;
                        sourceCount++;
                    }
                }
                if (sourceCount == 0)
                {
                    AddLogText(string.Format("No source file found for {0} => not used!", targetFileName));
                }
                else if (sourceCount > 1)
                {
                    AddLogText(string.Format("Multiple source files ({0}) found for {1} => not used!", sourceCount, targetFileName));
                }
                else
                {
                    finalFileList.Add(new Source2target(source, target));
                }
                iCount++;
                progressBar.Value = iCount;
            }
            AddLogText(string.Format("{0} files found for replacement", finalFileList.Count));
            progressBar.Visible = false;
        }

        private void ButtonReplace_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(targetSize.Text, out int targetSizeValue))
            {
                AddLogText(string.Format("ERROR:Target image size not selected!", finalFileList.Count), true);
            }
            else if (finalFileList.Count() < 1)
            {
                AddLogText(string.Format("ERROR: There are no files to replace!"), true);
            }
            else
            {
                int iCount = 0;
                progressBar.Minimum = 0;
                progressBar.Maximum = finalFileList.Count();
                progressBar.Value = 0;
                progressBar.Visible = true;

                foreach (Source2target filePair in finalFileList)
                {
                    if (targetSizeValue == 2048)
                    {
                        File.Copy(filePair.sourceFile, filePair.tagetFile, true);
                    }
                    else
                    {
                        Bitmap orgBitmap = new Bitmap(filePair.sourceFile);
                        Bitmap newBitmap = new Bitmap(targetSizeValue, targetSizeValue);


                        Graphics workPicture = Graphics.FromImage(newBitmap);
                        workPicture.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                        workPicture.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        workPicture.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                        Rectangle rect = new Rectangle(0, 0, targetSizeValue, targetSizeValue);
                        workPicture.DrawImage(orgBitmap, rect, 0, 0, orgBitmap.Width, orgBitmap.Height, GraphicsUnit.Pixel);

                        newBitmap.Save(filePair.tagetFile, System.Drawing.Imaging.ImageFormat.Png);

                        orgBitmap.Dispose();
                        newBitmap.Dispose();
                        workPicture = null;
                    }
                    iCount++;
                    progressBar.Value = iCount;
                    AddLogText(string.Format("{0}. {1} replaced", iCount, Path.GetFileName(filePair.tagetFile)));
                }
                progressBar.Visible = false;
            }
        }

        // Log Area
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            LogText.Clear();
            LogText.Update();
        }

        private void AddLogText(string logText, bool isError = false)
        {
            if (isError)
            {
                LogText.SelectionColor = Color.Red;
            }
            else
            {
                LogText.SelectionColor = Color.Black;
            }
            LogText.AppendText(Environment.NewLine + logText);
            LogText.ScrollToCaret();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }
    }
}
