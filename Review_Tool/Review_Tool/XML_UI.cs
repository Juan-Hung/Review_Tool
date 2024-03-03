using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Review_Tool
{
    public partial class XML_UI : Form
    {
        private readonly string inputFilePath;
        private readonly string targetFolderPath;

        public XML_UI(string inputFilePath, string targetFolderPath)
        {
            this.inputFilePath = inputFilePath;
            this.targetFolderPath = targetFolderPath;
            InitializeComponent();
        }

        private void XML_UI_Load(object sender, EventArgs e)
        {
            FlowLayoutPanel flowLayoutPanel1 = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown
            };
            Controls.Add(flowLayoutPanel1);
            int flowLayoutPanelCounter = 1;
            int account = 0;


            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(inputFilePath);

            XmlNodeList testNodes = xmlDoc.SelectNodes("//TEST[@Name and @RunTest and @FilePath] | //TEST[starts-with(@Name, 'Group')]");


            foreach (XmlNode node in testNodes)
            {
                XmlAttribute nameAttribute = node.Attributes["Name"];
                XmlAttribute filePathAttribute = node.Attributes["FilePath"];
                XmlAttribute runTestAttribute = node.Attributes["RunTest"];
                string name = nameAttribute.Value;

                if (nameAttribute.Value.StartsWith("Group") || account == 0)
                {
                    Label label = new Label
                    {
                        Text = name,
                        Height = 25,
                        Width = 160
                    };
                    flowLayoutPanel1.Controls.Add(label);

                    flowLayoutPanelCounter++;
                    account++;
                }
                else
                {
                    string filepath = filePathAttribute.Value;
                    string RunTest = runTestAttribute.Value;

                    string fixedPath = "C:\\WINFUNC\\PROGRAM\\";
                    string modifiedPath = filepath.Replace(fixedPath, "");
                    string targetPath = Path.Combine(targetFolderPath, modifiedPath);

                    string currentFlowLayoutPanelName = "flowLayoutPanel" + (flowLayoutPanelCounter - 1);
                    _ = Controls[currentFlowLayoutPanelName] as FlowLayoutPanel;

                    Button button = new Button
                    {
                        Text = name,
                        Height = 25,
                        Width = 140,
                        FlatStyle = FlatStyle.Flat
                    };

                    if (string.Equals(RunTest, "true", StringComparison.OrdinalIgnoreCase) && Directory.Exists(Path.GetDirectoryName(targetPath)))
                    {
                        button.BackColor = Color.LightGreen;
                        button.FlatAppearance.BorderSize = 0; 
                    }
                    else if (string.Equals(RunTest, "true", StringComparison.OrdinalIgnoreCase) && !Directory.Exists(Path.GetDirectoryName(targetPath)))
                    {
                        button.BackColor = Color.FromArgb(255, 0, 0);
                        button.FlatAppearance.BorderSize = 0; 
                    }
                    else
                    {
                        button.BackColor = Color.LightPink;
                        button.FlatAppearance.BorderSize = 0; 
                    }

                    button.Click += (senderEvent, args) =>
                    {
                        OpenFileWithNotepadPlusPlus(targetPath);

                    };

                    flowLayoutPanel1?.Controls.Add(button);

                    Panel newlinePanel = new Panel
                    {
                        Height = 5
                    };
                    flowLayoutPanel1.Controls.Add(newlinePanel);
                }

            }
        }
        private void OpenFileWithNotepadPlusPlus(string filePath)
        {
            try
            {
                string notepadPlusPlusPath = @"C:\Program Files\Notepad++\notepad++.exe";

                Process.Start(notepadPlusPlusPath, filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"無法啟動 Notepad++: {ex.Message}");
            }
        }
    }
}
