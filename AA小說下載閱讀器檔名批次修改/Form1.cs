using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AA小說下載閱讀器檔名批次修改
{
    public partial class AA修改器 : Form
    {
        string bookName = "";
        public AA修改器()
        {
            InitializeComponent();
        }

        private void loadFile_cmd_Click(object sender, EventArgs e)
        {
            string filepath="";
            string directoryPath = "";
            List<chapters> chapters = new List<chapters>();
            //List<List<string>> returnedChapterName = new List<List<string>>();//1

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "請選擇BOOL.XML檔";
            dialog.Filter = "BOOK.xml|*.xml";
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                filepath = dialog.FileName;
                directoryPath = System.IO.Path.GetDirectoryName(filepath);
                chapters = xmlReader(filepath);
                fileNameChanger(chapters, directoryPath);
            }



        }
        private List<chapters> xmlReader(string _filepath)
        {

            //List<List<string>> existedChapterName = new List<List<string>>();
            List<chapters> chapters1= new List<chapters>();
            XmlDocument doc = new XmlDocument();
                doc.Load(_filepath);
            //doc.GetElementsByTagName("book");
            //chapterinfo
            bookName = doc.SelectSingleNode("book/bookinfo/bookname").InnerText;
            XmlNodeList chapters = doc.SelectNodes("book/chapterinfo");
            int chapterCount = 1;
            foreach (XmlNode chapterinfoNode in chapters)
            {
                if (chapterinfoNode.SelectSingleNode("chapterpath")!=null)
                {

                    chapters1.Add(new chapters { chapterName = chapterinfoNode.SelectSingleNode("chaptername").InnerText,chapterOrder=chapterCount.ToString(),chapterPath= chapterinfoNode.SelectSingleNode("chapterpath").InnerText }) ;
                    //existedChapterName.Add(new List<string>() {chapterinfoNode.SelectSingleNode("chaptername").InnerText , chapterinfoNode.SelectSingleNode("chapterpath").InnerText });
                    chapterCount++;

                }


            }
                 Console.WriteLine(_filepath);
            return chapters1;
        }

        private void fileNameChanger(List<chapters> _nameList ,string rootPath)
        {


            for (int i = 0; i < _nameList.Count; i++)
            {
                string fileBefore = rootPath + @"\" + _nameList[i].chapterPath;
                string fileAfter = "";
                if (prefixDigist.Checked)
                {
                    fileAfter = rootPath + $@"\{_nameList[i].chapterOrder}_" + _nameList[i].chapterName + ".txt";
                }
                else
                {

                    fileAfter = rootPath + @"\" + _nameList[i].chapterName + ".txt";
                }
                try
                {
                    if (File.Exists(fileBefore) == true)
                    {
                        File.Move(fileBefore, fileAfter);
                        _nameList[i].afterPath = fileAfter;

                    }
                }
                catch (Exception)
                {

                    throw;
                }
                

              
            }
            if (combineTXT.Checked)
            {
                CombineTXT(_nameList, rootPath);
            }


        }
        void CombineTXT(List<chapters> chapters,string rootPath)
        {
            string cobinedTxt=Path.Combine(rootPath, $"{bookName}_combined.txt");
            if (!File.Exists(cobinedTxt)){
                FileStream fs = new FileStream(cobinedTxt, FileMode.Create, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(fs);
                foreach (chapters chapter in chapters)
                {

                    FileStream readChapter = new FileStream(chapter.afterPath, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(readChapter);
                    streamWriter.Write($"⊙{chapter.chapterName}\n");
                    streamWriter.Write(sr.ReadToEnd());
                    streamWriter.Write($"\n\n");
                    readChapter.Close();
                }
                streamWriter.Flush();
                streamWriter.Close();
          
            }



        }
        class chapters {

            public string chapterName  { get; set; }
            public string chapterOrder { get; set; }
            public string chapterPath  { get; set; }
            public string afterPath { get; set; }
            //chapters(string name,string order,string path) { 
            
            //    chapterName = name;
            //    chapterOrder = order;
            //    chapterPath = path;                
            
            //}
        
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            //if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Link;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
        //    string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
        //    foreach (string file in files) Console.WriteLine(file);
        }
    }
}
