namespace AutoExecXMLCreator
{
    partial class d
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(d));
            this.label3 = new System.Windows.Forms.Label();
            this.RemoveChar_BTN = new System.Windows.Forms.Button();
            this.RemoveCmd_BTN = new System.Windows.Forms.Button();
            this.NewChar_TB = new System.Windows.Forms.TextBox();
            this.NewCommand_TB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ChatValue_TB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddChar_BTN = new System.Windows.Forms.Button();
            this.AddCommands_BTN = new System.Windows.Forms.Button();
            this.GenerateXML_BTN = new System.Windows.Forms.Button();
            this.Characters_LB = new System.Windows.Forms.ListBox();
            this.Commands_LV = new System.Windows.Forms.ListView();
            this.label8 = new System.Windows.Forms.Label();
            this.Type_CB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RemoveAll_BTN = new System.Windows.Forms.Button();
            this.Party_CB = new System.Windows.Forms.CheckBox();
            this.Tell_CB = new System.Windows.Forms.CheckBox();
            this.LS_CB = new System.Windows.Forms.CheckBox();
            this.LS2_CB = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SelfTarget_CKB = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "New Character";
            // 
            // RemoveChar_BTN
            // 
            this.RemoveChar_BTN.Location = new System.Drawing.Point(8, 185);
            this.RemoveChar_BTN.Name = "RemoveChar_BTN";
            this.RemoveChar_BTN.Size = new System.Drawing.Size(143, 23);
            this.RemoveChar_BTN.TabIndex = 5;
            this.RemoveChar_BTN.Text = "Remove  Selected";
            this.RemoveChar_BTN.UseVisualStyleBackColor = true;
            this.RemoveChar_BTN.Click += new System.EventHandler(this.RemoveChar_BTN_Click);
            // 
            // RemoveCmd_BTN
            // 
            this.RemoveCmd_BTN.Location = new System.Drawing.Point(12, 571);
            this.RemoveCmd_BTN.Name = "RemoveCmd_BTN";
            this.RemoveCmd_BTN.Size = new System.Drawing.Size(171, 23);
            this.RemoveCmd_BTN.TabIndex = 6;
            this.RemoveCmd_BTN.Text = "Remove Selected";
            this.RemoveCmd_BTN.UseVisualStyleBackColor = true;
            this.RemoveCmd_BTN.Click += new System.EventHandler(this.RemoveCmd_BTN_Click);
            // 
            // NewChar_TB
            // 
            this.NewChar_TB.Location = new System.Drawing.Point(9, 129);
            this.NewChar_TB.Name = "NewChar_TB";
            this.NewChar_TB.Size = new System.Drawing.Size(142, 20);
            this.NewChar_TB.TabIndex = 7;
            // 
            // NewCommand_TB
            // 
            this.NewCommand_TB.Location = new System.Drawing.Point(6, 32);
            this.NewCommand_TB.Name = "NewCommand_TB";
            this.NewCommand_TB.Size = new System.Drawing.Size(146, 20);
            this.NewCommand_TB.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "New Command";
            // 
            // ChatValue_TB
            // 
            this.ChatValue_TB.Location = new System.Drawing.Point(6, 71);
            this.ChatValue_TB.Name = "ChatValue_TB";
            this.ChatValue_TB.Size = new System.Drawing.Size(146, 20);
            this.ChatValue_TB.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Chat Value";
            // 
            // AddChar_BTN
            // 
            this.AddChar_BTN.Location = new System.Drawing.Point(9, 155);
            this.AddChar_BTN.Name = "AddChar_BTN";
            this.AddChar_BTN.Size = new System.Drawing.Size(143, 23);
            this.AddChar_BTN.TabIndex = 12;
            this.AddChar_BTN.Text = "Add";
            this.AddChar_BTN.UseVisualStyleBackColor = true;
            this.AddChar_BTN.Click += new System.EventHandler(this.AddChar_BTN_Click);
            // 
            // AddCommands_BTN
            // 
            this.AddCommands_BTN.Location = new System.Drawing.Point(41, 158);
            this.AddCommands_BTN.Name = "AddCommands_BTN";
            this.AddCommands_BTN.Size = new System.Drawing.Size(84, 23);
            this.AddCommands_BTN.TabIndex = 13;
            this.AddCommands_BTN.Text = "Add";
            this.AddCommands_BTN.UseVisualStyleBackColor = true;
            this.AddCommands_BTN.Click += new System.EventHandler(this.AddCommands_BTN_Click);
            // 
            // GenerateXML_BTN
            // 
            this.GenerateXML_BTN.Location = new System.Drawing.Point(380, 571);
            this.GenerateXML_BTN.Name = "GenerateXML_BTN";
            this.GenerateXML_BTN.Size = new System.Drawing.Size(161, 23);
            this.GenerateXML_BTN.TabIndex = 14;
            this.GenerateXML_BTN.Text = "GENERATE XML!";
            this.GenerateXML_BTN.UseVisualStyleBackColor = true;
            this.GenerateXML_BTN.Click += new System.EventHandler(this.GenerateXML_BTN_Click);
            // 
            // Characters_LB
            // 
            this.Characters_LB.FormattingEnabled = true;
            this.Characters_LB.Location = new System.Drawing.Point(9, 15);
            this.Characters_LB.Name = "Characters_LB";
            this.Characters_LB.Size = new System.Drawing.Size(143, 95);
            this.Characters_LB.TabIndex = 15;
            // 
            // Commands_LV
            // 
            this.Commands_LV.AutoArrange = false;
            this.Commands_LV.FullRowSelect = true;
            this.Commands_LV.GridLines = true;
            this.Commands_LV.Location = new System.Drawing.Point(12, 45);
            this.Commands_LV.Name = "Commands_LV";
            this.Commands_LV.Size = new System.Drawing.Size(355, 520);
            this.Commands_LV.TabIndex = 21;
            this.Commands_LV.UseCompatibleStateImageBehavior = false;
            this.Commands_LV.View = System.Windows.Forms.View.Details;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(121, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Command List";
            // 
            // Type_CB
            // 
            this.Type_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type_CB.FormattingEnabled = true;
            this.Type_CB.Items.AddRange(new object[] {
            "Buff",
            "Magic Attack",
            "Job Ability",
            "Weapon Skill"});
            this.Type_CB.Location = new System.Drawing.Point(6, 110);
            this.Type_CB.Name = "Type_CB";
            this.Type_CB.Size = new System.Drawing.Size(146, 21);
            this.Type_CB.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Ability Type";
            // 
            // RemoveAll_BTN
            // 
            this.RemoveAll_BTN.Location = new System.Drawing.Point(189, 571);
            this.RemoveAll_BTN.Name = "RemoveAll_BTN";
            this.RemoveAll_BTN.Size = new System.Drawing.Size(178, 23);
            this.RemoveAll_BTN.TabIndex = 28;
            this.RemoveAll_BTN.Text = "Remove All";
            this.RemoveAll_BTN.UseVisualStyleBackColor = true;
            this.RemoveAll_BTN.Click += new System.EventHandler(this.RemoveAll_BTN_Click);
            // 
            // Party_CB
            // 
            this.Party_CB.AutoSize = true;
            this.Party_CB.Location = new System.Drawing.Point(421, 467);
            this.Party_CB.Name = "Party_CB";
            this.Party_CB.Size = new System.Drawing.Size(50, 17);
            this.Party_CB.TabIndex = 30;
            this.Party_CB.Text = "Party";
            this.Party_CB.UseVisualStyleBackColor = true;
            // 
            // Tell_CB
            // 
            this.Tell_CB.AutoSize = true;
            this.Tell_CB.Location = new System.Drawing.Point(421, 490);
            this.Tell_CB.Name = "Tell_CB";
            this.Tell_CB.Size = new System.Drawing.Size(43, 17);
            this.Tell_CB.TabIndex = 31;
            this.Tell_CB.Text = "Tell";
            this.Tell_CB.UseVisualStyleBackColor = true;
            // 
            // LS_CB
            // 
            this.LS_CB.AutoSize = true;
            this.LS_CB.Location = new System.Drawing.Point(421, 536);
            this.LS_CB.Name = "LS_CB";
            this.LS_CB.Size = new System.Drawing.Size(76, 17);
            this.LS_CB.TabIndex = 32;
            this.LS_CB.Text = "Linkshell 1";
            this.LS_CB.UseVisualStyleBackColor = true;
            // 
            // LS2_CB
            // 
            this.LS2_CB.AutoSize = true;
            this.LS2_CB.Location = new System.Drawing.Point(421, 513);
            this.LS2_CB.Name = "LS2_CB";
            this.LS2_CB.Size = new System.Drawing.Size(76, 17);
            this.LS2_CB.TabIndex = 33;
            this.LS2_CB.Text = "Linkshell 2";
            this.LS2_CB.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(551, 24);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.openToolStripMenuItem.Text = "Open Command File";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.saveToolStripMenuItem.Text = "Save Command File";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.AddExtension = false;
            // 
            // SelfTarget_CKB
            // 
            this.SelfTarget_CKB.AutoSize = true;
            this.SelfTarget_CKB.Location = new System.Drawing.Point(41, 137);
            this.SelfTarget_CKB.Name = "SelfTarget_CKB";
            this.SelfTarget_CKB.Size = new System.Drawing.Size(78, 17);
            this.SelfTarget_CKB.TabIndex = 35;
            this.SelfTarget_CKB.Text = "Self Target";
            this.SelfTarget_CKB.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.SelfTarget_CKB);
            this.groupBox1.Controls.Add(this.NewCommand_TB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ChatValue_TB);
            this.groupBox1.Controls.Add(this.AddCommands_BTN);
            this.groupBox1.Controls.Add(this.Type_CB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(380, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 190);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create a command";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Characters_LB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.RemoveChar_BTN);
            this.groupBox2.Controls.Add(this.NewChar_TB);
            this.groupBox2.Controls.Add(this.AddChar_BTN);
            this.groupBox2.Location = new System.Drawing.Point(380, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(161, 220);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current characters";
            // 
            // d
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 607);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LS2_CB);
            this.Controls.Add(this.LS_CB);
            this.Controls.Add(this.Tell_CB);
            this.Controls.Add(this.Party_CB);
            this.Controls.Add(this.RemoveAll_BTN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Commands_LV);
            this.Controls.Add(this.GenerateXML_BTN);
            this.Controls.Add(this.RemoveCmd_BTN);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "d";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Auto Exec Bot Creator";
            this.Load += new System.EventHandler(this.d_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RemoveChar_BTN;
        private System.Windows.Forms.Button RemoveCmd_BTN;
        private System.Windows.Forms.TextBox NewChar_TB;
        private System.Windows.Forms.TextBox NewCommand_TB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ChatValue_TB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddChar_BTN;
        private System.Windows.Forms.Button AddCommands_BTN;
        private System.Windows.Forms.Button GenerateXML_BTN;
        public System.Windows.Forms.ListBox Characters_LB;
        private System.Windows.Forms.ListView Commands_LV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Type_CB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RemoveAll_BTN;
        private System.Windows.Forms.CheckBox Party_CB;
        private System.Windows.Forms.CheckBox Tell_CB;
        private System.Windows.Forms.CheckBox LS_CB;
        private System.Windows.Forms.CheckBox LS2_CB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox SelfTarget_CKB;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

