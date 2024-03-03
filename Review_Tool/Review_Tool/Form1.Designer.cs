
namespace XMLProcessorApp
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Name_checkBox = new System.Windows.Forms.CheckBox();
            this.browseOutputButton = new System.Windows.Forms.Button();
            this.ProgramSetPath = new System.Windows.Forms.Label();
            this.InputPathlabel = new System.Windows.Forms.Label();
            this.browseInputButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Program_Combobox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.XML_Combobox = new System.Windows.Forms.TextBox();
            this.Xml_Panel = new System.Windows.Forms.Panel();
            this.LogFile_checkBox = new System.Windows.Forms.CheckBox();
            this.PathFlag_checkBox = new System.Windows.Forms.CheckBox();
            this.FilePath_checkBox = new System.Windows.Forms.CheckBox();
            this.RunTest_checkBox = new System.Windows.Forms.CheckBox();
            this.Program_Panel = new System.Windows.Forms.Panel();
            this.OK_checkBox = new System.Windows.Forms.CheckBox();
            this.Log_checkBox = new System.Windows.Forms.CheckBox();
            this.item_checkBox = new System.Windows.Forms.CheckBox();
            this.processButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Xml_Panel.SuspendLayout();
            this.Program_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(586, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Program";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(3, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Xml";
            // 
            // Name_checkBox
            // 
            this.Name_checkBox.AutoSize = true;
            this.Name_checkBox.Checked = true;
            this.Name_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Name_checkBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name_checkBox.Location = new System.Drawing.Point(3, 6);
            this.Name_checkBox.Name = "Name_checkBox";
            this.Name_checkBox.Size = new System.Drawing.Size(74, 24);
            this.Name_checkBox.TabIndex = 6;
            this.Name_checkBox.Text = "Name";
            this.Name_checkBox.UseVisualStyleBackColor = true;
            // 
            // browseOutputButton
            // 
            this.browseOutputButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.browseOutputButton.Location = new System.Drawing.Point(953, 0);
            this.browseOutputButton.Name = "browseOutputButton";
            this.browseOutputButton.Size = new System.Drawing.Size(31, 30);
            this.browseOutputButton.TabIndex = 1;
            this.browseOutputButton.Text = "...";
            this.browseOutputButton.UseVisualStyleBackColor = true;
            this.browseOutputButton.Click += new System.EventHandler(this.ProgramSetPathButton_Click);
            // 
            // ProgramSetPath
            // 
            this.ProgramSetPath.AutoSize = true;
            this.ProgramSetPath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ProgramSetPath.Location = new System.Drawing.Point(3, 6);
            this.ProgramSetPath.Name = "ProgramSetPath";
            this.ProgramSetPath.Size = new System.Drawing.Size(110, 20);
            this.ProgramSetPath.TabIndex = 4;
            this.ProgramSetPath.Text = "ProgramPath";
            // 
            // InputPathlabel
            // 
            this.InputPathlabel.AutoSize = true;
            this.InputPathlabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.InputPathlabel.Location = new System.Drawing.Point(3, 12);
            this.InputPathlabel.Name = "InputPathlabel";
            this.InputPathlabel.Size = new System.Drawing.Size(81, 20);
            this.InputPathlabel.TabIndex = 3;
            this.InputPathlabel.Text = "XML Path";
            // 
            // browseInputButton
            // 
            this.browseInputButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.browseInputButton.Location = new System.Drawing.Point(953, 8);
            this.browseInputButton.Name = "browseInputButton";
            this.browseInputButton.Size = new System.Drawing.Size(31, 27);
            this.browseInputButton.TabIndex = 0;
            this.browseInputButton.Text = "...";
            this.browseInputButton.UseVisualStyleBackColor = true;
            this.browseInputButton.Click += new System.EventHandler(this.BrowseInputButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 583F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.18239F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Xml_Panel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Program_Panel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.processButton, 2, 4);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1143, 307);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.ProgramSetPath);
            this.panel1.Controls.Add(this.browseOutputButton);
            this.panel1.Controls.Add(this.Program_Combobox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 40);
            this.panel1.TabIndex = 9;
            // 
            // Program_Combobox
            // 
            this.Program_Combobox.AllowDrop = true;
            this.Program_Combobox.Location = new System.Drawing.Point(119, 3);
            this.Program_Combobox.Name = "Program_Combobox";
            this.Program_Combobox.Size = new System.Drawing.Size(828, 29);
            this.Program_Combobox.TabIndex = 12;
            this.Program_Combobox.TextChanged += new System.EventHandler(this.Program_Combobox_TextChanged);
            this.Program_Combobox.DragDrop += new System.Windows.Forms.DragEventHandler(this.Program_Combobox_DragDrop);
            this.Program_Combobox.DragEnter += new System.Windows.Forms.DragEventHandler(this.Program_Combobox_DragEnter);
            // 
            // panel3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel3, 2);
            this.panel3.Controls.Add(this.XML_Combobox);
            this.panel3.Controls.Add(this.InputPathlabel);
            this.panel3.Controls.Add(this.browseInputButton);
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1007, 41);
            this.panel3.TabIndex = 11;
            // 
            // XML_Combobox
            // 
            this.XML_Combobox.AllowDrop = true;
            this.XML_Combobox.Location = new System.Drawing.Point(119, 8);
            this.XML_Combobox.Name = "XML_Combobox";
            this.XML_Combobox.Size = new System.Drawing.Size(828, 29);
            this.XML_Combobox.TabIndex = 4;
            this.XML_Combobox.TextChanged += new System.EventHandler(this.XML_Combobox_TextChanged);
            this.XML_Combobox.DragDrop += new System.Windows.Forms.DragEventHandler(this.XML_Combobox_DragDrop);
            this.XML_Combobox.DragEnter += new System.Windows.Forms.DragEventHandler(this.XML_Combobox_DragEnter);
            // 
            // Xml_Panel
            // 
            this.Xml_Panel.Controls.Add(this.LogFile_checkBox);
            this.Xml_Panel.Controls.Add(this.PathFlag_checkBox);
            this.Xml_Panel.Controls.Add(this.FilePath_checkBox);
            this.Xml_Panel.Controls.Add(this.RunTest_checkBox);
            this.Xml_Panel.Controls.Add(this.Name_checkBox);
            this.Xml_Panel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Xml_Panel.Location = new System.Drawing.Point(3, 107);
            this.Xml_Panel.Name = "Xml_Panel";
            this.Xml_Panel.Size = new System.Drawing.Size(577, 160);
            this.Xml_Panel.TabIndex = 6;
            // 
            // LogFile_checkBox
            // 
            this.LogFile_checkBox.AutoSize = true;
            this.LogFile_checkBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LogFile_checkBox.Location = new System.Drawing.Point(3, 126);
            this.LogFile_checkBox.Name = "LogFile_checkBox";
            this.LogFile_checkBox.Size = new System.Drawing.Size(81, 24);
            this.LogFile_checkBox.TabIndex = 12;
            this.LogFile_checkBox.Text = "LogFile";
            this.LogFile_checkBox.UseVisualStyleBackColor = true;
            // 
            // PathFlag_checkBox
            // 
            this.PathFlag_checkBox.AutoSize = true;
            this.PathFlag_checkBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PathFlag_checkBox.Location = new System.Drawing.Point(3, 96);
            this.PathFlag_checkBox.Name = "PathFlag_checkBox";
            this.PathFlag_checkBox.Size = new System.Drawing.Size(92, 24);
            this.PathFlag_checkBox.TabIndex = 11;
            this.PathFlag_checkBox.Text = "PassFlag";
            this.PathFlag_checkBox.UseVisualStyleBackColor = true;
            // 
            // FilePath_checkBox
            // 
            this.FilePath_checkBox.AutoSize = true;
            this.FilePath_checkBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FilePath_checkBox.Location = new System.Drawing.Point(3, 66);
            this.FilePath_checkBox.Name = "FilePath_checkBox";
            this.FilePath_checkBox.Size = new System.Drawing.Size(88, 24);
            this.FilePath_checkBox.TabIndex = 10;
            this.FilePath_checkBox.Text = "FilePath";
            this.FilePath_checkBox.UseVisualStyleBackColor = true;
            // 
            // RunTest_checkBox
            // 
            this.RunTest_checkBox.AutoSize = true;
            this.RunTest_checkBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RunTest_checkBox.Location = new System.Drawing.Point(3, 36);
            this.RunTest_checkBox.Name = "RunTest_checkBox";
            this.RunTest_checkBox.Size = new System.Drawing.Size(89, 24);
            this.RunTest_checkBox.TabIndex = 9;
            this.RunTest_checkBox.Text = "RunTest";
            this.RunTest_checkBox.UseVisualStyleBackColor = true;
            // 
            // Program_Panel
            // 
            this.Program_Panel.Controls.Add(this.OK_checkBox);
            this.Program_Panel.Controls.Add(this.Log_checkBox);
            this.Program_Panel.Controls.Add(this.item_checkBox);
            this.Program_Panel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Program_Panel.Location = new System.Drawing.Point(586, 107);
            this.Program_Panel.Name = "Program_Panel";
            this.Program_Panel.Size = new System.Drawing.Size(418, 160);
            this.Program_Panel.TabIndex = 7;
            // 
            // OK_checkBox
            // 
            this.OK_checkBox.AutoSize = true;
            this.OK_checkBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OK_checkBox.Location = new System.Drawing.Point(4, 6);
            this.OK_checkBox.Name = "OK_checkBox";
            this.OK_checkBox.Size = new System.Drawing.Size(104, 24);
            this.OK_checkBox.TabIndex = 10;
            this.OK_checkBox.Text = "Line \".OK\"";
            this.OK_checkBox.UseVisualStyleBackColor = true;
            // 
            // Log_checkBox
            // 
            this.Log_checkBox.AutoSize = true;
            this.Log_checkBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Log_checkBox.Location = new System.Drawing.Point(4, 36);
            this.Log_checkBox.Name = "Log_checkBox";
            this.Log_checkBox.Size = new System.Drawing.Size(109, 24);
            this.Log_checkBox.TabIndex = 9;
            this.Log_checkBox.Text = "Line \".Log\"";
            this.Log_checkBox.UseVisualStyleBackColor = true;
            // 
            // item_checkBox
            // 
            this.item_checkBox.AutoSize = true;
            this.item_checkBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.item_checkBox.Location = new System.Drawing.Point(4, 66);
            this.item_checkBox.Name = "item_checkBox";
            this.item_checkBox.Size = new System.Drawing.Size(151, 24);
            this.item_checkBox.TabIndex = 6;
            this.item_checkBox.Text = "Line \"%item%=\"";
            this.item_checkBox.UseVisualStyleBackColor = true;
            // 
            // processButton
            // 
            this.processButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.processButton.Location = new System.Drawing.Point(1010, 273);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(130, 30);
            this.processButton.TabIndex = 2;
            this.processButton.Text = "ProcessButton";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.label1.Location = new System.Drawing.Point(1081, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Version";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 332);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Review_Tool";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.Xml_Panel.ResumeLayout(false);
            this.Xml_Panel.PerformLayout();
            this.Program_Panel.ResumeLayout(false);
            this.Program_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox Name_checkBox;
        private System.Windows.Forms.Button browseOutputButton;
        private System.Windows.Forms.Label ProgramSetPath;
        private System.Windows.Forms.Label InputPathlabel;
        private System.Windows.Forms.Button browseInputButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox RunTest_checkBox;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Panel Xml_Panel;
        private System.Windows.Forms.Panel Program_Panel;
        private System.Windows.Forms.CheckBox OK_checkBox;
        private System.Windows.Forms.CheckBox Log_checkBox;
        private System.Windows.Forms.CheckBox item_checkBox;
        private System.Windows.Forms.CheckBox LogFile_checkBox;
        private System.Windows.Forms.CheckBox PathFlag_checkBox;
        private System.Windows.Forms.CheckBox FilePath_checkBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Program_Combobox;
        private System.Windows.Forms.TextBox XML_Combobox;
    }
}

