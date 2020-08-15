namespace ChalkBoard
{
    partial class Main
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node6", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node0");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Item 0");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Item 1");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Item 2");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Item 3");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Item 4");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Item 0");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Item 1");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Item 2");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Item 3");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Item 4");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("Item 0");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("Item 1");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("Item 2");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("Item 3");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("Item 4");
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("Item 0");
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("Item 1");
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("Item 2");
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem("Item 3");
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem("Item 4");
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commitVersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChapterSelect = new System.Windows.Forms.TreeView();
            this.ChapterTreeContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemAddChap = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDeleteChap = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRenameChap = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAddScene = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDeleteScene = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRenameScene = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TextEditor = new System.Windows.Forms.TabPage();
            this.TextEditorTextBox = new System.Windows.Forms.RichTextBox();
            this.Characters = new System.Windows.Forms.TabPage();
            this.GroupTextBox = new System.Windows.Forms.RichTextBox();
            this.GroupLabel = new System.Windows.Forms.Label();
            this.FatherTextBox = new System.Windows.Forms.RichTextBox();
            this.MotherTextBox = new System.Windows.Forms.RichTextBox();
            this.SexLabel = new System.Windows.Forms.Label();
            this.SexComboBox = new System.Windows.Forms.ComboBox();
            this.FatherLabel = new System.Windows.Forms.Label();
            this.MotherLabel = new System.Windows.Forms.Label();
            this.CharactersListView = new System.Windows.Forms.ListView();
            this.CharacterMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addCharacterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCharacterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.renameCharacterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPedigreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CharacterSelect = new System.Windows.Forms.TreeView();
            this.CharacterListMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CharactersTextBox = new System.Windows.Forms.RichTextBox();
            this.Diagrams = new System.Windows.Forms.TabPage();
            this.DiagramPictureBox = new System.Windows.Forms.PictureBox();
            this.DiagramPictureBoxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.importNewImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DiagramListView = new System.Windows.Forms.ListView();
            this.DiagramListViewMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addDiagramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDiagramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameDiagramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DiagramsTextBox = new System.Windows.Forms.RichTextBox();
            this.Dictionary = new System.Windows.Forms.TabPage();
            this.DictionaryListView = new System.Windows.Forms.ListView();
            this.WordMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rewriteWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DictionarySelect = new System.Windows.Forms.TreeView();
            this.DictionaryMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addDictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameDictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DictionaryTextBox = new System.Windows.Forms.RichTextBox();
            this.Notes = new System.Windows.Forms.TabPage();
            this.NotesListView = new System.Windows.Forms.ListView();
            this.NotesStripMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NotesTextBox = new System.Windows.Forms.RichTextBox();
            this.EditMenu = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightAlignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftAlignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centerAlignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.identToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outdentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.italicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strikeOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStrip.SuspendLayout();
            this.ChapterTreeContextMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TextEditor.SuspendLayout();
            this.Characters.SuspendLayout();
            this.CharacterMenuStrip.SuspendLayout();
            this.CharacterListMenuStrip.SuspendLayout();
            this.Diagrams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiagramPictureBox)).BeginInit();
            this.DiagramPictureBoxMenu.SuspendLayout();
            this.DiagramListViewMenu.SuspendLayout();
            this.Dictionary.SuspendLayout();
            this.WordMenuStrip.SuspendLayout();
            this.DictionaryMenuStrip.SuspendLayout();
            this.Notes.SuspendLayout();
            this.NotesStripMenu.SuspendLayout();
            this.EditMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.versionControlToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(1192, 28);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBookToolStripMenuItem,
            this.openBookToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newBookToolStripMenuItem
            // 
            this.newBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newBookToolStripMenuItem.Image")));
            this.newBookToolStripMenuItem.Name = "newBookToolStripMenuItem";
            this.newBookToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.newBookToolStripMenuItem.Text = "New Book";
            this.newBookToolStripMenuItem.Click += new System.EventHandler(this.newBookToolStripMenuItem_Click);
            // 
            // openBookToolStripMenuItem
            // 
            this.openBookToolStripMenuItem.Name = "openBookToolStripMenuItem";
            this.openBookToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.openBookToolStripMenuItem.Text = "Open Book";
            this.openBookToolStripMenuItem.Click += new System.EventHandler(this.openBookToolStripMenuItem_Click);
            // 
            // versionControlToolStripMenuItem
            // 
            this.versionControlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commitVersionToolStripMenuItem,
            this.remoteConfigurationToolStripMenuItem});
            this.versionControlToolStripMenuItem.Name = "versionControlToolStripMenuItem";
            this.versionControlToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.versionControlToolStripMenuItem.Text = "Version Control";
            // 
            // commitVersionToolStripMenuItem
            // 
            this.commitVersionToolStripMenuItem.Name = "commitVersionToolStripMenuItem";
            this.commitVersionToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.commitVersionToolStripMenuItem.Text = "Commit Version";
            this.commitVersionToolStripMenuItem.Click += new System.EventHandler(this.commitVersionToolStripMenuItem_Click);
            // 
            // remoteConfigurationToolStripMenuItem
            // 
            this.remoteConfigurationToolStripMenuItem.Name = "remoteConfigurationToolStripMenuItem";
            this.remoteConfigurationToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.remoteConfigurationToolStripMenuItem.Text = "Remote Configuration";
            this.remoteConfigurationToolStripMenuItem.Click += new System.EventHandler(this.remoteConfigurationToolStripMenuItem_Click);
            // 
            // ChapterSelect
            // 
            this.ChapterSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ChapterSelect.ContextMenuStrip = this.ChapterTreeContextMenu;
            this.ChapterSelect.FullRowSelect = true;
            this.ChapterSelect.HideSelection = false;
            this.ChapterSelect.LabelEdit = true;
            this.ChapterSelect.Location = new System.Drawing.Point(8, 34);
            this.ChapterSelect.Name = "ChapterSelect";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Node1";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Node2";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Node3";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Node4";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Node5";
            treeNode6.Name = "Node7";
            treeNode6.Text = "Node7";
            treeNode7.Name = "Node8";
            treeNode7.Text = "Node8";
            treeNode8.Name = "Node9";
            treeNode8.Text = "Node9";
            treeNode9.Name = "Node6";
            treeNode9.Text = "Node6";
            treeNode10.Name = "Node0";
            treeNode10.Text = "Node0";
            treeNode11.Name = "Node0";
            treeNode11.Text = "Node0";
            treeNode12.Name = "Node1";
            treeNode12.Text = "Node1";
            this.ChapterSelect.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12});
            this.ChapterSelect.Size = new System.Drawing.Size(191, 413);
            this.ChapterSelect.TabIndex = 2;
            this.ChapterSelect.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.ChapterSelect__AfterLabelEdit);
            this.ChapterSelect.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ChapterSelect_AfterSelect);
            // 
            // ChapterTreeContextMenu
            // 
            this.ChapterTreeContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ChapterTreeContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAddChap,
            this.ToolStripMenuItemDeleteChap,
            this.ToolStripMenuItemRenameChap,
            this.ToolStripMenuItemAddScene,
            this.ToolStripMenuItemDeleteScene,
            this.ToolStripMenuItemRenameScene});
            this.ChapterTreeContextMenu.Name = "ChapterTreeContextMenu";
            this.ChapterTreeContextMenu.Size = new System.Drawing.Size(189, 148);
            this.ChapterTreeContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // ToolStripMenuItemAddChap
            // 
            this.ToolStripMenuItemAddChap.Name = "ToolStripMenuItemAddChap";
            this.ToolStripMenuItemAddChap.Size = new System.Drawing.Size(188, 24);
            this.ToolStripMenuItemAddChap.Text = "Add Chapter";
            this.ToolStripMenuItemAddChap.Click += new System.EventHandler(this.ToolStripMenuItemAddChap_Click);
            // 
            // ToolStripMenuItemDeleteChap
            // 
            this.ToolStripMenuItemDeleteChap.Name = "ToolStripMenuItemDeleteChap";
            this.ToolStripMenuItemDeleteChap.Size = new System.Drawing.Size(188, 24);
            this.ToolStripMenuItemDeleteChap.Text = "Delete Chapter";
            this.ToolStripMenuItemDeleteChap.Click += new System.EventHandler(this.ToolStripMenuItemDeleteChap_Click);
            // 
            // ToolStripMenuItemRenameChap
            // 
            this.ToolStripMenuItemRenameChap.Name = "ToolStripMenuItemRenameChap";
            this.ToolStripMenuItemRenameChap.Size = new System.Drawing.Size(188, 24);
            this.ToolStripMenuItemRenameChap.Text = "Rename Chapter";
            this.ToolStripMenuItemRenameChap.Click += new System.EventHandler(this.ToolStripMenuItemRenameChap_Click);
            // 
            // ToolStripMenuItemAddScene
            // 
            this.ToolStripMenuItemAddScene.Name = "ToolStripMenuItemAddScene";
            this.ToolStripMenuItemAddScene.Size = new System.Drawing.Size(188, 24);
            this.ToolStripMenuItemAddScene.Text = "Add Scene";
            this.ToolStripMenuItemAddScene.Click += new System.EventHandler(this.ToolStripMenuItemAddScene_Click);
            // 
            // ToolStripMenuItemDeleteScene
            // 
            this.ToolStripMenuItemDeleteScene.Name = "ToolStripMenuItemDeleteScene";
            this.ToolStripMenuItemDeleteScene.Size = new System.Drawing.Size(188, 24);
            this.ToolStripMenuItemDeleteScene.Text = "Delete Scene";
            this.ToolStripMenuItemDeleteScene.Click += new System.EventHandler(this.ToolStripMenuItemDeleteScene_Click);
            // 
            // ToolStripMenuItemRenameScene
            // 
            this.ToolStripMenuItemRenameScene.Name = "ToolStripMenuItemRenameScene";
            this.ToolStripMenuItemRenameScene.Size = new System.Drawing.Size(188, 24);
            this.ToolStripMenuItemRenameScene.Text = "Rename Scene";
            this.ToolStripMenuItemRenameScene.Click += new System.EventHandler(this.ToolStripMenuRenameScene_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.TextEditor);
            this.tabControl1.Controls.Add(this.Characters);
            this.tabControl1.Controls.Add(this.Diagrams);
            this.tabControl1.Controls.Add(this.Dictionary);
            this.tabControl1.Controls.Add(this.Notes);
            this.tabControl1.Location = new System.Drawing.Point(201, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(991, 384);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // TextEditor
            // 
            this.TextEditor.Controls.Add(this.TextEditorTextBox);
            this.TextEditor.Location = new System.Drawing.Point(4, 25);
            this.TextEditor.Name = "TextEditor";
            this.TextEditor.Padding = new System.Windows.Forms.Padding(3);
            this.TextEditor.Size = new System.Drawing.Size(983, 355);
            this.TextEditor.TabIndex = 0;
            this.TextEditor.Text = "Text Editor";
            this.TextEditor.UseVisualStyleBackColor = true;
            // 
            // TextEditorTextBox
            // 
            this.TextEditorTextBox.AcceptsTab = true;
            this.TextEditorTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextEditorTextBox.Location = new System.Drawing.Point(3, 3);
            this.TextEditorTextBox.Name = "TextEditorTextBox";
            this.TextEditorTextBox.Size = new System.Drawing.Size(977, 349);
            this.TextEditorTextBox.TabIndex = 0;
            this.TextEditorTextBox.Text = "";
            // 
            // Characters
            // 
            this.Characters.Controls.Add(this.GroupTextBox);
            this.Characters.Controls.Add(this.GroupLabel);
            this.Characters.Controls.Add(this.FatherTextBox);
            this.Characters.Controls.Add(this.MotherTextBox);
            this.Characters.Controls.Add(this.SexLabel);
            this.Characters.Controls.Add(this.SexComboBox);
            this.Characters.Controls.Add(this.FatherLabel);
            this.Characters.Controls.Add(this.MotherLabel);
            this.Characters.Controls.Add(this.CharactersListView);
            this.Characters.Controls.Add(this.CharacterSelect);
            this.Characters.Controls.Add(this.CharactersTextBox);
            this.Characters.Location = new System.Drawing.Point(4, 25);
            this.Characters.Name = "Characters";
            this.Characters.Padding = new System.Windows.Forms.Padding(3);
            this.Characters.Size = new System.Drawing.Size(983, 355);
            this.Characters.TabIndex = 1;
            this.Characters.Text = "Characters";
            // 
            // GroupTextBox
            // 
            this.GroupTextBox.Enabled = false;
            this.GroupTextBox.Location = new System.Drawing.Point(851, 112);
            this.GroupTextBox.Name = "GroupTextBox";
            this.GroupTextBox.Size = new System.Drawing.Size(123, 26);
            this.GroupTextBox.TabIndex = 13;
            this.GroupTextBox.Text = "";
            // 
            // GroupLabel
            // 
            this.GroupLabel.AutoSize = true;
            this.GroupLabel.Location = new System.Drawing.Point(789, 115);
            this.GroupLabel.Name = "GroupLabel";
            this.GroupLabel.Size = new System.Drawing.Size(52, 17);
            this.GroupLabel.TabIndex = 12;
            this.GroupLabel.Text = "Group:";
            // 
            // FatherTextBox
            // 
            this.FatherTextBox.Enabled = false;
            this.FatherTextBox.Location = new System.Drawing.Point(852, 49);
            this.FatherTextBox.Name = "FatherTextBox";
            this.FatherTextBox.Size = new System.Drawing.Size(123, 26);
            this.FatherTextBox.TabIndex = 11;
            this.FatherTextBox.Text = "";
            // 
            // MotherTextBox
            // 
            this.MotherTextBox.Enabled = false;
            this.MotherTextBox.Location = new System.Drawing.Point(852, 12);
            this.MotherTextBox.Name = "MotherTextBox";
            this.MotherTextBox.Size = new System.Drawing.Size(123, 26);
            this.MotherTextBox.TabIndex = 10;
            this.MotherTextBox.Text = "";
            // 
            // SexLabel
            // 
            this.SexLabel.AutoSize = true;
            this.SexLabel.Location = new System.Drawing.Point(789, 85);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(35, 17);
            this.SexLabel.TabIndex = 9;
            this.SexLabel.Text = "Sex:";
            // 
            // SexComboBox
            // 
            this.SexComboBox.Enabled = false;
            this.SexComboBox.FormattingEnabled = true;
            this.SexComboBox.Items.AddRange(new object[] {
            "male",
            "female"});
            this.SexComboBox.Location = new System.Drawing.Point(852, 82);
            this.SexComboBox.Name = "SexComboBox";
            this.SexComboBox.Size = new System.Drawing.Size(123, 24);
            this.SexComboBox.TabIndex = 8;
            // 
            // FatherLabel
            // 
            this.FatherLabel.AutoSize = true;
            this.FatherLabel.Location = new System.Drawing.Point(789, 52);
            this.FatherLabel.Name = "FatherLabel";
            this.FatherLabel.Size = new System.Drawing.Size(53, 17);
            this.FatherLabel.TabIndex = 7;
            this.FatherLabel.Text = "Father:";
            // 
            // MotherLabel
            // 
            this.MotherLabel.AutoSize = true;
            this.MotherLabel.Location = new System.Drawing.Point(789, 12);
            this.MotherLabel.Name = "MotherLabel";
            this.MotherLabel.Size = new System.Drawing.Size(56, 17);
            this.MotherLabel.TabIndex = 6;
            this.MotherLabel.Text = "Mother:";
            // 
            // CharactersListView
            // 
            this.CharactersListView.ContextMenuStrip = this.CharacterMenuStrip;
            this.CharactersListView.Enabled = false;
            this.CharactersListView.FullRowSelect = true;
            this.CharactersListView.HideSelection = false;
            this.CharactersListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.CharactersListView.LabelEdit = true;
            this.CharactersListView.Location = new System.Drawing.Point(200, 3);
            this.CharactersListView.MultiSelect = false;
            this.CharactersListView.Name = "CharactersListView";
            this.CharactersListView.Size = new System.Drawing.Size(583, 147);
            this.CharactersListView.TabIndex = 5;
            this.CharactersListView.UseCompatibleStateImageBehavior = false;
            this.CharactersListView.View = System.Windows.Forms.View.List;
            this.CharactersListView.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.CharactersListView_AfterLabelEdit);
            this.CharactersListView.SelectedIndexChanged += new System.EventHandler(this.CharactersListView_SelectedIndexChanged);
            // 
            // CharacterMenuStrip
            // 
            this.CharacterMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CharacterMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCharacterToolStripMenuItem1,
            this.deleteCharacterToolStripMenuItem1,
            this.renameCharacterToolStripMenuItem1,
            this.viewPedigreeToolStripMenuItem});
            this.CharacterMenuStrip.Name = "CharacterMenuStrip";
            this.CharacterMenuStrip.Size = new System.Drawing.Size(204, 108);
            // 
            // addCharacterToolStripMenuItem1
            // 
            this.addCharacterToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("addCharacterToolStripMenuItem1.Image")));
            this.addCharacterToolStripMenuItem1.Name = "addCharacterToolStripMenuItem1";
            this.addCharacterToolStripMenuItem1.Size = new System.Drawing.Size(203, 26);
            this.addCharacterToolStripMenuItem1.Text = "Add Character";
            this.addCharacterToolStripMenuItem1.Click += new System.EventHandler(this.addCharacterToolStripMenuItem1_Click);
            // 
            // deleteCharacterToolStripMenuItem1
            // 
            this.deleteCharacterToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("deleteCharacterToolStripMenuItem1.Image")));
            this.deleteCharacterToolStripMenuItem1.Name = "deleteCharacterToolStripMenuItem1";
            this.deleteCharacterToolStripMenuItem1.Size = new System.Drawing.Size(203, 26);
            this.deleteCharacterToolStripMenuItem1.Text = "Delete Character";
            this.deleteCharacterToolStripMenuItem1.Click += new System.EventHandler(this.deleteCharacterToolStripMenuItem1_Click);
            // 
            // renameCharacterToolStripMenuItem1
            // 
            this.renameCharacterToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("renameCharacterToolStripMenuItem1.Image")));
            this.renameCharacterToolStripMenuItem1.Name = "renameCharacterToolStripMenuItem1";
            this.renameCharacterToolStripMenuItem1.Size = new System.Drawing.Size(203, 26);
            this.renameCharacterToolStripMenuItem1.Text = "Rename Character";
            this.renameCharacterToolStripMenuItem1.Click += new System.EventHandler(this.renameCharacterToolStripMenuItem1_Click);
            // 
            // viewPedigreeToolStripMenuItem
            // 
            this.viewPedigreeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewPedigreeToolStripMenuItem.Image")));
            this.viewPedigreeToolStripMenuItem.Name = "viewPedigreeToolStripMenuItem";
            this.viewPedigreeToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.viewPedigreeToolStripMenuItem.Text = "View Pedigree";
            this.viewPedigreeToolStripMenuItem.Click += new System.EventHandler(this.viewPedigreeToolStripMenuItem_Click);
            // 
            // CharacterSelect
            // 
            this.CharacterSelect.ContextMenuStrip = this.CharacterListMenuStrip;
            this.CharacterSelect.LabelEdit = true;
            this.CharacterSelect.Location = new System.Drawing.Point(6, 3);
            this.CharacterSelect.Name = "CharacterSelect";
            this.CharacterSelect.Size = new System.Drawing.Size(188, 147);
            this.CharacterSelect.TabIndex = 4;
            this.CharacterSelect.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.CharacterSelect__AfterLabelEdit);
            this.CharacterSelect.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.CharacterSelect_AfterSelect);
            // 
            // CharacterListMenuStrip
            // 
            this.CharacterListMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CharacterListMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCharacterToolStripMenuItem,
            this.deleteCharacterToolStripMenuItem,
            this.renameCharacterToolStripMenuItem});
            this.CharacterListMenuStrip.Name = "CharacterMenuStrip";
            this.CharacterListMenuStrip.Size = new System.Drawing.Size(226, 76);
            // 
            // addCharacterToolStripMenuItem
            // 
            this.addCharacterToolStripMenuItem.Name = "addCharacterToolStripMenuItem";
            this.addCharacterToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.addCharacterToolStripMenuItem.Text = "Add Character List";
            this.addCharacterToolStripMenuItem.Click += new System.EventHandler(this.addCharacterToolStripMenuItem_Click);
            // 
            // deleteCharacterToolStripMenuItem
            // 
            this.deleteCharacterToolStripMenuItem.Name = "deleteCharacterToolStripMenuItem";
            this.deleteCharacterToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.deleteCharacterToolStripMenuItem.Text = "Delete Character List";
            this.deleteCharacterToolStripMenuItem.Click += new System.EventHandler(this.deleteCharacterToolStripMenuItem_Click);
            // 
            // renameCharacterToolStripMenuItem
            // 
            this.renameCharacterToolStripMenuItem.Name = "renameCharacterToolStripMenuItem";
            this.renameCharacterToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.renameCharacterToolStripMenuItem.Text = "Rename Character List";
            this.renameCharacterToolStripMenuItem.Click += new System.EventHandler(this.renameCharacterToolStripMenuItem_Click);
            // 
            // CharactersTextBox
            // 
            this.CharactersTextBox.AcceptsTab = true;
            this.CharactersTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CharactersTextBox.Enabled = false;
            this.CharactersTextBox.Location = new System.Drawing.Point(-16, 144);
            this.CharactersTextBox.Name = "CharactersTextBox";
            this.CharactersTextBox.Size = new System.Drawing.Size(980, 190);
            this.CharactersTextBox.TabIndex = 1;
            this.CharactersTextBox.Text = "";
            // 
            // Diagrams
            // 
            this.Diagrams.BackColor = System.Drawing.SystemColors.Control;
            this.Diagrams.Controls.Add(this.DiagramPictureBox);
            this.Diagrams.Controls.Add(this.DiagramListView);
            this.Diagrams.Controls.Add(this.DiagramsTextBox);
            this.Diagrams.Location = new System.Drawing.Point(4, 25);
            this.Diagrams.Name = "Diagrams";
            this.Diagrams.Size = new System.Drawing.Size(983, 355);
            this.Diagrams.TabIndex = 2;
            this.Diagrams.Text = "Diagrams";
            // 
            // DiagramPictureBox
            // 
            this.DiagramPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiagramPictureBox.ContextMenuStrip = this.DiagramPictureBoxMenu;
            this.DiagramPictureBox.Location = new System.Drawing.Point(85, 3);
            this.DiagramPictureBox.Name = "DiagramPictureBox";
            this.DiagramPictureBox.Size = new System.Drawing.Size(898, 218);
            this.DiagramPictureBox.TabIndex = 7;
            this.DiagramPictureBox.TabStop = false;
            // 
            // DiagramPictureBoxMenu
            // 
            this.DiagramPictureBoxMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.DiagramPictureBoxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importNewImageToolStripMenuItem});
            this.DiagramPictureBoxMenu.Name = "DiagramPictureBoxMenu";
            this.DiagramPictureBoxMenu.Size = new System.Drawing.Size(204, 28);
            // 
            // importNewImageToolStripMenuItem
            // 
            this.importNewImageToolStripMenuItem.Enabled = false;
            this.importNewImageToolStripMenuItem.Name = "importNewImageToolStripMenuItem";
            this.importNewImageToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.importNewImageToolStripMenuItem.Text = "Import New Image";
            // 
            // DiagramListView
            // 
            this.DiagramListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiagramListView.ContextMenuStrip = this.DiagramListViewMenu;
            this.DiagramListView.FullRowSelect = true;
            this.DiagramListView.HideSelection = false;
            this.DiagramListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10});
            this.DiagramListView.LabelEdit = true;
            this.DiagramListView.Location = new System.Drawing.Point(3, 3);
            this.DiagramListView.MultiSelect = false;
            this.DiagramListView.Name = "DiagramListView";
            this.DiagramListView.Size = new System.Drawing.Size(76, 218);
            this.DiagramListView.TabIndex = 6;
            this.DiagramListView.UseCompatibleStateImageBehavior = false;
            this.DiagramListView.View = System.Windows.Forms.View.List;
            this.DiagramListView.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.DiagramListView_AfterLabelEdit);
            this.DiagramListView.SelectedIndexChanged += new System.EventHandler(this.DiagramListView_SelectedIndexChanged);
            // 
            // DiagramListViewMenu
            // 
            this.DiagramListViewMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.DiagramListViewMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDiagramToolStripMenuItem,
            this.deleteDiagramToolStripMenuItem,
            this.renameDiagramToolStripMenuItem});
            this.DiagramListViewMenu.Name = "DiagramListViewMenu";
            this.DiagramListViewMenu.Size = new System.Drawing.Size(195, 76);
            // 
            // addDiagramToolStripMenuItem
            // 
            this.addDiagramToolStripMenuItem.Name = "addDiagramToolStripMenuItem";
            this.addDiagramToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.addDiagramToolStripMenuItem.Text = "Add Diagram";
            this.addDiagramToolStripMenuItem.Click += new System.EventHandler(this.addDiagramToolStripMenuItem_Click);
            // 
            // deleteDiagramToolStripMenuItem
            // 
            this.deleteDiagramToolStripMenuItem.Enabled = false;
            this.deleteDiagramToolStripMenuItem.Name = "deleteDiagramToolStripMenuItem";
            this.deleteDiagramToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.deleteDiagramToolStripMenuItem.Text = "Delete Diagram";
            this.deleteDiagramToolStripMenuItem.Click += new System.EventHandler(this.deleteDiagramToolStripMenuItem_Click);
            // 
            // renameDiagramToolStripMenuItem
            // 
            this.renameDiagramToolStripMenuItem.Enabled = false;
            this.renameDiagramToolStripMenuItem.Name = "renameDiagramToolStripMenuItem";
            this.renameDiagramToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.renameDiagramToolStripMenuItem.Text = "Rename Diagram";
            this.renameDiagramToolStripMenuItem.Click += new System.EventHandler(this.renameDiagramToolStripMenuItem_Click);
            // 
            // DiagramsTextBox
            // 
            this.DiagramsTextBox.AcceptsTab = true;
            this.DiagramsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiagramsTextBox.Location = new System.Drawing.Point(6, 227);
            this.DiagramsTextBox.Name = "DiagramsTextBox";
            this.DiagramsTextBox.Size = new System.Drawing.Size(980, 157);
            this.DiagramsTextBox.TabIndex = 3;
            this.DiagramsTextBox.Text = "";
            // 
            // Dictionary
            // 
            this.Dictionary.BackColor = System.Drawing.SystemColors.Control;
            this.Dictionary.Controls.Add(this.DictionaryListView);
            this.Dictionary.Controls.Add(this.DictionarySelect);
            this.Dictionary.Controls.Add(this.DictionaryTextBox);
            this.Dictionary.Location = new System.Drawing.Point(4, 25);
            this.Dictionary.Name = "Dictionary";
            this.Dictionary.Size = new System.Drawing.Size(983, 355);
            this.Dictionary.TabIndex = 3;
            this.Dictionary.Text = "Dictionary";
            // 
            // DictionaryListView
            // 
            this.DictionaryListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DictionaryListView.ContextMenuStrip = this.WordMenuStrip;
            this.DictionaryListView.Enabled = false;
            this.DictionaryListView.FullRowSelect = true;
            this.DictionaryListView.HideSelection = false;
            this.DictionaryListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15});
            this.DictionaryListView.LabelEdit = true;
            this.DictionaryListView.Location = new System.Drawing.Point(200, 3);
            this.DictionaryListView.MultiSelect = false;
            this.DictionaryListView.Name = "DictionaryListView";
            this.DictionaryListView.Size = new System.Drawing.Size(780, 147);
            this.DictionaryListView.TabIndex = 3;
            this.DictionaryListView.UseCompatibleStateImageBehavior = false;
            this.DictionaryListView.View = System.Windows.Forms.View.List;
            this.DictionaryListView.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.DictionaryListView_AfterLabelEdit);
            this.DictionaryListView.SelectedIndexChanged += new System.EventHandler(this.DictionaryListView_SelectedIndexChanged);
            // 
            // WordMenuStrip
            // 
            this.WordMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.WordMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addWordToolStripMenuItem,
            this.deleteWordToolStripMenuItem,
            this.rewriteWordToolStripMenuItem});
            this.WordMenuStrip.Name = "WordMenuStrip";
            this.WordMenuStrip.Size = new System.Drawing.Size(169, 76);
            // 
            // addWordToolStripMenuItem
            // 
            this.addWordToolStripMenuItem.Name = "addWordToolStripMenuItem";
            this.addWordToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.addWordToolStripMenuItem.Text = "Add Word";
            this.addWordToolStripMenuItem.Click += new System.EventHandler(this.addWordToolStripMenuItem_Click);
            // 
            // deleteWordToolStripMenuItem
            // 
            this.deleteWordToolStripMenuItem.Enabled = false;
            this.deleteWordToolStripMenuItem.Name = "deleteWordToolStripMenuItem";
            this.deleteWordToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.deleteWordToolStripMenuItem.Text = "Delete Word";
            this.deleteWordToolStripMenuItem.Click += new System.EventHandler(this.deleteWordToolStripMenuItem_Click);
            // 
            // rewriteWordToolStripMenuItem
            // 
            this.rewriteWordToolStripMenuItem.Enabled = false;
            this.rewriteWordToolStripMenuItem.Name = "rewriteWordToolStripMenuItem";
            this.rewriteWordToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.rewriteWordToolStripMenuItem.Text = "Rewrite Word";
            this.rewriteWordToolStripMenuItem.Click += new System.EventHandler(this.rewriteWordToolStripMenuItem_Click);
            // 
            // DictionarySelect
            // 
            this.DictionarySelect.ContextMenuStrip = this.DictionaryMenuStrip;
            this.DictionarySelect.LabelEdit = true;
            this.DictionarySelect.Location = new System.Drawing.Point(6, 3);
            this.DictionarySelect.Name = "DictionarySelect";
            this.DictionarySelect.Size = new System.Drawing.Size(188, 147);
            this.DictionarySelect.TabIndex = 2;
            this.DictionarySelect.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.DictionarySelect__AfterLabelEdit);
            this.DictionarySelect.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.DictionarySelect_AfterSelect);
            // 
            // DictionaryMenuStrip
            // 
            this.DictionaryMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.DictionaryMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDictionaryToolStripMenuItem,
            this.deleteDictionaryToolStripMenuItem,
            this.renameDictionaryToolStripMenuItem});
            this.DictionaryMenuStrip.Name = "DictionaryMenuStrip";
            this.DictionaryMenuStrip.Size = new System.Drawing.Size(205, 76);
            // 
            // addDictionaryToolStripMenuItem
            // 
            this.addDictionaryToolStripMenuItem.Name = "addDictionaryToolStripMenuItem";
            this.addDictionaryToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.addDictionaryToolStripMenuItem.Text = "Add Dictionary";
            this.addDictionaryToolStripMenuItem.Click += new System.EventHandler(this.addDictionaryToolStripMenuItem_Click);
            // 
            // deleteDictionaryToolStripMenuItem
            // 
            this.deleteDictionaryToolStripMenuItem.Name = "deleteDictionaryToolStripMenuItem";
            this.deleteDictionaryToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.deleteDictionaryToolStripMenuItem.Text = "Delete Dictionary";
            this.deleteDictionaryToolStripMenuItem.Click += new System.EventHandler(this.deleteDictionaryToolStripMenuItem_Click);
            // 
            // renameDictionaryToolStripMenuItem
            // 
            this.renameDictionaryToolStripMenuItem.Name = "renameDictionaryToolStripMenuItem";
            this.renameDictionaryToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.renameDictionaryToolStripMenuItem.Text = "Rename Dictionary";
            this.renameDictionaryToolStripMenuItem.Click += new System.EventHandler(this.renameDictionaryToolStripMenuItem_Click);
            // 
            // DictionaryTextBox
            // 
            this.DictionaryTextBox.AcceptsTab = true;
            this.DictionaryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DictionaryTextBox.Enabled = false;
            this.DictionaryTextBox.Location = new System.Drawing.Point(6, 156);
            this.DictionaryTextBox.Name = "DictionaryTextBox";
            this.DictionaryTextBox.Size = new System.Drawing.Size(980, 196);
            this.DictionaryTextBox.TabIndex = 1;
            this.DictionaryTextBox.Text = "";
            // 
            // Notes
            // 
            this.Notes.BackColor = System.Drawing.SystemColors.Control;
            this.Notes.Controls.Add(this.NotesListView);
            this.Notes.Controls.Add(this.NotesTextBox);
            this.Notes.Location = new System.Drawing.Point(4, 25);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(983, 355);
            this.Notes.TabIndex = 4;
            this.Notes.Text = "Notes";
            // 
            // NotesListView
            // 
            this.NotesListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NotesListView.ContextMenuStrip = this.NotesStripMenu;
            this.NotesListView.FullRowSelect = true;
            this.NotesListView.HideSelection = false;
            this.NotesListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem16,
            listViewItem17,
            listViewItem18,
            listViewItem19,
            listViewItem20});
            this.NotesListView.LabelEdit = true;
            this.NotesListView.Location = new System.Drawing.Point(3, 3);
            this.NotesListView.MultiSelect = false;
            this.NotesListView.Name = "NotesListView";
            this.NotesListView.Size = new System.Drawing.Size(98, 349);
            this.NotesListView.TabIndex = 4;
            this.NotesListView.UseCompatibleStateImageBehavior = false;
            this.NotesListView.View = System.Windows.Forms.View.List;
            this.NotesListView.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.NotesListView_AfterLabelEdit);
            this.NotesListView.SelectedIndexChanged += new System.EventHandler(this.NotesListView_SelectedIndexChanged);
            // 
            // NotesStripMenu
            // 
            this.NotesStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.NotesStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenuItem,
            this.deleteNoteToolStripMenuItem,
            this.renameNoteToolStripMenuItem});
            this.NotesStripMenu.Name = "NotesStripMenu";
            this.NotesStripMenu.Size = new System.Drawing.Size(170, 76);
            // 
            // addNoteToolStripMenuItem
            // 
            this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.addNoteToolStripMenuItem.Text = "Add Note";
            this.addNoteToolStripMenuItem.Click += new System.EventHandler(this.addNoteToolStripMenuItem_Click);
            // 
            // deleteNoteToolStripMenuItem
            // 
            this.deleteNoteToolStripMenuItem.Enabled = false;
            this.deleteNoteToolStripMenuItem.Name = "deleteNoteToolStripMenuItem";
            this.deleteNoteToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.deleteNoteToolStripMenuItem.Text = "Delete Note";
            this.deleteNoteToolStripMenuItem.Click += new System.EventHandler(this.deleteNoteToolStripMenuItem_Click);
            // 
            // renameNoteToolStripMenuItem
            // 
            this.renameNoteToolStripMenuItem.Enabled = false;
            this.renameNoteToolStripMenuItem.Name = "renameNoteToolStripMenuItem";
            this.renameNoteToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.renameNoteToolStripMenuItem.Text = "Rename Note";
            this.renameNoteToolStripMenuItem.Click += new System.EventHandler(this.renameNoteToolStripMenuItem_Click);
            // 
            // NotesTextBox
            // 
            this.NotesTextBox.AcceptsTab = true;
            this.NotesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotesTextBox.Enabled = false;
            this.NotesTextBox.Location = new System.Drawing.Point(107, 3);
            this.NotesTextBox.Name = "NotesTextBox";
            this.NotesTextBox.Size = new System.Drawing.Size(873, 349);
            this.NotesTextBox.TabIndex = 1;
            this.NotesTextBox.Text = "";
            // 
            // EditMenu
            // 
            this.EditMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.EditMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.EditMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.indentationToolStripMenuItem,
            this.boldToolStripMenuItem});
            this.EditMenu.Location = new System.Drawing.Point(201, 32);
            this.EditMenu.Name = "EditMenu";
            this.EditMenu.Size = new System.Drawing.Size(387, 28);
            this.EditMenu.TabIndex = 4;
            this.EditMenu.Text = "menuStrip2";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveChangesToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // saveChangesToolStripMenuItem
            // 
            this.saveChangesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveChangesToolStripMenuItem.Image")));
            this.saveChangesToolStripMenuItem.Name = "saveChangesToolStripMenuItem";
            this.saveChangesToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.saveChangesToolStripMenuItem.Text = "Save Changes";
            this.saveChangesToolStripMenuItem.Click += new System.EventHandler(this.saveChangesToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fontToolStripMenuItem.Image")));
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("colorToolStripMenuItem.Image")));
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // indentationToolStripMenuItem
            // 
            this.indentationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rightAlignToolStripMenuItem,
            this.leftAlignToolStripMenuItem,
            this.centerAlignToolStripMenuItem,
            this.identToolStripMenuItem,
            this.outdentToolStripMenuItem});
            this.indentationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indentationToolStripMenuItem.Image")));
            this.indentationToolStripMenuItem.Name = "indentationToolStripMenuItem";
            this.indentationToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.indentationToolStripMenuItem.Text = "Indentation";
            // 
            // rightAlignToolStripMenuItem
            // 
            this.rightAlignToolStripMenuItem.Name = "rightAlignToolStripMenuItem";
            this.rightAlignToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.rightAlignToolStripMenuItem.Text = "Right Align";
            this.rightAlignToolStripMenuItem.Click += new System.EventHandler(this.rightAlignToolStripMenuItem_Click);
            // 
            // leftAlignToolStripMenuItem
            // 
            this.leftAlignToolStripMenuItem.Name = "leftAlignToolStripMenuItem";
            this.leftAlignToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.leftAlignToolStripMenuItem.Text = "Left Align";
            this.leftAlignToolStripMenuItem.Click += new System.EventHandler(this.leftAlignToolStripMenuItem_Click);
            // 
            // centerAlignToolStripMenuItem
            // 
            this.centerAlignToolStripMenuItem.Name = "centerAlignToolStripMenuItem";
            this.centerAlignToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.centerAlignToolStripMenuItem.Text = "Center Align";
            this.centerAlignToolStripMenuItem.Click += new System.EventHandler(this.centerAlignToolStripMenuItem_Click);
            // 
            // identToolStripMenuItem
            // 
            this.identToolStripMenuItem.Name = "identToolStripMenuItem";
            this.identToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.identToolStripMenuItem.Text = "Ident";
            this.identToolStripMenuItem.Click += new System.EventHandler(this.identToolStripMenuItem_Click);
            // 
            // outdentToolStripMenuItem
            // 
            this.outdentToolStripMenuItem.Name = "outdentToolStripMenuItem";
            this.outdentToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.outdentToolStripMenuItem.Text = "Outdent";
            this.outdentToolStripMenuItem.Click += new System.EventHandler(this.outdentToolStripMenuItem_Click);
            // 
            // boldToolStripMenuItem
            // 
            this.boldToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalToolStripMenuItem,
            this.boldToolStripMenuItem1,
            this.italicsToolStripMenuItem,
            this.underlineToolStripMenuItem,
            this.strikeOutToolStripMenuItem});
            this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            this.boldToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.boldToolStripMenuItem.Text = "Format";
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // boldToolStripMenuItem1
            // 
            this.boldToolStripMenuItem1.Name = "boldToolStripMenuItem1";
            this.boldToolStripMenuItem1.Size = new System.Drawing.Size(152, 26);
            this.boldToolStripMenuItem1.Text = "Bold";
            this.boldToolStripMenuItem1.Click += new System.EventHandler(this.boldToolStripMenuItem1_Click);
            // 
            // italicsToolStripMenuItem
            // 
            this.italicsToolStripMenuItem.Name = "italicsToolStripMenuItem";
            this.italicsToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.italicsToolStripMenuItem.Text = "Italics";
            this.italicsToolStripMenuItem.Click += new System.EventHandler(this.italicsToolStripMenuItem_Click);
            // 
            // underlineToolStripMenuItem
            // 
            this.underlineToolStripMenuItem.Name = "underlineToolStripMenuItem";
            this.underlineToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.underlineToolStripMenuItem.Text = "Underline ";
            this.underlineToolStripMenuItem.Click += new System.EventHandler(this.underlineToolStripMenuItem_Click);
            // 
            // strikeOutToolStripMenuItem
            // 
            this.strikeOutToolStripMenuItem.Name = "strikeOutToolStripMenuItem";
            this.strikeOutToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.strikeOutToolStripMenuItem.Text = "Strike out";
            this.strikeOutToolStripMenuItem.Click += new System.EventHandler(this.strikeOutToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 453);
            this.Controls.Add(this.EditMenu);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ChapterSelect);
            this.Controls.Add(this.MainMenuStrip);
            this.Name = "Main";
            this.Text = "Chalkboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Closing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ChapterTreeContextMenu.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.TextEditor.ResumeLayout(false);
            this.Characters.ResumeLayout(false);
            this.Characters.PerformLayout();
            this.CharacterMenuStrip.ResumeLayout(false);
            this.CharacterListMenuStrip.ResumeLayout(false);
            this.Diagrams.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DiagramPictureBox)).EndInit();
            this.DiagramPictureBoxMenu.ResumeLayout(false);
            this.DiagramListViewMenu.ResumeLayout(false);
            this.Dictionary.ResumeLayout(false);
            this.WordMenuStrip.ResumeLayout(false);
            this.DictionaryMenuStrip.ResumeLayout(false);
            this.Notes.ResumeLayout(false);
            this.NotesStripMenu.ResumeLayout(false);
            this.EditMenu.ResumeLayout(false);
            this.EditMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionControlToolStripMenuItem;
        private System.Windows.Forms.TreeView ChapterSelect;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TextEditor;
        private System.Windows.Forms.TabPage Characters;
        private System.Windows.Forms.TabPage Dictionary;
        private System.Windows.Forms.TabPage Notes;
        private System.Windows.Forms.MenuStrip EditMenu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightAlignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftAlignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centerAlignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem italicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem underlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strikeOutToolStripMenuItem;
        private System.Windows.Forms.RichTextBox TextEditorTextBox;
        private System.Windows.Forms.RichTextBox DictionaryTextBox;
        private System.Windows.Forms.RichTextBox NotesTextBox;
        private System.Windows.Forms.ToolStripMenuItem saveChangesToolStripMenuItem;
        private System.Windows.Forms.TabPage Diagrams;
        private System.Windows.Forms.RichTextBox DiagramsTextBox;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem identToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outdentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.TreeView DictionarySelect;
        private System.Windows.Forms.ListView DictionaryListView;
        private System.Windows.Forms.ContextMenuStrip ChapterTreeContextMenu;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAddChap;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDeleteChap;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAddScene;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDeleteScene;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRenameChap;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRenameScene;
        private System.Windows.Forms.ContextMenuStrip DictionaryMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addDictionaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDictionaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameDictionaryToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip WordMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rewriteWordToolStripMenuItem;
        private System.Windows.Forms.ListView CharactersListView;
        private System.Windows.Forms.TreeView CharacterSelect;
        private System.Windows.Forms.ListView NotesListView;
        private System.Windows.Forms.ContextMenuStrip CharacterListMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameCharacterToolStripMenuItem;
        private System.Windows.Forms.RichTextBox CharactersTextBox;
        private System.Windows.Forms.Label SexLabel;
        private System.Windows.Forms.ComboBox SexComboBox;
        private System.Windows.Forms.Label FatherLabel;
        private System.Windows.Forms.Label MotherLabel;
        private System.Windows.Forms.RichTextBox FatherTextBox;
        private System.Windows.Forms.RichTextBox MotherTextBox;
        private System.Windows.Forms.RichTextBox GroupTextBox;
        private System.Windows.Forms.Label GroupLabel;
        private System.Windows.Forms.ContextMenuStrip CharacterMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addCharacterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteCharacterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem renameCharacterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewPedigreeToolStripMenuItem;
        private System.Windows.Forms.PictureBox DiagramPictureBox;
        private System.Windows.Forms.ListView DiagramListView;
        private System.Windows.Forms.ContextMenuStrip DiagramListViewMenu;
        private System.Windows.Forms.ToolStripMenuItem addDiagramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDiagramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameDiagramToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip DiagramPictureBoxMenu;
        private System.Windows.Forms.ToolStripMenuItem importNewImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBookToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip NotesStripMenu;
        private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remoteConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commitVersionToolStripMenuItem;
    }
}