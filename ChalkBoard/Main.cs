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
using System.Diagnostics;
using System.Threading;

namespace ChalkBoard
{
    public partial class Main : Form
    {

        private String MainDirectory = @"C:\Users\eahea\Desktop\ChalkBoard\Sample";

        private String ChapterDirectory;
        private String DictionaryDirectory;
        private String CharactersDirectory;
        private String DiagramFile;
        private String NotesFile;
        private List<string[]> DictionaryList;
        private List<string[]> CharacterList;
        private List<string[]> DiagramList;
        private List<string[]> NotesList;

        private bool chapterRename;
        private string oldChapter;

        private bool sceneRename;
        private string oldScene;

        private bool noteRename;
        private string oldNoteName;

        private bool wordRewrite;
        private string oldWord;

        private bool characterRewrite;
        private string oldCharacter;

        private bool renameCharacterList;
        private string oldCharacterList;

        private bool renameDictionaryList;
        private string oldDictionaryList;

        private bool diagramRewrite;
        private string oldDiagram;

        private string DiagramImageLocation;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

            ////MainDirectory = @"C:\Users\eahea\Desktop\ChalkBoard\Sample";

            ////ChapterDirectory = @"C:\Users\eahea\Desktop\ChalkBoard\Sample\Chapters";
            //ChapterDirectory = MainDirectory + "\\Chapters";

            ////DictionaryDirectory = @"C:\Users\eahea\Desktop\ChalkBoard\Sample\Dictionaries";
            //DictionaryDirectory = MainDirectory + "\\Dictionaries";

            ////CharactersDirectory = @"C:\Users\eahea\Desktop\ChalkBoard\Sample\Characters";
            //CharactersDirectory = MainDirectory + "\\Characters";

            ////DiagramFile = @"C:\Users\eahea\Desktop\ChalkBoard\Sample\diagrams.txt";
            //DiagramFile = MainDirectory + "\\diagrams.txt";

            ////NotesFile = @"C:\Users\eahea\Desktop\ChalkBoard\Sample\notes.txt";
            //NotesFile = MainDirectory + "\\notes.txt";

            //DictionaryList = new List<string[]>();
            //CharacterList = new List<string[]>();
            //DiagramList = new List<string[]>();
            //NotesList = new List<string[]>();

            //resetDictionary();
            //resetCharacters();
            //resetDiagram();
            //resetNotes();
            //ReloadTrees();
            LoadBook(@"C:\Users\eahea\Desktop\ChalkBoard\Sample");
            this.Width = 1210;
            this.Height = 500;

        }

        private void LoadBook(string newLocation)
        {
            MainDirectory = newLocation;
            ChapterDirectory = MainDirectory + "\\Chapters";
            DictionaryDirectory = MainDirectory + "\\Dictionaries";
            CharactersDirectory = MainDirectory + "\\Characters";
            DiagramFile = MainDirectory + "\\diagrams.txt";
            NotesFile = MainDirectory + "\\notes.txt";

            DictionaryList = new List<string[]>();
            CharacterList = new List<string[]>();
            DiagramList = new List<string[]>();
            NotesList = new List<string[]>();

            resetDictionary();
            resetCharacters();
            resetDiagram();
            resetNotes();
            ReloadTrees();
        }

        private void Main_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Save Changes before closing?", "Save Changes", MessageBoxButtons.YesNoCancel);
            if (confirm == DialogResult.Yes)
            {
                //save info
            }
            else if (confirm == DialogResult.Cancel)
            {
                e.Cancel = true; 
            }
        }

        private void Main_Resize(object sender, System.EventArgs e)
        {
            int width = this.Width;
            int height = this.Height;

            if (width < 550) { this.Width = 550; }
            if (height < 300 ) { this.Height = 300;  }

            DictionaryTextBox.Height = tabControl1.Height - 160; //magic number that looks good 
            CharactersTextBox.Height = tabControl1.Height - 160;
        }


        #region TreeViews

        //Chapter TreeView
        private void ChapterSelect_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name.EndsWith("rtf"))
            {
                TextEditorTextBox.Enabled = true;
                this.TextEditorTextBox.Clear();
                string path = ChapterDirectory + "\\" + e.Node.Parent.Text + "\\" + e.Node.Text + ".rtf";
                if (new FileInfo(path).Length != 0) {
                    this.TextEditorTextBox.LoadFile(path, RichTextBoxStreamType.RichText);
                }

            }
            else
            {
                TextEditorTextBox.Enabled = false;
                TextEditorTextBox.Clear();
            }
        }

        //Dictionary TreeView
        private void DictionarySelect_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name.EndsWith("txt"))
            {
                DictionaryListView.Enabled = true;
                string path = (DictionaryDirectory + "\\" + e.Node.Text + ".txt");
                if (new FileInfo(path).Length != 0)
                {
                    FileManager readDictionaries = new FileManager(path);
                    readDictionaries.parseFile();
                    DictionaryList = readDictionaries.getList();
                    resetDictionary();
                }
                else
                {
                    DictionaryList = new List<string[]>();
                    resetDictionary();
                }
            }
            else
            {
                DictionaryListView.Clear();
                DictionaryListView.Enabled = false;

            }
            DictionaryTextBox.Clear();
            DictionaryTextBox.Enabled = false;
        }

        //Characters TreeView
        private void CharacterSelect_AfterSelect(object sender, TreeViewEventArgs e)
        {

            if (e.Node.Name.EndsWith("txt"))
            {
                CharactersListView.Enabled = true;
                string path = (CharactersDirectory +"\\"+ e.Node.Text + ".txt");
                if (new FileInfo(path).Length != 0)
                {
                    FileManager readCharacters = new FileManager(path);
                    readCharacters.parseFile();
                    CharacterList = readCharacters.getList();
                    resetCharacters();
                }
                else
                {
                    CharacterList = new List<string[]>();
                    resetCharacters();
                }

            }
            else
            {
                CharactersListView.Clear();
                CharactersListView.Enabled = false;
            }

            CharactersTextBox.Clear();
            CharactersTextBox.Enabled = false;
            MotherTextBox.Clear();
            MotherTextBox.Enabled = false;
            FatherTextBox.Clear();
            FatherTextBox.Enabled = false;
            SexComboBox.ResetText();
            SexComboBox.Enabled = false;
            GroupTextBox.Clear();
            GroupTextBox.Enabled = false;
            viewPedigreeToolStripMenuItem.Enabled = false;
            deleteCharacterToolStripMenuItem1.Enabled = false;
            renameCharacterToolStripMenuItem1.Enabled = false;
        }

        private void ReloadTrees()
        {
            //Mapping Chapter Tree View
            ChapterSelect.Nodes.Clear();
            DirectoryInfo directoryInfo = new DirectoryInfo(ChapterDirectory);
            if (directoryInfo.Exists)
            {
                BuildTree(directoryInfo, ChapterSelect.Nodes);
            }

            //Maping Dictionary Tree View
            DictionarySelect.Nodes.Clear();
            DirectoryInfo directoryInfo2 = new DirectoryInfo(DictionaryDirectory);
            if (directoryInfo2.Exists)
            {
                BuildTree(directoryInfo2, DictionarySelect.Nodes);
            }

            //Maping Character Tree View
            CharacterSelect.Nodes.Clear();
            DirectoryInfo directoryInfo3 = new DirectoryInfo(CharactersDirectory);
            if (directoryInfo3.Exists)
            {
                BuildTree(directoryInfo3, CharacterSelect.Nodes);
            }
        }

        private void BuildTree(DirectoryInfo directoryInfo, TreeNodeCollection addInMe)
        {

            //Add Folder Nodes in Tree View
            foreach (DirectoryInfo subdir in directoryInfo.GetDirectories())
            {
                TreeNode parent = addInMe.Add(subdir.FullName, subdir.Name);
                foreach (FileInfo file in subdir.GetFiles())
                {
                    string ext = file.Extension;
                    if (ext == "rtf" || ext == "txt")
                    {
                        string fileName = file.Name.Replace(ext, "");
                        parent.Nodes.Add(file.FullName, fileName);
                    }

                }
            }
            //Add File Nodes in Tree View
            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                string fileName = file.Name.Replace(file.Extension, "");
                addInMe.Add(file.FullName, fileName);
            }

        }

        #endregion

        #region Book File Functions

        //Selecting a new book
        private void openBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedPath = "";
            var t = new Thread((ThreadStart)(() => {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.RootFolder = System.Environment.SpecialFolder.MyComputer;
                fbd.ShowNewFolderButton = true;
                if (fbd.ShowDialog() == DialogResult.Cancel)
                    return;

                selectedPath = fbd.SelectedPath;
            }));

            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();

            if (selectedPath != "")
            {
                //MainDirectory = selectedPath;
                LoadBook(selectedPath);
            }

        }

        private void newBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedPath = "";
            var t = new Thread((ThreadStart)(() => {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.RootFolder = System.Environment.SpecialFolder.MyComputer;
                fbd.ShowNewFolderButton = true;
                if (fbd.ShowDialog() == DialogResult.Cancel)
                    return;

                selectedPath = fbd.SelectedPath;
            }));

            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();

            if (selectedPath != "")
            {
                MainDirectory = selectedPath;
                //create ChapterDirectory
                Directory.CreateDirectory(selectedPath + "\\Chapters");
                //create DictionaryDirectory;
                Directory.CreateDirectory(selectedPath + "\\Dictionaries");
                //create CharactersDirectory;
                Directory.CreateDirectory(selectedPath + "\\Characters");
                //create DiagramFile;
                File.Create(selectedPath+"\\diagrams.txt").Dispose();
                //create String NotesFile;
                File.Create(selectedPath + "\\notes.txt").Dispose();
                LoadBook(selectedPath);
            }
        }

        #endregion

        #region Version Control
        //Commit Version
        private void commitVersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //set working directory
            Directory.SetCurrentDirectory(MainDirectory);

            string gitCommand = "git";
            string gitInitArguement = @"init";

            //check for .git folder in MainDirectory
            if (!Directory.Exists(MainDirectory + "\\" + ".git"))
            {
                //.git folder commands
                Process.Start(gitCommand, gitInitArguement);
            }

            System.Threading.Thread.Sleep(1000);

            //git .add command
            string gitAddArguement = @"add -A";
            Process.Start(gitCommand, gitAddArguement);

            System.Threading.Thread.Sleep(1000);

            //commit command
            string date = DateTime.Now.ToString();
            string gitCommitArguement = @"commit -m "+"\""+date+ "\"";
            Process.Start(gitCommand, gitCommitArguement);

            System.Threading.Thread.Sleep(1000);

            //prompt to push(backup)
            DialogResult confirm = MessageBox.Show("Would you like to push current commit?", "Push Current Commit", MessageBoxButtons.YesNoCancel);
            if (confirm == DialogResult.Yes)
            {
                //check if config file exists
                if (!File.Exists(MainDirectory + "\\" + "remoteConfig.txt"))
                {
                    MessageBox.Show("Remote Configurations File not set", "Warning", MessageBoxButtons.OK);
                }
                else
                {
                    FileManager remoteFile = new FileManager(MainDirectory + "\\" + "remoteConfig.txt");
                    remoteFile.parseFile();
                    List<string[]> remoteInfo = remoteFile.getList();

                    //check if config settings are empty
                    if(remoteInfo.Count == 0)
                    {
                        MessageBox.Show("Remote Configurations Information not set", "Warning", MessageBoxButtons.OK);
                    }
                    else
                    {
                        string RepoName = remoteInfo[0][0];
                        string ServerPath = remoteInfo[0][1];

                        string gitRemoteRemove = @"remote remove "+RepoName;
                        Process.Start(gitCommand, gitRemoteRemove);

                        System.Threading.Thread.Sleep(1000);

                        string gitRemoteAdd = @"remote add "+RepoName+" "+ServerPath;
                        Process.Start(gitCommand, gitRemoteAdd);

                        System.Threading.Thread.Sleep(1000);

                        string gitPush = @"push " + RepoName + " master";
                        Process.Start(gitCommand, gitPush);

                        System.Threading.Thread.Sleep(1000);

                    }

                }

            }

        }

        //Remote Configuration
        private void remoteConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //config file pathname
            string pathname = MainDirectory + "\\" + "remoteConfig.txt";
            //create config file if it doesn't exist
            if (!File.Exists(pathname))
            {
                File.Create(pathname).Dispose();
            }
            RemoteSetup setup = new RemoteSetup(pathname);
            setup.Show();
            this.Enabled = false;
            while (setup.IsOpen())
            {
                Application.DoEvents();
            }
            this.Enabled = true;
            this.Focus();

        }

        #endregion

        //Changing Select Tabs
        private void TabControl1_SelectedIndexChanged(Object sender, EventArgs e) 
        {
            if (tabControl1.SelectedIndex != -1) {
                if (tabControl1.SelectedTab.Name == "TextEditor")
                {
                    boldToolStripMenuItem.Enabled = true;
                    indentationToolStripMenuItem.Enabled = true;
                    colorToolStripMenuItem.Enabled = true;
                    fontToolStripMenuItem.Enabled = true;
                }
                else
                {
                    boldToolStripMenuItem.Enabled = false;
                    indentationToolStripMenuItem.Enabled = false;
                    colorToolStripMenuItem.Enabled = false;
                    fontToolStripMenuItem.Enabled = false;
                }
                //Load Diagrams if Diagram Tab is opened
                if (tabControl1.SelectedTab.Name == "Diagrams")
                {
                    //generate diagram list view
                    FileManager DiagramReader = new FileManager(DiagramFile);
                    DiagramReader.parseFile();
                    DiagramList = DiagramReader.getList();
                    DiagramListView.Items.Clear();
                    foreach (string[] item in DiagramList)
                    {
                        //add item to DiagramListView, DiagramTextBox, DiagramPictureBox
                        DiagramListView.Items.Add(item[0]);

                    }
                }
                //Load Notes if Note Tab is opened
                if(tabControl1.SelectedTab.Name == "Notes")
                {
                    FileManager NotesReader = new FileManager(NotesFile);
                    NotesReader.parseFile();
                    NotesList = NotesReader.getList();
                    NotesListView.Items.Clear();
                    foreach (string[] item in NotesList)
                    {
                        //add item to NotesListView, etc.
                        NotesListView.Items.Add(item[0]);
                    }


                }

            }

        }

        //Determine selected RichTextBox (which tab)
        private RichTextBox getRichTextBox()
        {
            RichTextBox textBox = null;
            if (tabControl1.SelectedIndex != -1)
            {
                string name = tabControl1.SelectedTab.Name;

                Control[] crnt = Controls.Find(name + "TextBox", true);

                if (crnt.Length > 0)
                {
                    textBox = (RichTextBox)crnt[0];
                }
            }
            return textBox;
        }

        //Check tree for duplicate names 
        private bool checkTreeForDuplicate(TreeView tree, string newString)
        {
            if(newString == "")
            {
                return true;
            }

            int foundCnt = 0; 
            foreach (TreeNode node in tree.Nodes)
            {
                if (node.Text == newString && node != tree.SelectedNode) //check parent nodes 
                {
                    foundCnt++;
                }
                //check child nodes 
                foreach (TreeNode ChildNode in node.Nodes)
                {
                    if (ChildNode.Text == newString && ChildNode != tree.SelectedNode) //check parent nodes 
                    {
                        foundCnt++;
                    }
                }
            }


            if (foundCnt == 0)
            {
                return false; // change allowed 
            }
            else
            {
                return true;
            }
        }

        #region Edit Functions      
        //right align
        private void rightAlignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox richBox = getRichTextBox();
            if (richBox != null)
            {
                richBox.SelectionAlignment = HorizontalAlignment.Right;
            }
        }

        //left align
        private void leftAlignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox richBox = getRichTextBox();
            if (richBox != null)
            {
                richBox.SelectionAlignment = HorizontalAlignment.Left;
            }

        }

        //center align
        private void centerAlignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox richBox = getRichTextBox();
            if (richBox != null)
            {
                richBox.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

        //indent
        private void identToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox richBox = getRichTextBox();
            if (richBox != null)
            {
                richBox.SelectionIndent = 40;
            }
        }

        //outdent
        private void outdentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox richBox = getRichTextBox();
            if (richBox != null)
            {
                richBox.SelectionIndent = 0;
            }

        }

        //font
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {

            RichTextBox richBox = getRichTextBox();
            if (richBox != null)
            {
                FontDialog fd = new FontDialog();
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    richBox.Font = fd.Font;
                }
            }

        }

        //color
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            RichTextBox richBox = getRichTextBox();
            if (richBox != null)
            {
                ColorDialog col = new ColorDialog();
                col.ShowDialog();
                richBox.SelectionColor = col.Color;
            }

        }

        //Format - normal
        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {

            RichTextBox richBox = getRichTextBox();
            if (richBox != null)
            {
                richBox.SelectionFont = new Font(richBox.Font, FontStyle.Regular);
            }

        }

        //Format - bold
        private void boldToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            RichTextBox richBox = getRichTextBox();
            if (richBox != null)
            {
                richBox.SelectionFont = new Font(richBox.Font, FontStyle.Bold);
            }

        }

        //Format - italic
        private void italicsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            RichTextBox richBox = getRichTextBox();
            if (richBox != null)
            {
                richBox.SelectionFont = new Font(richBox.Font, FontStyle.Italic);
            }

        }

        //Format - underline
        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {

            RichTextBox richBox = getRichTextBox();
            if (richBox != null)
            {
                richBox.SelectionFont = new Font(richBox.Font, FontStyle.Underline);
            }

        }

        //Format - strikeout
        private void strikeOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            RichTextBox richBox = getRichTextBox();
            if (richBox != null)
            {
                richBox.SelectionFont = new Font(richBox.Font, FontStyle.Strikeout);
            }

        }

        //Edit - cut
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox richBox = getRichTextBox();
            if (richBox != null)
            {
                richBox.Cut();
            }

        }

        //Edit - copy
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox richBox = getRichTextBox();
            if (richBox != null)
            {
                richBox.Copy();
            }

        }

        //Edit - paste
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox richBox = getRichTextBox();
            if (richBox != null)
            {
                richBox.Paste();
            }

        }

        //Edit - save changes
        private void saveChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Saving text editor tab
            if(tabControl1.SelectedTab.Text == "Text Editor")
            {
                saveScene();
            }
            //Saving characters tab
            if(tabControl1.SelectedTab.Text == "Characters")
            {
                saveCharacter();
            }
            //Saving diagrams tab
            if (tabControl1.SelectedTab.Text == "Diagrams")
            {
                saveDiagram();
            }
            //Saving dictionary tab
            if (tabControl1.SelectedTab.Text == "Dictionary")
            {
                saveWord();
            }
            //Saving notes tab
            if(tabControl1.SelectedTab.Text == "Notes")
            {
                saveNotes();
            }
        }

        //Edit - clear
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox richBox = getRichTextBox();
            if (richBox != null)
            {
                richBox.Clear();
            }

        }

        #endregion 

        #region Chapters/Scenes Functions

        //ADDING-DELETING CHAPTERS AND SCENES
        //-------------------------------------------------------------------------------------------------------------------

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            //note: a node is always selected
            TreeNode selected = ChapterSelect.SelectedNode;
            if (selected == null)
            {
                //Enable Chapter
                ToolStripMenuItemAddChap.Enabled = true;
                ToolStripMenuItemDeleteChap.Enabled = true;
                ToolStripMenuItemRenameChap.Enabled = true;

                //Disable Scene
                ToolStripMenuItemAddScene.Enabled = false;
                ToolStripMenuItemDeleteScene.Enabled = false;
                ToolStripMenuItemRenameScene.Enabled = false;
            }
            else
            {
                //check if it is a chapter
                if (selected.Parent == null)
                {
                    //Enable Chapter
                    ToolStripMenuItemAddChap.Enabled = true;
                    ToolStripMenuItemDeleteChap.Enabled = true;
                    ToolStripMenuItemRenameChap.Enabled = true;

                    //Disable Scene
                    ToolStripMenuItemAddScene.Enabled = true; // can add scenes to a chapter
                    ToolStripMenuItemDeleteScene.Enabled = false;
                    ToolStripMenuItemRenameScene.Enabled = false;

                }
                //else it is a scene
                else
                {
                    //Disable Chapter
                    ToolStripMenuItemAddChap.Enabled = false;
                    ToolStripMenuItemDeleteChap.Enabled = false;
                    ToolStripMenuItemRenameChap.Enabled = false;
                    //Enable Scene
                    ToolStripMenuItemAddScene.Enabled = false; //cannot add a scene to a scene
                    ToolStripMenuItemDeleteScene.Enabled = true;
                    ToolStripMenuItemRenameScene.Enabled = true;
                }
            }
        }

        //Add Chapters
        private void ToolStripMenuItemAddChap_Click(object sender, EventArgs e)
        {
           TreeNode newChap = ChapterSelect.Nodes.Add("New Chapter");
           ChapterSelect.SelectedNode = newChap;
           newChap.BeginEdit();
        }

        //Delete Chapters
        private void ToolStripMenuItemDeleteChap_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete Chapter '" + ChapterSelect.SelectedNode.Text + "' and all of its Scenes?", "Delete", MessageBoxButtons.YesNoCancel);
            if (confirm == DialogResult.Yes)
            {

                TreeNode parent = ChapterSelect.SelectedNode;
                foreach (TreeNode child in parent.Nodes)
                {
                    //MessageBox.Show(ChapterDirectory + "\\" + ChapterSelect.SelectedNode.Text + "\\" + child.Text + ".rtf");
                    File.Delete(ChapterDirectory + "\\" + ChapterSelect.SelectedNode.Text + "\\" + child.Text+".rtf");
                    parent.Nodes.Remove(child);
                }
                Directory.Delete(ChapterDirectory+"\\"+ChapterSelect.SelectedNode.Text);
                ChapterSelect.SelectedNode.Remove();


            }
        }

        //Rename Chapters
        private void ToolStripMenuItemRenameChap_Click(object sender, EventArgs e)
        {
            chapterRename = true;
            oldChapter = ChapterSelect.SelectedNode.Text;
            ChapterSelect.SelectedNode.BeginEdit();
        }

        //Add Scenes
        private void ToolStripMenuItemAddScene_Click(object sender, EventArgs e)
        {
            TreeNode newScene = ChapterSelect.SelectedNode.Nodes.Add("New Scene");
            ChapterSelect.SelectedNode = newScene;
            newScene.BeginEdit();
        }

        //Delete Scenes
        private void ToolStripMenuItemDeleteScene_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete Scene '" + ChapterSelect.SelectedNode.Text + "'?", "Delete", MessageBoxButtons.YesNoCancel);
            if (confirm == DialogResult.Yes)
            {
                TreeNode removedNode = ChapterSelect.SelectedNode;
                File.Delete(ChapterDirectory + "\\" + removedNode.Parent.Text + "\\" + removedNode.Text + ".rtf");
                ChapterSelect.SelectedNode.Remove();
            }

        }

        //Rename Scenes
        private void ToolStripMenuRenameScene_Click(object sender, EventArgs e)
        {
            sceneRename = true;
            oldScene = ChapterSelect.SelectedNode.Text;
            ChapterSelect.SelectedNode.BeginEdit();
        }

        //Double Check Renameing (prevent duplicate names)
        private void ChapterSelect__AfterLabelEdit(object sender, System.Windows.Forms.NodeLabelEditEventArgs e)
        {
            string compare = e.Label;

            if (compare == null)
            {
                compare = e.Node.Text; //use current name if null, used for new chapter
            }
            compare = compare.Trim();
            if (checkTreeForDuplicate(ChapterSelect, compare))
            {
                e.Node.EndEdit(false);
                MessageBox.Show("Name already exists", "Warning", MessageBoxButtons.OK);
                e.Node.BeginEdit();
            }
            else
            {
                if (chapterRename && e.Node.Parent == null)
                {
                    //rename chapter
                    string oldChap = ChapterDirectory + "\\" + oldChapter;
                    string newChap = ChapterDirectory + "\\" + compare;
                    if (oldChap != newChap)
                    {
                        if (Directory.Exists(oldChap))
                        {
                            Directory.Move(oldChap, newChap);
                        }
                        ReloadChapter(e.Node, compare);
                    }
                    chapterRename = false;
                }
                else if (!chapterRename && e.Node.Parent == null)
                {
                    //create chapter
                    DirectoryInfo di = Directory.CreateDirectory(ChapterDirectory+"\\"+compare);
                }
                else if (sceneRename && e.Node.Parent != null)
                {
                    //rename scene
                    string oldS = ChapterDirectory + "\\" +e.Node.Parent.Text+"\\"+ oldScene+".rtf";
                    string newS = ChapterDirectory + "\\" +e.Node.Parent.Text+"\\"+ compare+".rtf";
                    if (oldS != newS)
                    {
                        if (File.Exists(oldS))
                        {
                            File.Move(oldS, newS);
                        }
                    }
                    e.Node.Name = compare + ".rtf";
                    sceneRename = false;
                }
                else if (!sceneRename && e.Node.Parent != null)
                {
                    //create scene
                    File.Create(ChapterDirectory + "\\" +e.Node.Parent.Text+"\\"+ compare + ".rtf").Dispose();
                    e.Node.Name = compare + ".rtf";
                }
            }
        }

        public void ReloadChapter(TreeNode tn, string compare)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(ChapterDirectory+"\\" + compare);
            int cnt = 0;
            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                string fileName = file.Name.Replace(file.Extension, "");
                tn.Nodes[cnt].Name = file.FullName;
                tn.Nodes[cnt].Text = fileName;
                cnt++;
            }

        }


    #endregion

        #region Dictionary Tab

    //DICTIONARY TAB FUNCTIONS
    //-------------------------------------------------------------------------------------------------------------------

    //clearing list view everytime the dictionary changes
    public void resetDictionary()
        {
            DictionaryListView.Clear();
            foreach (string[] item in DictionaryList)
            {
                DictionaryListView.Items.Add(item[0].ToString());

            }
        }

        private string[] searchDictionary(string key)
        {
            string[] defaultWord = { "New Word", "New Definition" };
            foreach (string[] item in DictionaryList)
            {
                if (key==item[0])
                {
                    return item;
                }
            }
            return defaultWord;
        }
        
        //Select Word from Dictionary 
        private void DictionaryListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //check if not null 
            if(DictionaryListView.SelectedItems.Count != 0)
            {
                DictionaryTextBox.Enabled = true;
                string[] word = searchDictionary(DictionaryListView.SelectedItems[0].Text.ToString());
                this.DictionaryTextBox.Clear();
                this.DictionaryTextBox.Text = word[1];
                deleteWordToolStripMenuItem.Enabled = true;
                rewriteWordToolStripMenuItem.Enabled = true;
            }
            else
            {
                DictionaryTextBox.Enabled = false;
                deleteWordToolStripMenuItem.Enabled = false;
                rewriteWordToolStripMenuItem.Enabled = false;
                DictionaryTextBox.Clear();
            }

        }

        //add a dictionary (TreeView)
        private void addDictionaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode newDict = DictionarySelect.Nodes.Add("New Dictionary");
            DictionarySelect.SelectedNode = newDict;
            newDict.BeginEdit();
        }

        //rename a dictionary (TreeView)
        private void renameDictionaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renameDictionaryList = true;
            oldDictionaryList = DictionarySelect.SelectedNode.Text;
            DictionarySelect.SelectedNode.BeginEdit();
        }

        //Delete dictionary (TreeView)
        private void deleteDictionaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete Dictionary '" + DictionarySelect.SelectedNode.Text + "'?", "Delete", MessageBoxButtons.YesNoCancel);
            if (confirm == DialogResult.Yes)
            {
                TreeNode removedNode = DictionarySelect.SelectedNode;
                File.Delete(DictionaryDirectory + "\\" + removedNode.Text + ".txt");
                DictionarySelect.SelectedNode.Remove();
                DictionaryTextBox.Clear();
                DictionaryListView.Enabled = false;
            }
        }

        //Double Check Renameing (prevent duplicate names) DICTIONARY TREE VIEW
        private void DictionarySelect__AfterLabelEdit(object sender, System.Windows.Forms.NodeLabelEditEventArgs e)
        {
            string compare = e.Label; //what the label could become

            if (compare == null)
            {
                compare = e.Node.Text; //use current name if null, used for new character
            }
            compare = compare.Trim();
            if (checkTreeForDuplicate(DictionarySelect, compare))
            {
                e.Node.EndEdit(false);
                MessageBox.Show("Dictionary '" + compare + "' already exists", "Warning", MessageBoxButtons.OK);
                e.Node.BeginEdit();
            }
            else
            {
                if (renameDictionaryList)
                {
                    //rename character list
                    string oldDictList = DictionaryDirectory + "\\" + oldDictionaryList + ".txt";
                    string newDictList = DictionaryDirectory + "\\" + compare + ".txt";
                    if (oldDictList != newDictList)
                    {
                        if (File.Exists(oldDictList))
                        {
                            File.Move(oldDictList, newDictList);

                        }
                    }
                    e.Node.Name = compare + ".txt";
                    renameDictionaryList = false;

                    DictionaryListView.Enabled = true;
                }
                else
                {
                    //create character list
                    File.Create(DictionaryDirectory + "\\" + compare + ".txt").Dispose();
                    e.Node.Name = compare + ".txt";

                    DictionaryListView.Enabled = true;
                }
            }
        }

        //Double Check Renameing DICTIONARY LIST VIEW
        private void DictionaryListView_AfterLabelEdit(object sender, System.Windows.Forms.LabelEditEventArgs e)
        {
            string compare = e.Label; //what label is going to become
            bool update = true; //flag for no update

            if (compare == null)
            {
                compare = DictionaryListView.Items[e.Item].Text;//use current name if null, used for new character
            }
            compare = compare.Trim();
            foreach (ListViewItem item in DictionaryListView.Items)
            {
                if (item.Text == compare && item.Index != e.Item)
                {
                    MessageBox.Show("Word '" + compare + "' already exists", "Warning", MessageBoxButtons.OK);
                    DictionaryListView.Items[e.Item].BeginEdit();
                    update = false;
                    break;
                }
            }
            if (update)
            {
                if (wordRewrite)
                {
                    //remove old word
                    string[] tempWord = searchDictionary(oldWord);
                    DictionaryList.Remove(tempWord);
                    //add new word
                    tempWord[0] = compare;
                    DictionaryList.Add(tempWord);
                }
                else
                {
                    //create new word
                    string[] newWord = {compare,"new definition"};
                    DictionaryList.Add(newWord);
                    resetDictionary();

                }
            }

        }

        //Add a new word to a selected dictionary (List View)
        private void addWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem newWord = DictionaryListView.Items.Add("New Word");
            DictionaryListView.SelectedItems.Clear();
            DictionaryListView.SelectedItems.Equals(newWord);
            newWord.BeginEdit();
        }

        //delete a word from a selected dictionary (List View)
        private void deleteWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String selectedWord = DictionaryListView.SelectedItems[0].Text;
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete Word '" + selectedWord + "'?", "Delete", MessageBoxButtons.YesNoCancel);
            if (confirm == DialogResult.Yes)
            {
                string[] removedWord = searchDictionary(DictionaryListView.SelectedItems[0].Text);
                DictionaryList.Remove(removedWord);
                DictionaryListView.SelectedItems[0].Remove();
            }
        }

        //rewrite a word (ListView)
        private void rewriteWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DictionaryListView.SelectedItems.Count == 1)
            {
                wordRewrite = true;
                oldWord = DictionaryListView.SelectedItems[0].Text;
                DictionaryListView.SelectedItems[0].BeginEdit();
                wordRewrite = false;
            }
        }

        #endregion

        #region Characters Tab
        private void CharactersListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //check if not null 
            if (CharactersListView.SelectedItems.Count != 0)
            {
                CharactersTextBox.Enabled = true;
                MotherTextBox.Enabled = true;
                FatherTextBox.Enabled = true;
                SexComboBox.Enabled = true;
                GroupTextBox.Enabled = true;
                viewPedigreeToolStripMenuItem.Enabled = true;
                deleteCharacterToolStripMenuItem1.Enabled = true;
                renameCharacterToolStripMenuItem1.Enabled = true;

                string[] foundCharacter = searchCharacters(CharactersListView.SelectedItems[0].Text.ToString());
                this.CharactersTextBox.Clear();
                this.CharactersTextBox.Text = foundCharacter[2];
                MotherTextBox.Clear();
                MotherTextBox.Text = foundCharacter[3];
                FatherTextBox.Clear();
                FatherTextBox.Text = foundCharacter[4];
                SexComboBox.ResetText();
                SexComboBox.Text = foundCharacter[1];
                GroupTextBox.Clear();
                GroupTextBox.Text = foundCharacter[5];


            }
            else
            {
                CharactersTextBox.Enabled = false;
                MotherTextBox.Enabled = false;
                FatherTextBox.Enabled = false;
                SexComboBox.Enabled = false;
                GroupTextBox.Enabled = false;
                viewPedigreeToolStripMenuItem.Enabled = false;
                deleteCharacterToolStripMenuItem1.Enabled = false;
                renameCharacterToolStripMenuItem1.Enabled = false;
                CharactersTextBox.Clear();
                MotherTextBox.Clear();
                FatherTextBox.Clear();
                SexComboBox.ResetText();
                GroupTextBox.Clear();
            }

        }

        private void CharacterMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (CharactersListView.SelectedItems.Count > 0)
            {
                renameCharacterToolStripMenuItem1.Enabled = true;
            }
            else
            {
                renameCharacterToolStripMenuItem1.Enabled = false;
            }
                
        }

        public void resetCharacters()
        {
            CharactersListView.Clear();
            foreach (string[] item in CharacterList)
            {
                CharactersListView.Items.Add(item[0].ToString());

            }
        }


        private string[] searchCharacters(string key)
        {
            string[] defaultCharacter = new string[] { "Name","Male","Description","Mother","Father","Group"};
            foreach (string[] item in CharacterList)
            {
                if (key == item[0])
                {
                    return item;
                }
            }
            return defaultCharacter;
        }

        //add a new character list to the tree view
        private void addCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode newCharList = CharacterSelect.Nodes.Add("New Character List");
            CharacterSelect.SelectedNode = newCharList;
            newCharList.BeginEdit();
         }

        //Deleting a character list
        private void deleteCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete Character List '" + CharacterSelect.SelectedNode.Text + "'?", "Delete", MessageBoxButtons.YesNoCancel);
            if (confirm == DialogResult.Yes)
            {
                TreeNode removedNode = CharacterSelect.SelectedNode;
                File.Delete(CharactersDirectory +"\\" + removedNode.Text + ".txt");
                CharacterSelect.SelectedNode.Remove();

                CharactersTextBox.Clear();
                MotherTextBox.Clear();
                FatherTextBox.Clear();
                SexComboBox.ResetText();
                GroupTextBox.Clear();

                CharactersListView.Enabled = false;

            }
        }

        private void renameCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renameCharacterList = true;
            oldCharacterList = CharacterSelect.SelectedNode.Text;
            CharacterSelect.SelectedNode.BeginEdit();
        }

        //Double Check Renameing (prevent duplicate names)  TREE VIEW
        private void CharacterSelect__AfterLabelEdit(object sender, System.Windows.Forms.NodeLabelEditEventArgs e)
        {

            string compare = e.Label; //what label is going to become
           
            if (compare == null)
            {
                compare = e.Node.Text; //use current name if null, used for new character list
            }
            compare = compare.Trim();
            if (checkTreeForDuplicate(CharacterSelect, compare))
            {
                e.Node.EndEdit(false);
                MessageBox.Show("Character List'" + compare + "'already exists", "Warning", MessageBoxButtons.OK);
                e.Node.BeginEdit();
            }
            else
            {
                if (renameCharacterList)
                {
                    //rename character list
                    string oldCharList = CharactersDirectory + "\\" + oldCharacterList + ".txt";
                    string newCharList = CharactersDirectory + "\\" + compare + ".txt";
                    if (oldCharList != newCharList)
                    {
                        if (File.Exists(oldCharList))
                        {
                            File.Move(oldCharList, newCharList);
                            
                        }
                    }
                    e.Node.Name = compare + ".txt";
                    renameCharacterList = false;

                    CharactersListView.Enabled = true;
                }
                else
                {
                    //create character list
                    File.Create(CharactersDirectory + "\\" + compare + ".txt").Dispose();
                    e.Node.Name = compare + ".txt";

                    CharactersListView.Enabled = true;
                }
               
            }
        }

        //add a single character to a list (ListView)
        private void addCharacterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListViewItem newChar = CharactersListView.Items.Add("New Character");
            CharactersListView.SelectedItems.Clear();
            CharactersListView.SelectedItems.Equals(newChar);
            newChar.BeginEdit();
        }

        //delete a single character in a list (ListView)
        private void deleteCharacterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            String listName = CharactersListView.SelectedItems[0].Text;
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete Character '" + listName +"'", "Delete", MessageBoxButtons.YesNoCancel);
            if (confirm == DialogResult.Yes)
            {
                string[] removedCharacter = searchCharacters(CharactersListView.SelectedItems[0].Text);
                CharacterList.Remove(removedCharacter);
                CharactersListView.SelectedItems[0].Remove();
            }

        }

        //rename a single character in a list (ListView)
        private void renameCharacterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (CharactersListView.SelectedItems.Count == 1)
            {
                characterRewrite = true;
                oldCharacter = CharactersListView.SelectedItems[0].Text;
                CharactersListView.SelectedItems[0].BeginEdit();
                characterRewrite = false;
            }
        }

        //check renameing for character (ListView)
        private void CharactersListView_AfterLabelEdit(object sender, System.Windows.Forms.LabelEditEventArgs e)
        {
            string compare = e.Label; //what label is going to become
            bool update = true;
            
            if (compare == null)
            {
                compare = CharactersListView.Items[e.Item].Text;//use current name if null, used for new character
            }
            compare = compare.Trim();
            foreach (ListViewItem item in CharactersListView.Items)
            {
                if (item.Text == compare && item.Index != e.Item)
                {
                    MessageBox.Show("Character '" + compare + "' already exists", "Warning", MessageBoxButtons.OK);
                    CharactersListView.Items[e.Item].BeginEdit();
                    update = false;//flag for no update 
                    break;
                }
            }
            if (update)
            {
                if (characterRewrite)
                {
                    //remove old character
                    string[] tempCharacter = searchCharacters(oldCharacter);
                    CharacterList.Remove(tempCharacter);
                    //add new character
                    tempCharacter[0] = compare;
                    CharacterList.Add(tempCharacter);
                }
                else
                {
                    //create new word
                    string[] newCharacter = { compare, "male","blank description","unknown","unknown", "no affiliation" };
                    CharacterList.Add(newCharacter);
                    resetCharacters();
                }
            }

        }

        //Open Pedigree Window
        private void viewPedigreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CharactersListView.SelectedItems.Count != 0)
            {
                string[] foundCharacter = searchCharacters(CharactersListView.SelectedItems[0].Text.ToString());
                Pedigree myPedigree = new Pedigree(CharacterList, foundCharacter);
                myPedigree.Show();
                this.Enabled = false;
                while (myPedigree.IsOpen())
                {
                    Application.DoEvents();
                }
                this.Enabled = true;
                this.Focus();
            }
            else
            {
                MessageBox.Show("Could not load pedigree", "Warning", MessageBoxButtons.OK);
            }
        }


        #endregion

        #region Notes tab
        private void NotesListView_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (NotesListView.SelectedItems.Count == 1 )
            {
                NotesTextBox.Enabled = true;

                string[] note = searchNotes(NotesListView.SelectedItems[0].Text.ToString());
                this.NotesTextBox.Clear();
                this.NotesTextBox.Text = note[1];

                addNoteToolStripMenuItem.Enabled = true;
                deleteNoteToolStripMenuItem.Enabled = true;
                renameNoteToolStripMenuItem.Enabled = true;
            }
            else
            {
                NotesTextBox.Clear();
                NotesTextBox.Enabled = false;
                deleteNoteToolStripMenuItem.Enabled = false;
                renameNoteToolStripMenuItem.Enabled = false;
            }
        }

        public string[] searchNotes(string key)
        {
            string[] defaultNote = { "Default Note", "blank note" };
            foreach (string[] item in NotesList)
            {
                if (item[0] == key)
                {
                    return item;
                }
            }
            return defaultNote;
        }

        //check renameing for notes list view
        private void NotesListView_AfterLabelEdit(object sender, System.Windows.Forms.LabelEditEventArgs e)
        {
            string compare = e.Label; //what label is going to become
            bool update = true;

            if (compare == null)
            {
                compare = NotesListView.Items[e.Item].Text;//use current name if null, used for new character
            }
            compare = compare.Trim();
            foreach (ListViewItem item in NotesListView.Items)
            {
                if (item.Text == compare && item.Index != e.Item)
                {
                    MessageBox.Show("Note '" + compare + "' already exists", "Warning", MessageBoxButtons.OK);
                    NotesListView.Items[e.Item].BeginEdit();
                    update = false;//flag for no update 
                    break;
                }
            }
            if (update)
            {
                if (noteRename)
                {
                    //remove old note
                    string[] tempNote = searchNotes(oldNoteName);
                    NotesList.Remove(tempNote);
                    //add new note
                    tempNote[0] = compare;
                    NotesList.Add(tempNote); 
                }
                else
                {
                    string[] newNote = {compare, "New note contents" };
                    NotesList.Add(newNote);
                    resetNotes();
                }

            }
        }

        //rest diagram when changes are added
        public void resetNotes()
        {
            NotesListView.Clear();
            foreach (string[] item in NotesList)
            {
                NotesListView.Items.Add(item[0].ToString());
            }
        }

        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem newNote = NotesListView.Items.Add("New Note");
            NotesListView.SelectedItems.Clear();
            NotesListView.SelectedItems.Equals(newNote);
            newNote.BeginEdit();

        }

        private void deleteNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String listName = NotesListView.SelectedItems[0].Text;
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete Note '" + listName + "'", "Delete", MessageBoxButtons.YesNoCancel);
            if (confirm == DialogResult.Yes)
            {
                string[] removedNote = searchNotes(NotesListView.SelectedItems[0].Text);
                NotesList.Remove(removedNote);
                NotesListView.SelectedItems[0].Remove();
            }
        }

        private void renameNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NotesListView.SelectedItems.Count == 1) {
                noteRename = true;
                oldNoteName = NotesListView.SelectedItems[0].Text;
                NotesListView.SelectedItems[0].BeginEdit();
                noteRename = false;
            }
        }

        #endregion

        #region Diagram Tab

        private void DiagramListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //check if not null 
            if (DiagramListView.SelectedItems.Count != 0)
            {
                DiagramsTextBox.Enabled = true;
                string[] diagram = searchDiagrams(DiagramListView.SelectedItems[0].Text.ToString());
                this.DiagramsTextBox.Clear();
                this.DiagramsTextBox.Text = diagram[1];
                this.DiagramPictureBox.Image = Image.FromFile(diagram[2]);
                DiagramImageLocation = diagram[2];
                importNewImageToolStripMenuItem.Enabled = true;
                deleteDiagramToolStripMenuItem.Enabled = true;
                renameDiagramToolStripMenuItem.Enabled = true;

            }
            else
            {
                DiagramsTextBox.Enabled = false;
                importNewImageToolStripMenuItem.Enabled = false;
                deleteDiagramToolStripMenuItem.Enabled = false;
                renameDiagramToolStripMenuItem.Enabled = false;
                DiagramsTextBox.Clear();
                DiagramPictureBox.Image = Image.FromFile("C:\\Users\\eahea\\Desktop\\ChalkBoard\\Sample\\Images\\default_diagram.jpg");
            }
        }

        public string[] searchDiagrams(string name)
        {
            string[] defaultDiagram = { "Default","This is a default diagram","C:\\Users\\eahea\\Desktop\\ChalkBoard\\Sample\\Images\\default_diagram.jpg"};
            foreach (string[] item in DiagramList)
            {
                if (name == item[0])
                {
                    return item;
                }
            }
            return defaultDiagram;
        }

        //rest diagram when changes are added
        public void resetDiagram()
        {
            DiagramListView.Clear();
            foreach (string[] item in DiagramList)
            {
                DiagramListView.Items.Add(item[0].ToString());
            }
        }

        private void addDiagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem newDiagram = DiagramListView.Items.Add("New Diagram");
            DiagramListView.SelectedItems.Clear();
            DiagramListView.SelectedItems.Equals(newDiagram);
            newDiagram.BeginEdit();
        }


        private void deleteDiagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String listName = DiagramListView.SelectedItems[0].Text;
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete Diagram '" + listName + "'", "Delete", MessageBoxButtons.YesNoCancel);
            if (confirm == DialogResult.Yes)
            {
                string[] removedDiagram = searchDiagrams(DiagramListView.SelectedItems[0].Text);
                DiagramList.Remove(removedDiagram);
                DiagramListView.SelectedItems[0].Remove();
            }
        }

        private void renameDiagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(DiagramListView.SelectedItems.Count == 1)
            {
                diagramRewrite = true;
                oldDiagram = DiagramListView.SelectedItems[0].Text;
                DiagramListView.SelectedItems[0].BeginEdit();
                diagramRewrite = false;
            }

        }

        //check renameing for diagram (ListView)
        private void DiagramListView_AfterLabelEdit(object sender, System.Windows.Forms.LabelEditEventArgs e)
        {
            string compare = e.Label; //what label is going to become
            bool update = true;

            if (compare == null)
            {
                compare = DiagramListView.Items[e.Item].Text;//use current name if null, used for new character
            }
            compare = compare.Trim();
            foreach (ListViewItem item in DiagramListView.Items)
            {
                if (item.Text == compare && item.Index != e.Item)
                {
                    MessageBox.Show("Diagram '" + compare + "' already exists", "Warning", MessageBoxButtons.OK);
                    DiagramListView.Items[e.Item].BeginEdit();
                    update = false;//flag for no update 
                    break;
                }
            }
            if (update)
            {
                if (diagramRewrite)
                {
                    //remove old diagram
                    string[] tempDiagram = searchDiagrams(oldDiagram);
                    DiagramList.Remove(tempDiagram);
                    //add new diagram
                    tempDiagram[0] = compare;
                    DiagramList.Add(tempDiagram);
                }
                else
                {
                    //create new diagram
                    string[] newDiagram = { compare, "new description", @"C:\Users\eahea\Desktop\ChalkBoard\Sample\Images\default_diagram.jpg" };
                    DiagramList.Add(newDiagram);
                    resetDiagram();
                }
            }

        }

        #endregion

        #region Saveing

        public void saveScene()
        {
            TreeNode sceneNode = ChapterSelect.SelectedNode;
            string path = (ChapterDirectory + "\\" + sceneNode.Parent.Text + "\\" + sceneNode.Text + ".rtf");
            TextEditorTextBox.SaveFile(path, 0); //The 0 is an enum that dictates the stream type, in this case Rich Text

        }

        public void saveCharacter()
        {
            //Saving a character in a selected dictionary
            if (CharactersListView.SelectedItems.Count == 1)
            {
                string[] editedCharacter = searchCharacters(CharactersListView.SelectedItems[0].Text);
                editedCharacter[1] = parseTextBox(SexComboBox.Text);
                editedCharacter[2] = parseTextBox(CharactersTextBox.Text);
                editedCharacter[3] = parseTextBox(MotherTextBox.Text);
                editedCharacter[4] = parseTextBox(FatherTextBox.Text);
                editedCharacter[5] = parseTextBox(GroupTextBox.Text);
                resetCharacters();
            }
            FileManager characterSave = new FileManager(CharactersDirectory + "\\" + CharacterSelect.SelectedNode.Text + ".txt");
            characterSave.writeFile(CharacterList);
        }

        public void saveDiagram()
        {
            if(DiagramListView.SelectedItems.Count == 1)
            {
                string[] editedDiagram = searchDiagrams(DiagramListView.SelectedItems[0].Text);
                editedDiagram[1] = parseTextBox(DiagramsTextBox.Text);
                editedDiagram[2] = DiagramImageLocation;
                resetDiagram();
            }
            FileManager diagramSave = new FileManager(DiagramFile);
            diagramSave.writeFile(DiagramList);
        }

        public void saveDictionary()
        {

        }

        public void saveWord()
        {
            //Saving a words in a selected dictionary
            if (DictionaryListView.SelectedItems.Count == 1 && DictionaryTextBox.Enabled == true)
            {
                string[] editedWord = searchDictionary(DictionaryListView.SelectedItems[0].Text);
                editedWord[1] = parseTextBox(DictionaryTextBox.Text);
                resetDictionary();
            }
            FileManager wordSave = new FileManager(DictionaryDirectory+"\\"+ DictionarySelect.SelectedNode.Text+".txt");
            wordSave.writeFile(DictionaryList);
        }

        public void saveNotes()
        {
            if (NotesListView.SelectedItems.Count == 1 && NotesTextBox.Enabled == true)
            {
                string[] editedNote = searchNotes(NotesListView.SelectedItems[0].Text);
                editedNote[1] = parseTextBox(NotesTextBox.Text);
                resetNotes();
            }
            FileManager notesSave = new FileManager(NotesFile);
            notesSave.writeFile(NotesList);
        }

        #endregion

        //parsing text in rich text boxes
        public string parseTextBox(string Text)
        {
            string newText = "";
            for (int i = 0; i < Text.Length; i++)
            {
                if (Text[i] == '\n')
                {
                    newText += " ";
                }
                else
                {
                    newText += Text[i];
                }
            }
            return newText;
        }

    }
}
