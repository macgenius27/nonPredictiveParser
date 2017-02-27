namespace nonPredictiveParser
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectGrammerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutParserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutParserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_file = new System.Windows.Forms.Label();
            this.txt_grammer_file = new System.Windows.Forms.TextBox();
            this.btn_grammer_browse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_input_file = new System.Windows.Forms.TextBox();
            this.btn_input_browse = new System.Windows.Forms.Button();
            this.lbl_incorrect_input = new System.Windows.Forms.Label();
            this.lbl_correct_input = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lst_box_input = new System.Windows.Forms.ListBox();
            this.lst_box_output = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tab_page_tree = new System.Windows.Forms.TabPage();
            this.tree_view = new System.Windows.Forms.TreeView();
            this.label5 = new System.Windows.Forms.Label();
            this.tab_page_follow_sets = new System.Windows.Forms.TabPage();
            this.lst_box_follow_sets = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tab_page_first_sets = new System.Windows.Forms.TabPage();
            this.lst_box_first_sets = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tab_page_grammer = new System.Windows.Forms.TabPage();
            this.lbl_grammer = new System.Windows.Forms.Label();
            this.lst_box_grammer = new System.Windows.Forms.ListBox();
            this.tab_control = new System.Windows.Forms.TabControl();
            this.btn_clear_all = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tab_page_tree.SuspendLayout();
            this.tab_page_follow_sets.SuspendLayout();
            this.tab_page_first_sets.SuspendLayout();
            this.tab_page_grammer.SuspendLayout();
            this.tab_control.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_title.Location = new System.Drawing.Point(12, 34);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(389, 20);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Select a file having Grammer, first sets and follow sets";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutParserToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(535, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectGrammerToolStripMenuItem,
            this.selectInputToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // selectGrammerToolStripMenuItem
            // 
            this.selectGrammerToolStripMenuItem.Name = "selectGrammerToolStripMenuItem";
            this.selectGrammerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.selectGrammerToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.selectGrammerToolStripMenuItem.Text = "Select &Grammer";
            this.selectGrammerToolStripMenuItem.Click += new System.EventHandler(this.selectGrammerToolStripMenuItem_Click);
            // 
            // selectInputToolStripMenuItem
            // 
            this.selectInputToolStripMenuItem.Name = "selectInputToolStripMenuItem";
            this.selectInputToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.selectInputToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.selectInputToolStripMenuItem.Text = "Select &Input";
            this.selectInputToolStripMenuItem.Click += new System.EventHandler(this.selectInputToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.closeToolStripMenuItem1.Text = "&Close";
            this.closeToolStripMenuItem1.Click += new System.EventHandler(this.closeToolStripMenuItem1_Click);
            // 
            // aboutParserToolStripMenuItem
            // 
            this.aboutParserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutParserToolStripMenuItem1});
            this.aboutParserToolStripMenuItem.Name = "aboutParserToolStripMenuItem";
            this.aboutParserToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.aboutParserToolStripMenuItem.Text = "&About Parser";
            // 
            // aboutParserToolStripMenuItem1
            // 
            this.aboutParserToolStripMenuItem1.Name = "aboutParserToolStripMenuItem1";
            this.aboutParserToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.aboutParserToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.aboutParserToolStripMenuItem1.Text = "About &Parser";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(436, 433);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_file
            // 
            this.lbl_file.AutoSize = true;
            this.lbl_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_file.Location = new System.Drawing.Point(13, 63);
            this.lbl_file.Name = "lbl_file";
            this.lbl_file.Size = new System.Drawing.Size(38, 17);
            this.lbl_file.TabIndex = 5;
            this.lbl_file.Text = "File :";
            // 
            // txt_grammer_file
            // 
            this.txt_grammer_file.Location = new System.Drawing.Point(57, 63);
            this.txt_grammer_file.Name = "txt_grammer_file";
            this.txt_grammer_file.Size = new System.Drawing.Size(377, 20);
            this.txt_grammer_file.TabIndex = 6;
            // 
            // btn_grammer_browse
            // 
            this.btn_grammer_browse.Location = new System.Drawing.Point(440, 61);
            this.btn_grammer_browse.Name = "btn_grammer_browse";
            this.btn_grammer_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_grammer_browse.TabIndex = 7;
            this.btn_grammer_browse.Text = "Browse";
            this.btn_grammer_browse.UseVisualStyleBackColor = true;
            this.btn_grammer_browse.Click += new System.EventHandler(this.btn_grammer_browse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a file having input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "File :";
            // 
            // txt_input_file
            // 
            this.txt_input_file.Location = new System.Drawing.Point(57, 124);
            this.txt_input_file.Name = "txt_input_file";
            this.txt_input_file.Size = new System.Drawing.Size(377, 20);
            this.txt_input_file.TabIndex = 8;
            // 
            // btn_input_browse
            // 
            this.btn_input_browse.Location = new System.Drawing.Point(440, 124);
            this.btn_input_browse.Name = "btn_input_browse";
            this.btn_input_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_input_browse.TabIndex = 9;
            this.btn_input_browse.Text = "Browse";
            this.btn_input_browse.UseVisualStyleBackColor = true;
            this.btn_input_browse.Click += new System.EventHandler(this.btn_input_browse_Click);
            // 
            // lbl_incorrect_input
            // 
            this.lbl_incorrect_input.AutoSize = true;
            this.lbl_incorrect_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_incorrect_input.ForeColor = System.Drawing.Color.Red;
            this.lbl_incorrect_input.Location = new System.Drawing.Point(142, 439);
            this.lbl_incorrect_input.Name = "lbl_incorrect_input";
            this.lbl_incorrect_input.Size = new System.Drawing.Size(16, 17);
            this.lbl_incorrect_input.TabIndex = 3;
            this.lbl_incorrect_input.Text = "0";
            // 
            // lbl_correct_input
            // 
            this.lbl_correct_input.AutoSize = true;
            this.lbl_correct_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correct_input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_correct_input.Location = new System.Drawing.Point(296, 439);
            this.lbl_correct_input.Name = "lbl_correct_input";
            this.lbl_correct_input.Size = new System.Drawing.Size(16, 17);
            this.lbl_correct_input.TabIndex = 3;
            this.lbl_correct_input.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(27, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Incorrect Inputs :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(190, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Correct Inputs :";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lst_box_input);
            this.tabPage1.Controls.Add(this.lst_box_output);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(491, 248);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Output";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lst_box_input
            // 
            this.lst_box_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_box_input.FormattingEnabled = true;
            this.lst_box_input.ItemHeight = 16;
            this.lst_box_input.Location = new System.Drawing.Point(22, 30);
            this.lst_box_input.Name = "lst_box_input";
            this.lst_box_input.Size = new System.Drawing.Size(189, 196);
            this.lst_box_input.TabIndex = 5;
            // 
            // lst_box_output
            // 
            this.lst_box_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_box_output.FormattingEnabled = true;
            this.lst_box_output.ItemHeight = 16;
            this.lst_box_output.Location = new System.Drawing.Point(273, 33);
            this.lst_box_output.Name = "lst_box_output";
            this.lst_box_output.Size = new System.Drawing.Size(212, 196);
            this.lst_box_output.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(92, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Input";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(337, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Output ";
            // 
            // tab_page_tree
            // 
            this.tab_page_tree.Controls.Add(this.tree_view);
            this.tab_page_tree.Controls.Add(this.label5);
            this.tab_page_tree.Location = new System.Drawing.Point(4, 22);
            this.tab_page_tree.Name = "tab_page_tree";
            this.tab_page_tree.Padding = new System.Windows.Forms.Padding(3);
            this.tab_page_tree.Size = new System.Drawing.Size(491, 248);
            this.tab_page_tree.TabIndex = 3;
            this.tab_page_tree.Text = "Tree";
            this.tab_page_tree.UseVisualStyleBackColor = true;
            // 
            // tree_view
            // 
            this.tree_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tree_view.Location = new System.Drawing.Point(16, 36);
            this.tree_view.Name = "tree_view";
            this.tree_view.Size = new System.Drawing.Size(454, 193);
            this.tree_view.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(23, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Output Tree :";
            // 
            // tab_page_follow_sets
            // 
            this.tab_page_follow_sets.Controls.Add(this.lst_box_follow_sets);
            this.tab_page_follow_sets.Controls.Add(this.label4);
            this.tab_page_follow_sets.Location = new System.Drawing.Point(4, 22);
            this.tab_page_follow_sets.Name = "tab_page_follow_sets";
            this.tab_page_follow_sets.Padding = new System.Windows.Forms.Padding(3);
            this.tab_page_follow_sets.Size = new System.Drawing.Size(491, 248);
            this.tab_page_follow_sets.TabIndex = 2;
            this.tab_page_follow_sets.Text = "Follow Sets";
            this.tab_page_follow_sets.UseVisualStyleBackColor = true;
            // 
            // lst_box_follow_sets
            // 
            this.lst_box_follow_sets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_box_follow_sets.FormattingEnabled = true;
            this.lst_box_follow_sets.ItemHeight = 16;
            this.lst_box_follow_sets.Location = new System.Drawing.Point(22, 50);
            this.lst_box_follow_sets.Name = "lst_box_follow_sets";
            this.lst_box_follow_sets.Size = new System.Drawing.Size(453, 180);
            this.lst_box_follow_sets.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(19, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "You have provided following Follow Sets :";
            // 
            // tab_page_first_sets
            // 
            this.tab_page_first_sets.Controls.Add(this.lst_box_first_sets);
            this.tab_page_first_sets.Controls.Add(this.label3);
            this.tab_page_first_sets.Location = new System.Drawing.Point(4, 22);
            this.tab_page_first_sets.Name = "tab_page_first_sets";
            this.tab_page_first_sets.Padding = new System.Windows.Forms.Padding(3);
            this.tab_page_first_sets.Size = new System.Drawing.Size(491, 248);
            this.tab_page_first_sets.TabIndex = 1;
            this.tab_page_first_sets.Text = "First Sets";
            this.tab_page_first_sets.UseVisualStyleBackColor = true;
            // 
            // lst_box_first_sets
            // 
            this.lst_box_first_sets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_box_first_sets.FormattingEnabled = true;
            this.lst_box_first_sets.ItemHeight = 16;
            this.lst_box_first_sets.Location = new System.Drawing.Point(19, 50);
            this.lst_box_first_sets.Name = "lst_box_first_sets";
            this.lst_box_first_sets.Size = new System.Drawing.Size(448, 180);
            this.lst_box_first_sets.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(16, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "You have provided following First Sets :";
            // 
            // tab_page_grammer
            // 
            this.tab_page_grammer.Controls.Add(this.lbl_grammer);
            this.tab_page_grammer.Controls.Add(this.lst_box_grammer);
            this.tab_page_grammer.Location = new System.Drawing.Point(4, 22);
            this.tab_page_grammer.Name = "tab_page_grammer";
            this.tab_page_grammer.Padding = new System.Windows.Forms.Padding(3);
            this.tab_page_grammer.Size = new System.Drawing.Size(491, 248);
            this.tab_page_grammer.TabIndex = 0;
            this.tab_page_grammer.Text = "Grammer";
            this.tab_page_grammer.UseVisualStyleBackColor = true;
            // 
            // lbl_grammer
            // 
            this.lbl_grammer.AutoSize = true;
            this.lbl_grammer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_grammer.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_grammer.Location = new System.Drawing.Point(18, 27);
            this.lbl_grammer.Name = "lbl_grammer";
            this.lbl_grammer.Size = new System.Drawing.Size(256, 17);
            this.lbl_grammer.TabIndex = 1;
            this.lbl_grammer.Text = "You have provided following Grammer :";
            // 
            // lst_box_grammer
            // 
            this.lst_box_grammer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_box_grammer.FormattingEnabled = true;
            this.lst_box_grammer.ItemHeight = 16;
            this.lst_box_grammer.Location = new System.Drawing.Point(21, 54);
            this.lst_box_grammer.Name = "lst_box_grammer";
            this.lst_box_grammer.Size = new System.Drawing.Size(449, 180);
            this.lst_box_grammer.TabIndex = 0;
            // 
            // tab_control
            // 
            this.tab_control.Controls.Add(this.tab_page_grammer);
            this.tab_control.Controls.Add(this.tab_page_first_sets);
            this.tab_control.Controls.Add(this.tab_page_follow_sets);
            this.tab_control.Controls.Add(this.tab_page_tree);
            this.tab_control.Controls.Add(this.tabPage1);
            this.tab_control.Location = new System.Drawing.Point(16, 153);
            this.tab_control.Name = "tab_control";
            this.tab_control.SelectedIndex = 0;
            this.tab_control.Size = new System.Drawing.Size(499, 274);
            this.tab_control.TabIndex = 10;
            // 
            // btn_clear_all
            // 
            this.btn_clear_all.Location = new System.Drawing.Point(348, 433);
            this.btn_clear_all.Name = "btn_clear_all";
            this.btn_clear_all.Size = new System.Drawing.Size(75, 23);
            this.btn_clear_all.TabIndex = 11;
            this.btn_clear_all.Text = "Clear All";
            this.btn_clear_all.UseVisualStyleBackColor = true;
            this.btn_clear_all.Click += new System.EventHandler(this.btn_clear_all_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 468);
            this.Controls.Add(this.btn_clear_all);
            this.Controls.Add(this.tab_control);
            this.Controls.Add(this.lbl_incorrect_input);
            this.Controls.Add(this.btn_input_browse);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_correct_input);
            this.Controls.Add(this.txt_input_file);
            this.Controls.Add(this.btn_grammer_browse);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_grammer_file);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_file);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tab_page_tree.ResumeLayout(false);
            this.tab_page_tree.PerformLayout();
            this.tab_page_follow_sets.ResumeLayout(false);
            this.tab_page_follow_sets.PerformLayout();
            this.tab_page_first_sets.ResumeLayout(false);
            this.tab_page_first_sets.PerformLayout();
            this.tab_page_grammer.ResumeLayout(false);
            this.tab_page_grammer.PerformLayout();
            this.tab_control.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutParserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutParserToolStripMenuItem1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_file;
        private System.Windows.Forms.TextBox txt_grammer_file;
        private System.Windows.Forms.Button btn_grammer_browse;
        private System.Windows.Forms.ToolStripMenuItem selectGrammerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectInputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_input_file;
        private System.Windows.Forms.Button btn_input_browse;
        private System.Windows.Forms.Label lbl_incorrect_input;
        private System.Windows.Forms.Label lbl_correct_input;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox lst_box_input;
        private System.Windows.Forms.ListBox lst_box_output;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tab_page_tree;
        private System.Windows.Forms.TreeView tree_view;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tab_page_follow_sets;
        private System.Windows.Forms.ListBox lst_box_follow_sets;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tab_page_first_sets;
        private System.Windows.Forms.ListBox lst_box_first_sets;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tab_page_grammer;
        private System.Windows.Forms.Label lbl_grammer;
        private System.Windows.Forms.ListBox lst_box_grammer;
        private System.Windows.Forms.TabControl tab_control;
        private System.Windows.Forms.Button btn_clear_all;

    }
}

