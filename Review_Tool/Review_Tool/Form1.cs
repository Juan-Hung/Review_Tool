using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Reflection;

namespace XMLProcessorApp
{
    public partial class MainForm : Form
    {
        private string inputFilePath;
        private string targetFolderPath;
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            DisplayAssemblyVersion();
            inputFilePath = XML_Combobox.Text;
            targetFolderPath = Program_Combobox.Text;
        }
        private void DisplayAssemblyVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            Version version = assembly.GetName().Version;

            label1.Text = $"V: {version}";
        }
        private void BrowseInputButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    inputFilePath = openFileDialog.FileName;
                    XML_Combobox.Text = openFileDialog.FileName;
                }
            }
        }
        private void ProgramSetPathButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    targetFolderPath = folderBrowserDialog.SelectedPath;
                    Program_Combobox.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }
        private void ProcessButton_Click(object sender, EventArgs e)
        {
            string outputFilePath = Path.Combine(Path.GetDirectoryName(inputFilePath), "result.log");

            Review_Tool.XML_UI form = new Review_Tool.XML_UI(inputFilePath, targetFolderPath);
            form.Show();

            try
            {
                ProcessXml(inputFilePath, outputFilePath);
                MessageBox.Show($"Results written to {outputFilePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpenLogFileWithNotepadPlusPlus(outputFilePath);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Error: XML file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void OpenLogFileWithNotepadPlusPlus(string filePath)
        {
            try
            {
                System.Diagnostics.Process.Start("notepad++.exe", filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening Notepad++: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ProcessXml(string inputFilePath, string outputFilePath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(inputFilePath);

            XmlNodeList nodesWithAttributes = xmlDoc.SelectNodes("//TEST[@Name and @RunTest and @FilePath] | //TEST[starts-with(@Name, 'Group')]");

            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                foreach (XmlNode node in nodesWithAttributes)
                {
                    writer.WriteLine(new string('-', 100));
                    XmlAttribute nameAttribute = node.Attributes["Name"];
                    XmlAttribute runTestAttribute = node.Attributes["RunTest"];
                    XmlAttribute filePathAttribute = node.Attributes["FilePath"];
                    XmlAttribute PassFlagAttribute = node.Attributes["PassFlag"];
                    XmlAttribute LogFileAttribute = node.Attributes["LogFile"];

                    if (nameAttribute.Value.StartsWith("Group"))
                    {
                        string trimmedValue = nameAttribute.Value.Replace(" ", "");
                        int padding = (80 - nameAttribute.Value.Length) / 2;
                        writer.WriteLine($"{new string(' ', padding)}{trimmedValue}{new string(' ', padding)}");
                    }
                    else
                    {
                        writer.Write(Name_checkBox.Checked ? $"{PadRight(nameAttribute?.Value ?? string.Empty, 20)}" : string.Empty);
                        writer.Write(RunTest_checkBox.Checked ? $"{PadRight(runTestAttribute?.Value ?? string.Empty, 10)}" : string.Empty);
                        writer.Write(FilePath_checkBox.Checked ? $"{PadRight(filePathAttribute?.Value ?? string.Empty, 50)}" : string.Empty);
                        writer.Write(PathFlag_checkBox.Checked ? $"{PadRight(PassFlagAttribute?.Value ?? string.Empty, 40)}" : string.Empty);
                        writer.Write(LogFile_checkBox.Checked ? $"{PadRight(LogFileAttribute?.Value ?? string.Empty, 60)}" : string.Empty);
                        writer.WriteLine();
                        ProcessBatFile(filePathAttribute.Value, writer);
                    }
                }
            }
        }
        private void ProcessBatFile(string filepath, StreamWriter writer)
        {
            string fixedPath = "C:\\WINFUNC\\PROGRAM\\";
            string modifiedPath = filepath.Replace(fixedPath, "");
            string targetPath = Path.Combine(targetFolderPath, modifiedPath);

            writer.WriteLine();
            if (!File.Exists(targetPath))
            {
                writer.WriteLine($"Target file does not exist: {targetPath}");
                return;
            }

            string[] lines = File.ReadAllLines(targetPath);
            string LogFlag = $"ECHO %date% %time%";
            string OKFlag = $".ok";
            string ItemFlag = $"item=";

            foreach (string line in lines)
            {
                if (Log_checkBox.Checked && line.IndexOf(LogFlag, StringComparison.OrdinalIgnoreCase) != -1)
                {
                    writer.WriteLine($"{line}");
                }
                if (OK_checkBox.Checked && line.IndexOf(OKFlag, StringComparison.OrdinalIgnoreCase) != -1)
                {
                    writer.WriteLine($"{line}");
                }
                if (item_checkBox.Checked && line.IndexOf(ItemFlag, StringComparison.OrdinalIgnoreCase) != -1)
                {
                    writer.WriteLine($"{line}");
                }
            }
            writer.WriteLine();
        }
        private string PadRight(string input, int length)
        {
            return input.PadRight(length);
        }
        private void Program_Combobox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(DataFormats.FileDrop) is string[] files && files.Length > 0)
            {
                Program_Combobox.Text = files[0];
            }
        }
        private void Program_Combobox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] items = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (items != null && items.Length > 0 && Directory.Exists(items[0]))
                {
                    e.Effect = DragDropEffects.All;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void Program_Combobox_TextChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            string newText = Program_Combobox.Text;
            targetFolderPath = Program_Combobox.Text;
        }
        private void XML_Combobox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(DataFormats.FileDrop) is string[] files && files.Length > 0)
            {
                XML_Combobox.Text = files[0];
            }
        }
        private void XML_Combobox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (files != null && files.Length > 0 && IsXmlFile(files[0]))
                {
                    e.Effect = DragDropEffects.All;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void XML_Combobox_TextChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            string newText = XML_Combobox.Text;
            inputFilePath = XML_Combobox.Text;
        }
        private bool IsXmlFile(string filePath)
        {
            string extension = System.IO.Path.GetExtension(filePath);
            return !string.IsNullOrEmpty(extension) && extension.Equals(".xml", StringComparison.OrdinalIgnoreCase);
        }
    }
}