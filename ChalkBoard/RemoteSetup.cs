using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChalkBoard
{
    public partial class RemoteSetup : Form
    {

        private string path;
        private List<string[]> remoteList;
        private bool open;

        public RemoteSetup(string pathname)
        {
            InitializeComponent();
            path = pathname;
            LoadInfo();
            open = true;
        }

        private void LoadInfo()
        {
            FileManager myManager = new FileManager(path);
            remoteList = new List<string[]>();
            myManager.parseFile();
            remoteList = myManager.getList();

            if(remoteList.Count != 0)
            {
                RepoNameTextbox.Text = remoteList[0][0];
                serverpathTextbox.Text = remoteList[0][1];
            }
        }

        //Submit Button Action
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            remoteList.Clear();
            string RepoName = RepoNameTextbox.Text;
            string ServerPath = serverpathTextbox.Text;
            string[] repoInfo = { RepoName, ServerPath};
            remoteList.Add(repoInfo);
            FileManager myManager = new FileManager(path);
            myManager.writeFile(remoteList);
            open = false;
            this.Close();
        }

        //Cancel Button ACtion
        private void CancelButton_Click(object sender, EventArgs e)
        {
            open = false;
            this.Close();
        }

        public bool IsOpen()
        {
            return open;
        }
    }
}
