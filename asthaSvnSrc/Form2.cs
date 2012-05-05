using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Threading;

namespace asthaSvnSrc
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private string _svnFileLocation = "";
        public string SvnFileLocation
        {
            get
            {
                return _svnFileLocation;
            }
            set
            {

                _svnFileLocation = value;

            }
        }

        private string _srcFileLocation = "";
        public string SrcFileLocation
        {
            get
            {
                return _srcFileLocation;
            }
            set
            {

                _srcFileLocation = value;

            }
        }
        private string _projectName = "";
        public string ProjectName
        {
            get
            {
                return _projectName;
            }
            set
            {

                _projectName = value;

            }
        }
        
        public string _xmlfilename = "";
        public string[] _folderName = new string[100];
        public string[] _fileName = new string[100];
        public int _folderNumber = 0;
        public int _fileNumber = 0;
        private long _totalSize = 0;
        private long _copyedSize = 0;
        private string _currentDirectory = "";
        private string _sourcePath = "";
        public string sourcePath
        {
            get
            {
                return _sourcePath;
            }
            set
            {

                _sourcePath = value;

            }
        }
        private string _destinationPath = "";
        public string destinationPath
        {
            get
            {
                return _destinationPath;
            }
            set
            {

                _destinationPath = value;

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            _currentDirectory = Directory.GetCurrentDirectory();
            tab1_load();
            tab2_load();
            tab3_load();
        }
        private void tab2_load()
        {
            XmlTextReader reader = new XmlTextReader(_currentDirectory + "\\" + "SVN.xml");
            string element = "";
            string textstr = "";
            dgvFolder.Rows.Clear();
            dgvFile.Rows.Clear();
            int fo = 0, fi = 0;
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.
                        element = reader.Name;
                        break;
                    case XmlNodeType.Text:   //Display the text in each element.
                        textstr = reader.Value;
                        if (element == "folder")
                        {
                            dgvFolder.Rows.Add();
                            dgvFolder.Rows[fo].Cells[0].Value = textstr;
                            fo++;
                        }
                        else if (element == "file")
                        {
                            dgvFile.Rows.Add();
                            dgvFile.Rows[fi].Cells[0].Value = textstr;
                            fi++;
                        }
                        break;
                    case XmlNodeType.EndElement: //Display the end of the element.
                        break;
                }
            }
            reader.Close();
        }
        private void tab3_load()
        {

            XmlTextReader reader = new XmlTextReader(_currentDirectory + "\\" + "SRC.xml");
            string element = "";
            string textstr = "";
            dgvFolderSrc.Rows.Clear();
            dgvFileSrc.Rows.Clear();
            int fo = 0, fi = 0;
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.
                        element = reader.Name;
                        break;
                    case XmlNodeType.Text:   //Display the text in each element.
                        textstr = reader.Value;
                        if (element == "folder")
                        {
                            dgvFolderSrc.Rows.Add();
                            dgvFolderSrc.Rows[fo].Cells[0].Value = textstr;
                            fo++;
                        }
                        else if (element == "file")
                        {
                            dgvFileSrc.Rows.Add();
                            dgvFileSrc.Rows[fi].Cells[0].Value = textstr;
                            fi++;
                        }
                        break;
                    case XmlNodeType.EndElement: //Display the end of the element.
                        break;
                }
            }
            reader.Close();
        }
        private void tab1_load()
        {
            btnNew.Enabled = true;
            btnOpen.Enabled = true;
            /*
            btnClose.Visible = false;
            btnOpenSvn.Visible = false;
            btnRun.Visible = false;
            btnSave.Visible = false;
            btnSrcLocation.Visible = false;
            rdbSrc.Visible = false;
            rdbSVN.Visible = false;
            txtProjectName.Visible = false;
            txtSrcLocation.Visible = false;
            txtSvnLocation.Visible = false;
            lblProjectName.Visible = false;
            lblSrcLocation.Visible = false;
            lblSvnLocation.Visible = false;
            */
            gbProgram.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {   
            newOpen();
        }
        private void newOpen()
        {
            
            btnNew.Enabled = false;
            btnOpen.Enabled = false;
            /*
            btnClose.Visible = true;
            btnOpenSvn.Visible = true;
            btnRun.Visible = true;
            btnSave.Visible = true;
            btnSrcLocation.Visible = true;
            rdbSrc.Visible = true;
            rdbSVN.Visible = true;
            txtProjectName.Visible = true;
            txtSrcLocation.Visible = true;
            txtSvnLocation.Visible = true;
            lblProjectName.Visible = true;
            lblSrcLocation.Visible = true;
            lblSvnLocation.Visible = true;
            */
            gbProgram.Enabled = true;
            //rdbSVN.Select();
            rdbSVN.Checked = true;
            txtProjectName.Text = "";
            txtSrcLocation.Text = "";
            txtSvnLocation.Text = "";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            btnOpen.Visible = true;
            btnNew.Visible = true;
            tab1_load();
        }

        private void btnOpenSvn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = fbdOpen.ShowDialog();
            
                if (result == DialogResult.OK)
                {
                    string folderName = fbdOpen.SelectedPath;
                    if (folderName != "")
                    {
                        _svnFileLocation = folderName;
                        txtSvnLocation.Text = folderName;
                    }
                }
            }
            catch (Exception p1)
            {
                MessageBox.Show("Can not open folder for permission" + p1.Message);
            }
        }

        private void btnSrcLocation_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = fbdOpen.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string folderName = fbdOpen.SelectedPath;
                    if (folderName != "")
                    {
                        _srcFileLocation = folderName;
                        txtSrcLocation.Text = folderName;
                    }
                }
            }
            catch (Exception p1)
            {
                MessageBox.Show("Can not open folder for permission" + p1.Message);
            }
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            int flag = 1;

            for (int i = 0; i < txtProjectName.Text.Length; i++)
                if (txtProjectName.Text[i].ToString() == "#")
                    flag = 0;

            if (txtProjectName.Text == "" || txtSrcLocation.Text == "" || txtSvnLocation.Text == "")
                MessageBox.Show("Required Field is empty!!!");
            else if (flag == 0)
            {
                MessageBox.Show("Project name is invalid.");
            }
            else if (txtSrcLocation.Text == txtSvnLocation.Text)
                MessageBox.Show("The source and destinations are same.");
            else
            {

                try
                {
                    _svnFileLocation = txtSvnLocation.Text;
                    _srcFileLocation = txtSrcLocation.Text;
                    sfdSave.FileName = txtProjectName.Text.Trim();
                    sfdSave.ShowDialog();
                }
                catch (Exception p1)
                {
                    MessageBox.Show("Can not save for permission" + p1.Message);
                }
            }
        }

        private void sfdSave_FileOk(object sender, CancelEventArgs e)
        {
            string path = sfdSave.FileName.ToString();
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                using (FileStream fs = File.Create(path))
                {

                    Byte[] info = new UTF8Encoding(true).GetBytes(txtProjectName.Text + "#" + _svnFileLocation + "#" + _srcFileLocation);

                    fs.Write(info, 0, info.Length);

                    fs.Close();

                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                ofdOpenfile.ShowDialog();
            }
            catch (Exception e2)
            {
                MessageBox.Show("Can not open file for permission"+e2.Message);
            }
        }

        private void ofdOpenfile_FileOk(object sender, CancelEventArgs e)
        {
            

            try
            {
                string path = ofdOpenfile.FileName.ToString();
                StreamReader SR;
                string info = "";
                string S;
                SR = File.OpenText(path);
                S = SR.ReadLine();
                while (S != null)
                {
                    info += S;
                    S = SR.ReadLine();
                }
                SR.Close();
                char[] a = new char[1];
                a[0] = '#';
                string[] informarion = info.Split(a);
                newOpen();
                _projectName = informarion[0];
                _svnFileLocation = informarion[1];
                _srcFileLocation = informarion[2];
                txtProjectName.Text = _projectName;
                txtSrcLocation.Text = _srcFileLocation;
                txtSvnLocation.Text = _svnFileLocation;
                
            }
            catch (Exception py)
            {
                MessageBox.Show("Wrong File.");
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
             sourcePath = "";
             destinationPath = "";
            _svnFileLocation = txtSvnLocation.Text;
            _srcFileLocation = txtSrcLocation.Text;

            if (rdbSVN.Checked)
            {
                sourcePath = _svnFileLocation;
                destinationPath = _srcFileLocation;
                _xmlfilename = "SVN.xml";
            }
            else if (rdbSrc.Checked)
            {
                sourcePath = _srcFileLocation;
                destinationPath = _svnFileLocation;
                _xmlfilename = "SRC.xml";
            }
             
            XmlLoad();
            if (sourcePath == "" || destinationPath == "")
                MessageBox.Show("Source or Destination is invalid !!!!");
            else if (sourcePath == destinationPath)
                MessageBox.Show("Source & Destination path can not be same!!!!!");
            else
            {
                //CopyFolder(sourcePath, destinationPath);
                pbRun.Visible = true;
                pbRun.Step = 5;
                pbRun.Minimum = 0;
                pbRun.Maximum = 200;
                pbRun.Value = 0;
                btnRun.Enabled = false;
                Thread t = new Thread(RunThread);
                t.Start();
               /// RunThread(sourcePath, destinationPath);
                
            }
        }

        public void CopyFolder(string sourceFolder, string destFolder)
        {
            try
            {
                if (!Directory.Exists(destFolder))
                {
                    Directory.CreateDirectory(destFolder);
                    DirectoryInfo di = new DirectoryInfo(sourceFolder);

                    //See if directory has hidden flag, if not, make hidden

                    if ((di.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                    {
                         di = new DirectoryInfo(destFolder);
                         di.Attributes = di.Attributes | FileAttributes.Hidden;

                    }

                
                }
                string[] files = Directory.GetFiles(sourceFolder);
                foreach (string file in files)
                {
                    string name = Path.GetFileName(file);
                    string ext = Path.GetExtension(file);
                    int flag = 1;
                    for (int i = 0; i < _fileNumber; i++)
                        if (ext.ToUpper() == _fileName[i].ToUpper())
                        { flag = 0; break; }
                    if (flag == 1)
                    {
                        string dest = Path.Combine(destFolder, name);
                        if (File.Exists(dest))
                        {
                            bool isReadOnly1 = ((File.GetAttributes(dest) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly);
                            if (isReadOnly1 == true)
                            {
                                File.SetAttributes(dest, FileAttributes.Normal);
                            }
                            File.Delete(dest);
                        }
                        File.Copy(file, dest);

                        System.IO.FileInfo fi = new FileInfo(dest);
                        _copyedSize += fi.Length;
                        bool isReadOnly = ((File.GetAttributes(dest) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly);
                        
                        if (isReadOnly == true)
                        {
                            bool isHidden = ((File.GetAttributes(dest) & FileAttributes.Hidden) == FileAttributes.Hidden);
                            File.SetAttributes(dest, FileAttributes.Normal);
                            if (isHidden == true)
                            {
                                File.SetAttributes(dest, FileAttributes.Archive | FileAttributes.Hidden);

                            }
                        }
                    }
                }
                string[] folders = Directory.GetDirectories(sourceFolder);
                foreach (string folder in folders)
                {
                    string name = Path.GetFileName(folder);
                    int flag = 1;
                    for (int i = 0; i < _folderNumber; i++)
                        if (name.ToUpper() == _folderName[i].ToUpper())
                        { flag = 0; break; }
                    if (flag == 1)
                    {
                        string dest = Path.Combine(destFolder, name);
                        
                        CopyFolder(folder, dest);
                    }
                }
            }
            catch (Exception p1)
            {
                MessageBox.Show("Directory is invalid!! "+p1.Message);
            }
        }

        public void dis()
        {
            pbRun.Visible = false;
            btnRun.Enabled = true;
        }

        public long getDirSize(System.IO.DirectoryInfo dir)
        {
            long size = 0;
            System.IO.DirectoryInfo[] dirs = dir.GetDirectories();
            System.IO.FileInfo[] files = dir.GetFiles();

            foreach (System.IO.FileInfo fi in files)
                size += fi.Length;

            foreach (System.IO.DirectoryInfo di in dirs)
                size += getDirSize(di);
            return size;
        }
        private void FullProgressBar()
        {
            pbRun.Value = 200;
        }
        private void startTimer()
        {
            trRun.Enabled = true;
        }

        public void RunThread()
        {

            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(sourcePath);
            _totalSize =   getDirSize(dir);
            _copyedSize = 0;
            this.Invoke(new MethodInvoker(startTimer));
            CopyFolder(sourcePath,destinationPath);
            trRun.Enabled = false;
            this.Invoke(new MethodInvoker(FullProgressBar));
            MessageBox.Show("Copy Complete!!!");
            this.Invoke(new MethodInvoker(dis));
            
        }
        private void XmlLoad()
        {
            /*
            XmlTextReader reader = new XmlTextReader(_currentDirectory+ "\\" +_xmlfilename);
            string element = "";
            string textstr = "";
            _folderNumber = 0;
            _fileNumber = 0;

            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.
                        element = reader.Name;
                        break;
                    case XmlNodeType.Text:   //Display the text in each element.
                        textstr = reader.Value;
                        if (element == "folder")
                        {
                            _folderName[_folderNumber] = textstr;
                            _folderNumber++;
                        }
                        else if (element == "file")
                        {
                            _fileName[_fileNumber] = textstr;
                            _fileNumber++;
                        }
                        break;
                    case XmlNodeType.EndElement: //Display the end of the element.
                        break;
                }
            }

            reader.Close();
             */
            if (_xmlfilename == "SVN.xml")
            {
                _folderNumber = 0;
                _fileNumber = 0;
                int count = dgvFolder.Rows.Count;
                for (int i = 0; i < count - 1; i++)
                {
                    if (dgvFolder.Rows[i].Cells[0].Value != null)
                    {
                        string text = dgvFolder.Rows[i].Cells[0].Value.ToString();
                        if (text != "")
                        {
                            _folderName[_folderNumber] = text;
                            _folderNumber++;
                        }
                    }
                }

                count = dgvFile.Rows.Count;
                for (int i = 0; i < count - 1; i++)
                {
                    if (dgvFile.Rows[i].Cells[0].Value != null)
                    {
                        string text = dgvFile.Rows[i].Cells[0].Value.ToString();
                        if (text != "")
                        {
                            _fileName[_fileNumber] = text;
                            _fileNumber++;
                        }
                    }
                }
            }
            else if (_xmlfilename == "SRC.xml")
            {
                _folderNumber = 0;
                _fileNumber = 0;
                int count = dgvFolderSrc.Rows.Count;
                for (int i = 0; i < count - 1; i++)
                {
                    if (dgvFolderSrc.Rows[i].Cells[0].Value != null)
                    {
                        string text = dgvFolderSrc.Rows[i].Cells[0].Value.ToString();
                        if (text != "")
                        {
                            _folderName[_folderNumber] = text;
                            _folderNumber++;  
                        }
                    }
                }

                count = dgvFileSrc.Rows.Count;
                for (int i = 0; i < count - 1; i++)
                {
                    if (dgvFileSrc.Rows[i].Cells[0].Value != null)
                    {
                        string text = dgvFileSrc.Rows[i].Cells[0].Value.ToString();
                        if (text != "")
                        {
                            _fileName[_fileNumber] = text;
                            _fileNumber++;

                        }
                    }
                }
            }

        }

        private void btnSaveSvn_Click(object sender, EventArgs e)
        {
            try
            {
                XmlTextWriter textWriter = new XmlTextWriter(_currentDirectory + "\\" + "SVN.xml", null);

                textWriter.WriteStartDocument();

                textWriter.WriteStartElement("root");


                int count = dgvFolder.Rows.Count;
                for (int i = 0; i < count - 1; i++)
                {
                    if (dgvFolder.Rows[i].Cells[0].Value != null)
                    {
                        string text = dgvFolder.Rows[i].Cells[0].Value.ToString();
                        if (text != "")
                        {
                            textWriter.WriteStartElement("folder", "");

                            textWriter.WriteString(text);

                            textWriter.WriteEndElement();
                        }
                    }
                }

                count = dgvFile.Rows.Count;
                for (int i = 0; i < count - 1; i++)
                {
                    if (dgvFile.Rows[i].Cells[0].Value != null)
                    {
                        string text = dgvFile.Rows[i].Cells[0].Value.ToString();
                        if (text != "")
                        {
                            textWriter.WriteStartElement("file", "");

                            textWriter.WriteString(text);

                            textWriter.WriteEndElement();
                        }
                    }
                }

                textWriter.WriteEndDocument();

                textWriter.Close();
                MessageBox.Show("Save Complete!!!");
            }
            catch (Exception p1)
            {
                MessageBox.Show("Can not save file for permission" + p1.Message);
            }
        }

        private void btnSaveSrc_Click(object sender, EventArgs e)
        {

            try
            {
                XmlTextWriter textWriter = new XmlTextWriter(_currentDirectory + "\\" + "SRC.xml", null);

                textWriter.WriteStartDocument();

                textWriter.WriteStartElement("root");


                int count = dgvFolderSrc.Rows.Count;
                for (int i = 0; i < count - 1; i++)
                {
                    if (dgvFolderSrc.Rows[i].Cells[0].Value != null)
                    {
                        string text = dgvFolderSrc.Rows[i].Cells[0].Value.ToString();
                        if (text != "")
                        {
                            textWriter.WriteStartElement("folder", "");

                            textWriter.WriteString(text);

                            textWriter.WriteEndElement();
                        }
                    }
                }

                count = dgvFileSrc.Rows.Count;
                for (int i = 0; i < count - 1; i++)
                {
                    if (dgvFileSrc.Rows[i].Cells[0].Value != null)
                    {
                        string text = dgvFileSrc.Rows[i].Cells[0].Value.ToString();
                        if (text != "")
                        {
                            textWriter.WriteStartElement("file", "");

                            textWriter.WriteString(text);

                            textWriter.WriteEndElement();
                        }
                    }
                }

                textWriter.WriteEndDocument();

                textWriter.Close();
                MessageBox.Show("Save Complete!!!");
            }
            catch (Exception p1)
            {
                MessageBox.Show("Can not save file for permission" + p1.Message);
            }
        }

        private void btnRefreshSvn_Click(object sender, EventArgs e)
        {
            tab2_load();
        }

        private void btnRefreshSrc_Click(object sender, EventArgs e)
        {
            tab3_load();
        }

        private void trRun_Tick(object sender, EventArgs e)
        {

            double per = Convert.ToDouble(_copyedSize);
            if (_totalSize != 0)
                per = per / (Convert.ToDouble(_totalSize));
            else
                per = 1;
            per *= 200;
            pbRun.Value = Convert.ToInt32(per);

            /*
            if (pbRun.Value + 20 > 200)
                pbRun.Value = 0;
            else
                pbRun.Value += 20;
             */
        }

    }
}
