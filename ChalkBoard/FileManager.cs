using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace ChalkBoard
{
    class FileManager
    {
        //This class is used to read/write to files associated with the Characters, Diagrams, Dictionary, and Notes tab

        private string filename;
        private List<string[]> myList;
        
        //create FileManager with file path
        public FileManager(string fn)
        {
            filename = fn;
            myList = new List<string[]>();
        }

        #region Getters and Setters
        //set the file path
        public void setFilename(string fn)
        {
            filename = fn;
        } 
        //get the file path
        public string getFilename()
        {
            return filename;
        }

        //get myList, (data parsed from the file)
        public List<string[]> getList()
        {
            return myList;
        }
        #endregion


        //parse file, place data into myList
        public void parseFile()
        {
            myList = new List<string[]>();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null )
                {
     
                    string[] lineArray = line.Split('|');
                    myList.Add(lineArray);

                }
                reader.Close();
            }
        }

        public void writeFile(List<string[]> list)
        {
            File.WriteAllText(filename, string.Empty);
            using (StreamWriter writer = File.AppendText(filename))
            {
                string inputLine = "";
                foreach (string[] item in list)
                {
                    for(int i=0; i<item.Length; i++)
                    {
                        if (i <= item.Length - 2)
                        {
                            inputLine += item[i] + "|";
                        } else if (i == item.Length - 1)
                        {
                            inputLine += item[i];
                        }
                        
                    }
                    writer.WriteLine(inputLine);
                    inputLine = "";
                }
                writer.Close();
            }

        }

        #region Testing Methods
        //testing method
        public void printdictionary()
        {
            foreach (string[] item in myList)
            {
                Console.WriteLine("word: " + item[0] + ", definition: " + item[1]);
            }
        }

        //testing method
        public void printcharacters()
        {
            foreach (string[] item in myList)
            {
                Console.WriteLine("name: " + item[0] +", Sex: "+item[1]+", description: " + item[2] + ", mother: " + item[3] + ", father: " + item[4] + ", affiliations: " + item[5]);
            }
        }
        #endregion

    }
}
