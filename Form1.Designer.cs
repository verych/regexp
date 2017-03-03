namespace verych_regexp_editor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("^[A-Za-z0-9](([_\\.\\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\\.\\-]?[a-zA-Z0-9]+)*)\\.([A" +
                    "-Za-z]{2,})$");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("\\w+([-+.]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*([,;]\\s*\\w+([-+.]\\w+)*@\\w+([-.]\\w+)*\\." +
                    "\\w+([-.]\\w+)*)*");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode(resources.GetString("treeView1.Nodes"));
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("^\\w+@[a-zA-Z_]+?\\.[a-zA-Z]{2,3}$");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Emails", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("^([a-zA-Z0-9]([a-zA-Z0-9\\-]{0,61}[a-zA-Z0-9])?\\.)+[a-zA-Z]{2,6}$");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("^[^\\\\\\./:\\*\\?\\\"<>\\|]{1}[^\\\\/:\\*\\?\\\"<>\\|]{0,254}$");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("^[^\\\\\\/\\?\\*\\&quot;\\\'\\&gt;\\&lt;\\:\\|]*$");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("^([a-zA-Z]\\:) (\\\\{1}| ((\\\\{1}) [^\\\\] ([^/:*?&lt;&gt;&quot;|]*(?&lt;![ ])))+)$");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("(?<domain>[^/\\r\\n\\:]+)? (?<port>\\:\\d+)? (?<path>(?:\\/.*)*\\/)? (?<filename>.*?\\.(?" +
                    "<ext>\\w{2,4}))? (?<qrystr>\\??(?:\\w+\\=[^\\#]+)(?:\\&?\\w+\\=\\w+)*)* (?<bkmrk>\\#.*)?");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode(resources.GetString("treeView1.Nodes1"));
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Uri", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("^\\$?\\d+(\\.(\\d{2}))?$");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("^[-+]?[0-9]+[.]?[0-9]*([eE][-+]?[0-9]+)?$");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("^(\\d{1,3}\'(\\d{3}\')*\\d{3}(\\.\\d{1,3})?|\\d{1,3}(\\.\\d{3})?)$");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Numbers", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("(?s)(?:\\e\\[(?:(\\d+);?)*([A-Za-z])(.*?))(?=\\e\\[|\\z)");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("^(?!000)([0-6]\\d{2}|7([0-6]\\d|7[012]))([ -]?)(?!00)\\d\\d\\3(?!0000)\\d{4}$");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("(NOT)?(\\s*\\(*)\\s*(\\w+)\\s*(=|&lt;&gt;|&lt;|&gt;|LIKE|IN)\\s*(\\(([^\\)]*)\\)|\'([^\']*)\'" +
                    "|(-?\\d*\\.?\\d+))(\\s*\\)*\\s*)(AND|OR)?");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("ISBN\\x20(?=.{13}$)\\d{1,5}([- ])\\d{1,7}\\1\\d{1,6}\\1(\\d|X)$");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("(\\d{6}[-\\s]?\\d{12})|(\\d{4}[-\\s]?\\d{4}[-\\s]?\\d{4}[-\\s]?\\d{4})");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("^(\\d{4}-){3}\\d{4}$|^(\\d{4} ){3}\\d{4}$|^\\d{16}$");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("^[a-zA-Z]+(([\\\'\\,\\.\\-][a-zA-Z])?[a-zA-Z]*)*$");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("^(?=.*\\d)(?=.*[a-zA-Z])(?!.*[\\W_\\x7B-\\xFF]).{6,15}$");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Strings", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode(resources.GetString("treeView1.Nodes2"));
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode(resources.GetString("treeView1.Nodes3"));
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode(resources.GetString("treeView1.Nodes4"));
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("^(([0]?[0-5][0-9]|[0-9]):([0-5][0-9]))$");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Date and Time", new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("^[+][0-9]\\d{2}-\\d{3}-\\d{4}$");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("^[A-Za-z]{1,2}[\\d]{1,2}([A-Za-z])?\\s?[\\d][A-Za-z]{2}$");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("^(?-i:A[LKSZRAEP]|C[AOT]|D[EC]|F[LM]|G[AU]|HI|I[ADLN]|K[SY]|LA|M[ADEHINOPST]|N[CD" +
                    "EHJMVY]|O[HKR]|P[ARW]|RI|S[CD]|T[NX]|UT|V[AIT]|W[AIVY])$");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Address / Phone", new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode32,
            treeNode33});
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("(\\[(\\w+)\\s*(([\\w]*)=(\'|&quot;)?([a-zA-Z0-9|:|\\/|=|-|.|\\?|&amp;]*)(\\5)?)*\\])([a-zA" +
                    "-Z0-9|:|\\/|=|-|.|\\?|&amp;|\\s]+)(\\[\\/\\2\\])");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode(resources.GetString("treeView1.Nodes5"));
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("(?i:on(blur|c(hange|lick)|dblclick|focus|keypress|(key|mouse)(down|up)|(un)?load|" +
                    "mouse(move|o(ut|ver))|reset|s(elect|ubmit)))");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("^#?(([fFcC0369])\\2){3}$");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("(SELECT\\s[\\w\\*\\)\\(\\,\\s]+\\sFROM\\s[\\w]+)| (UPDATE\\s[\\w]+\\sSET\\s[\\w\\,\\\'\\=]+)| (INSER" +
                    "T\\sINTO\\s[\\d\\w]+[\\s\\w\\d\\)\\(\\,]*\\sVALUES\\s\\([\\d\\w\\\'\\,\\)]+)| (DELETE\\sFROM\\s[\\d\\w\\" +
                    "\'\\=]+)");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("MarkUp / Code", new System.Windows.Forms.TreeNode[] {
            treeNode35,
            treeNode36,
            treeNode37,
            treeNode38,
            treeNode39});
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("RegExpLib", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode12,
            treeNode16,
            treeNode25,
            treeNode30,
            treeNode34,
            treeNode40});
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.TextBox();
            this.checkBoxReplace = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusL1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusL2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxBracket = new System.Windows.Forms.CheckBox();
            this.checkBoxMLine = new System.Windows.Forms.CheckBox();
            this.checkBoxSingleLine = new System.Windows.Forms.CheckBox();
            this.checkBoxIgnorCase = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBoxRegDescription = new System.Windows.Forms.RichTextBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.textBoxRegBody = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.checkBoxReplace);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(6, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Regexp";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.Location = new System.Drawing.Point(10, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(387, 20);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Text = "(\\w+@[\\w.]+)|(%.*?%)|([A-Z][a-z]+\\s[A-Z][a-z]+)|(\".*?\")";
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // checkBoxReplace
            // 
            this.checkBoxReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxReplace.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxReplace.AutoSize = true;
            this.checkBoxReplace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxReplace.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkBoxReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxReplace.Location = new System.Drawing.Point(403, 19);
            this.checkBoxReplace.Name = "checkBoxReplace";
            this.checkBoxReplace.Size = new System.Drawing.Size(60, 23);
            this.checkBoxReplace.TabIndex = 9;
            this.checkBoxReplace.Text = "Rerplace";
            this.checkBoxReplace.UseVisualStyleBackColor = true;
            this.checkBoxReplace.CheckedChanged += new System.EventHandler(this.checkBoxIgnorCase_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(10, 45);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(453, 49);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "-=*[[$0]]*=-";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.webBrowser1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 163);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 224F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(474, 195);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 189);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(240, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(231, 189);
            this.webBrowser1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusL1,
            this.statusL2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 390);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(494, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusL1
            // 
            this.statusL1.Name = "statusL1";
            this.statusL1.Size = new System.Drawing.Size(53, 17);
            this.statusL1.Text = "just do it";
            // 
            // statusL2
            // 
            this.statusL2.Name = "statusL2";
            this.statusL2.Size = new System.Drawing.Size(21, 17);
            this.statusL2.Text = "(0)";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.checkBoxBracket);
            this.groupBox2.Controls.Add(this.checkBoxMLine);
            this.groupBox2.Controls.Add(this.checkBoxSingleLine);
            this.groupBox2.Controls.Add(this.checkBoxIgnorCase);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 45);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // checkBoxBracket
            // 
            this.checkBoxBracket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxBracket.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxBracket.AutoSize = true;
            this.checkBoxBracket.Checked = true;
            this.checkBoxBracket.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBracket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxBracket.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkBoxBracket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxBracket.Location = new System.Drawing.Point(404, 16);
            this.checkBoxBracket.Name = "checkBoxBracket";
            this.checkBoxBracket.Size = new System.Drawing.Size(59, 23);
            this.checkBoxBracket.TabIndex = 9;
            this.checkBoxBracket.Text = "Brackets";
            this.checkBoxBracket.UseVisualStyleBackColor = true;
            this.checkBoxBracket.CheckedChanged += new System.EventHandler(this.checkBoxIgnorCase_Click);
            // 
            // checkBoxMLine
            // 
            this.checkBoxMLine.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxMLine.AutoSize = true;
            this.checkBoxMLine.Checked = true;
            this.checkBoxMLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxMLine.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkBoxMLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxMLine.Location = new System.Drawing.Point(137, 16);
            this.checkBoxMLine.Name = "checkBoxMLine";
            this.checkBoxMLine.Size = new System.Drawing.Size(61, 23);
            this.checkBoxMLine.TabIndex = 8;
            this.checkBoxMLine.Text = "Multy line";
            this.checkBoxMLine.UseVisualStyleBackColor = true;
            this.checkBoxMLine.Click += new System.EventHandler(this.checkBoxIgnorCase_Click);
            // 
            // checkBoxSingleLine
            // 
            this.checkBoxSingleLine.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxSingleLine.AutoSize = true;
            this.checkBoxSingleLine.Checked = true;
            this.checkBoxSingleLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSingleLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxSingleLine.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkBoxSingleLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxSingleLine.Location = new System.Drawing.Point(83, 16);
            this.checkBoxSingleLine.Name = "checkBoxSingleLine";
            this.checkBoxSingleLine.Size = new System.Drawing.Size(48, 23);
            this.checkBoxSingleLine.TabIndex = 8;
            this.checkBoxSingleLine.Text = "Dot All";
            this.checkBoxSingleLine.UseVisualStyleBackColor = true;
            this.checkBoxSingleLine.Click += new System.EventHandler(this.checkBoxIgnorCase_Click);
            // 
            // checkBoxIgnorCase
            // 
            this.checkBoxIgnorCase.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxIgnorCase.AutoSize = true;
            this.checkBoxIgnorCase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxIgnorCase.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkBoxIgnorCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxIgnorCase.Location = new System.Drawing.Point(10, 16);
            this.checkBoxIgnorCase.Name = "checkBoxIgnorCase";
            this.checkBoxIgnorCase.Size = new System.Drawing.Size(67, 23);
            this.checkBoxIgnorCase.TabIndex = 6;
            this.checkBoxIgnorCase.Text = "Ignor case";
            this.checkBoxIgnorCase.UseVisualStyleBackColor = true;
            this.checkBoxIgnorCase.Click += new System.EventHandler(this.checkBoxIgnorCase_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(494, 390);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(486, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PegExp";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(486, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Smart Help";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(480, 358);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.richTextBoxRegDescription);
            this.tabPage3.Controls.Add(this.buttonApply);
            this.tabPage3.Controls.Add(this.textBoxRegBody);
            this.tabPage3.Controls.Add(this.treeView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(486, 364);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Examples";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBoxRegDescription
            // 
            this.richTextBoxRegDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxRegDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxRegDescription.Location = new System.Drawing.Point(8, 221);
            this.richTextBoxRegDescription.Name = "richTextBoxRegDescription";
            this.richTextBoxRegDescription.Size = new System.Drawing.Size(472, 137);
            this.richTextBoxRegDescription.TabIndex = 4;
            this.richTextBoxRegDescription.Text = "";
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply.Location = new System.Drawing.Point(377, 193);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(103, 23);
            this.buttonApply.TabIndex = 3;
            this.buttonApply.Text = "Use this";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // textBoxRegBody
            // 
            this.textBoxRegBody.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRegBody.Location = new System.Drawing.Point(8, 195);
            this.textBoxRegBody.Name = "textBoxRegBody";
            this.textBoxRegBody.Size = new System.Drawing.Size(363, 20);
            this.textBoxRegBody.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node2";
            treeNode1.Text = "^[A-Za-z0-9](([_\\.\\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\\.\\-]?[a-zA-Z0-9]+)*)\\.([A" +
                "-Za-z]{2,})$";
            treeNode1.ToolTipText = resources.GetString("treeNode1.ToolTipText");
            treeNode2.Name = "Node3";
            treeNode2.Text = "\\w+([-+.]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*([,;]\\s*\\w+([-+.]\\w+)*@\\w+([-.]\\w+)*\\." +
                "\\w+([-.]\\w+)*)*";
            treeNode2.ToolTipText = resources.GetString("treeNode2.ToolTipText");
            treeNode3.Name = "Node0";
            treeNode3.Text = resources.GetString("treeNode3.Text");
            treeNode3.ToolTipText = "email address (RFC 2822 mailbox) ";
            treeNode4.Name = "Node1";
            treeNode4.Text = "^\\w+@[a-zA-Z_]+?\\.[a-zA-Z]{2,3}$";
            treeNode4.ToolTipText = resources.GetString("treeNode4.ToolTipText");
            treeNode5.Name = "Node1";
            treeNode5.Tag = "dfg d";
            treeNode5.Text = "Emails";
            treeNode6.Name = "Node3";
            treeNode6.Text = "^([a-zA-Z0-9]([a-zA-Z0-9\\-]{0,61}[a-zA-Z0-9])?\\.)+[a-zA-Z]{2,6}$";
            treeNode6.ToolTipText = resources.GetString("treeNode6.ToolTipText");
            treeNode7.Name = "Node4";
            treeNode7.Text = "^[^\\\\\\./:\\*\\?\\\"<>\\|]{1}[^\\\\/:\\*\\?\\\"<>\\|]{0,254}$";
            treeNode7.ToolTipText = resources.GetString("treeNode7.ToolTipText");
            treeNode8.Name = "Node5";
            treeNode8.Text = "^[^\\\\\\/\\?\\*\\&quot;\\\'\\&gt;\\&lt;\\:\\|]*$";
            treeNode8.ToolTipText = "Validation of a Folder Name. Excludes all forbidden characters";
            treeNode9.Name = "Node6";
            treeNode9.Text = "^([a-zA-Z]\\:) (\\\\{1}| ((\\\\{1}) [^\\\\] ([^/:*?&lt;&gt;&quot;|]*(?&lt;![ ])))+)$";
            treeNode9.ToolTipText = "Validates windows path and invalidates UNC path";
            treeNode10.Name = "Node7";
            treeNode10.Text = "(?<domain>[^/\\r\\n\\:]+)? (?<port>\\:\\d+)? (?<path>(?:\\/.*)*\\/)? (?<filename>.*?\\.(?" +
                "<ext>\\w{2,4}))? (?<qrystr>\\??(?:\\w+\\=[^\\#]+)(?:\\&?\\w+\\=\\w+)*)* (?<bkmrk>\\#.*)?";
            treeNode10.ToolTipText = resources.GetString("treeNode10.ToolTipText");
            treeNode11.Name = "Node8";
            treeNode11.Text = resources.GetString("treeNode11.Text");
            treeNode11.ToolTipText = "Url matching";
            treeNode12.Name = "Node2";
            treeNode12.Text = "Uri";
            treeNode13.Name = "Node10";
            treeNode13.Text = "^\\$?\\d+(\\.(\\d{2}))?$";
            treeNode13.ToolTipText = "To evaluate an amount with or without a dollar sign where the cents are optional." +
                "";
            treeNode14.Name = "Node11";
            treeNode14.Text = "^[-+]?[0-9]+[.]?[0-9]*([eE][-+]?[0-9]+)?$";
            treeNode14.ToolTipText = "This matches floating point expression in a more rigorous way - accepts both expo" +
                "nent as well as non exponent notations.";
            treeNode15.Name = "Node12";
            treeNode15.Text = "^(\\d{1,3}\'(\\d{3}\')*\\d{3}(\\.\\d{1,3})?|\\d{1,3}(\\.\\d{3})?)$";
            treeNode15.ToolTipText = resources.GetString("treeNode15.ToolTipText");
            treeNode16.Name = "Node9";
            treeNode16.Text = "Numbers";
            treeNode17.Name = "Node14";
            treeNode17.Text = "(?s)(?:\\e\\[(?:(\\d+);?)*([A-Za-z])(.*?))(?=\\e\\[|\\z)";
            treeNode17.ToolTipText = resources.GetString("treeNode17.ToolTipText");
            treeNode18.Name = "Node15";
            treeNode18.Text = "^(?!000)([0-6]\\d{2}|7([0-6]\\d|7[012]))([ -]?)(?!00)\\d\\d\\3(?!0000)\\d{4}$";
            treeNode18.ToolTipText = "This regex validates U.S. social security numbers, within the range of numbers th" +
                "at have been currently allocated.";
            treeNode19.Name = "Node16";
            treeNode19.Text = "(NOT)?(\\s*\\(*)\\s*(\\w+)\\s*(=|&lt;&gt;|&lt;|&gt;|LIKE|IN)\\s*(\\(([^\\)]*)\\)|\'([^\']*)\'" +
                "|(-?\\d*\\.?\\d+))(\\s*\\)*\\s*)(AND|OR)?";
            treeNode19.ToolTipText = resources.GetString("treeNode19.ToolTipText");
            treeNode20.Name = "Node17";
            treeNode20.Text = "ISBN\\x20(?=.{13}$)\\d{1,5}([- ])\\d{1,7}\\1\\d{1,6}\\1(\\d|X)$";
            treeNode20.ToolTipText = "This RE validates the format of an ISBN number";
            treeNode21.Name = "Node18";
            treeNode21.Text = "(\\d{6}[-\\s]?\\d{12})|(\\d{4}[-\\s]?\\d{4}[-\\s]?\\d{4}[-\\s]?\\d{4})";
            treeNode21.ToolTipText = resources.GetString("treeNode21.ToolTipText");
            treeNode22.Name = "Node20";
            treeNode22.Text = "^(\\d{4}-){3}\\d{4}$|^(\\d{4} ){3}\\d{4}$|^\\d{16}$";
            treeNode22.ToolTipText = "Used to validate Credit Card numbers, Checks if it contains 16 numbers in groups " +
                "of 4 separated by -, ,or nothing";
            treeNode23.Name = "Node21";
            treeNode23.Text = "^[a-zA-Z]+(([\\\'\\,\\.\\-][a-zA-Z])?[a-zA-Z]*)*$";
            treeNode23.ToolTipText = "This allows you to validate first names and last names in seperate fields. Instea" +
                "d of validating a full name in one field.";
            treeNode24.Name = "Node22";
            treeNode24.Text = "^(?=.*\\d)(?=.*[a-zA-Z])(?!.*[\\W_\\x7B-\\xFF]).{6,15}$";
            treeNode24.ToolTipText = "Password validator Requires 6-20 characters including at least 1 upper or lower a" +
                "lpha, and 1 digit. It should disallow just about everything else, inluding exten" +
                "ded characters.";
            treeNode25.Name = "Node13";
            treeNode25.Text = "Strings";
            treeNode26.Name = "Node24";
            treeNode26.Text = resources.GetString("treeNode26.Text");
            treeNode26.ToolTipText = " Matches DD/MM/Y or DD/MM/YYYY or D/M/Y or DD/M/YYYY Leap years treated. (Italian" +
                " style with tomato) Years 0-9 equal years 2000 to 2009 for leap years";
            treeNode27.Name = "Node25";
            treeNode27.Text = resources.GetString("treeNode27.Text");
            treeNode27.ToolTipText = "DD.MM.YY or DD.MM.YYYY separator could be on choice \'.\' \'/\' or \'-\' leap years com" +
                "patible, 00 is treated as year 2000.";
            treeNode28.Name = "Node26";
            treeNode28.Text = resources.GetString("treeNode28.Text");
            treeNode28.ToolTipText = resources.GetString("treeNode28.ToolTipText");
            treeNode29.Name = "Node27";
            treeNode29.Text = "^(([0]?[0-5][0-9]|[0-9]):([0-5][0-9]))$";
            treeNode29.ToolTipText = resources.GetString("treeNode29.ToolTipText");
            treeNode30.Name = "Node23";
            treeNode30.Text = "Date and Time";
            treeNode31.Name = "Node29";
            treeNode31.Text = "^[+][0-9]\\d{2}-\\d{3}-\\d{4}$";
            treeNode31.ToolTipText = resources.GetString("treeNode31.ToolTipText");
            treeNode32.Name = "Node30";
            treeNode32.Text = "^[A-Za-z]{1,2}[\\d]{1,2}([A-Za-z])?\\s?[\\d][A-Za-z]{2}$";
            treeNode32.ToolTipText = resources.GetString("treeNode32.ToolTipText");
            treeNode33.Name = "Node31";
            treeNode33.Text = "^(?-i:A[LKSZRAEP]|C[AOT]|D[EC]|F[LM]|G[AU]|HI|I[ADLN]|K[SY]|LA|M[ADEHINOPST]|N[CD" +
                "EHJMVY]|O[HKR]|P[ARW]|RI|S[CD]|T[NX]|UT|V[AIT]|W[AIVY])$";
            treeNode33.ToolTipText = "The RE match U.S. state abbreviation used by the U.S. Post Office.";
            treeNode34.Name = "Node28";
            treeNode34.Text = "Address / Phone";
            treeNode35.Name = "Node33";
            treeNode35.Text = "(\\[(\\w+)\\s*(([\\w]*)=(\'|&quot;)?([a-zA-Z0-9|:|\\/|=|-|.|\\?|&amp;]*)(\\5)?)*\\])([a-zA" +
                "-Z0-9|:|\\/|=|-|.|\\?|&amp;|\\s]+)(\\[\\/\\2\\])";
            treeNode35.ToolTipText = resources.GetString("treeNode35.ToolTipText");
            treeNode36.Name = "Node34";
            treeNode36.Text = resources.GetString("treeNode36.Text");
            treeNode36.ToolTipText = "This RE will match all the valid elements in HTML 4.01";
            treeNode37.Name = "Node35";
            treeNode37.Text = "(?i:on(blur|c(hange|lick)|dblclick|focus|keypress|(key|mouse)(down|up)|(un)?load|" +
                "mouse(move|o(ut|ver))|reset|s(elect|ubmit)))";
            treeNode37.ToolTipText = "This regex will match all the valid on event attributes in HTML 4.01/XHTML 1.0";
            treeNode38.Name = "Node36";
            treeNode38.Text = "^#?(([fFcC0369])\\2){3}$";
            treeNode38.ToolTipText = "Matches the 216 web colors with or without the \'#\' sign.";
            treeNode39.Name = "Node37";
            treeNode39.Text = "(SELECT\\s[\\w\\*\\)\\(\\,\\s]+\\sFROM\\s[\\w]+)| (UPDATE\\s[\\w]+\\sSET\\s[\\w\\,\\\'\\=]+)| (INSER" +
                "T\\sINTO\\s[\\d\\w]+[\\s\\w\\d\\)\\(\\,]*\\sVALUES\\s\\([\\d\\w\\\'\\,\\)]+)| (DELETE\\sFROM\\s[\\d\\w\\" +
                "\'\\=]+)";
            treeNode39.ToolTipText = "This RE match the SQL Basics Queries (SELECT, UPDATE, INSERT and DELETE).";
            treeNode40.Name = "Node32";
            treeNode40.Text = "MarkUp / Code";
            treeNode41.Checked = true;
            treeNode41.Name = "Node0";
            treeNode41.Text = "RegExpLib";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode41});
            this.treeView1.Size = new System.Drawing.Size(486, 189);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 412);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.MinimumSize = new System.Drawing.Size(500, 450);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verych\'s Regexp editor 1.0.1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusL1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxSingleLine;
        private System.Windows.Forms.CheckBox checkBoxIgnorCase;
        private System.Windows.Forms.CheckBox checkBoxBracket;
        private System.Windows.Forms.RichTextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBoxReplace;
        private System.Windows.Forms.ToolStripStatusLabel statusL2;
        private System.Windows.Forms.TextBox comboBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.TextBox textBoxRegBody;
        private System.Windows.Forms.RichTextBox richTextBoxRegDescription;
        private System.Windows.Forms.CheckBox checkBoxMLine;
    }
}

