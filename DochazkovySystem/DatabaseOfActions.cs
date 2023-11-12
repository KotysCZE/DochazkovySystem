using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DochazkovySystem
{
    internal class DatabaseOfActions
    {
        string directoryPath = ""; //zde je potřeba napsat cestu do složky, kam se budou ukládat akce aplikace
        string fileName = "11";
        public string AddArrival(string numberOfEmployee)
        {
            string fileNameToRead = numberOfEmployee;
            bool fileExists = CheckExistanceOfFile(directoryPath, fileNameToRead);

            if (fileExists)
            {
                try
                {
                    List<string> lines = Reader();
                    if (LastAction() == "P")
                    {
                        return "Zaměstnanec je již na pracovišti";
                    }
                    else
                    {
                        StreamWriter sw = new StreamWriter(directoryPath + $"{fileName}");


                        foreach (string newline in lines)
                        {
                            sw.WriteLine(newline);
                        }
                        sw.Write($"{DateTime.Now};Příchod zaměstnance;P");
                        sw.Flush();
                        sw.Close();
                        return "Záznam úspěšně uložen";
                    }
                }
                catch (Exception ex)
                {
                    return $"Nepodařilo se uložit záznam - {ex.Message}";
                }
            }
            else

                return $"Nebyl nalezen zaměstnanec číslo {fileNameToRead}";
        }


        public string  AddLeave(string numberOfEmployee)
        {
            string fileNameToRead = numberOfEmployee;
            bool fileExists = CheckExistanceOfFile(directoryPath, fileNameToRead);

            if (fileExists)
            {
                try
                {
                    List<string> lines = Reader();
                    if (LastAction() == "O")
                        return"Zaměstnanec je již pryč nebo ještě nepřišel";
                    else
                    {
                        StreamWriter sw = new StreamWriter(directoryPath + $"{fileName}");
                        foreach (string newline in lines)
                        {
                            sw.WriteLine(newline);
                        }
                        sw.Write($"{DateTime.Now};Odchod zaměstnance;O");
                        sw.Flush();
                        sw.Close();
                        return "Záznam byl úspěšně přidán";
                    }
                }
                catch (Exception ex)
                {
                    return $"Nepodařilo se uložit záznam - {ex.Message}";
                }
            }
            else

                return $"Nebyl nalezen zaměstnanec číslo {fileNameToRead}";
        }


        private List<string> Reader()
        {
            StreamReader sr = new StreamReader(directoryPath + $"{fileName}");
            string line = "";
            List<string> lines = new List<string>();

            while (line != null)
            {
                line = sr.ReadLine();
                if (line != null)
                    lines.Add(line);
            }

            sr.Close();
            return lines;
        }
        public string LastAction()
        {
            List<string> lines = Reader();
            if (lines.Count > 0)
            {
                string lastLine = lines[lines.Count - 1];
                string[] lastActionField = lastLine.Split(';');
                string lastAction = lastActionField[lastActionField.Count() - 1];

                return lastAction;
            }
            else
                return "O";
        }

        public bool CheckExistanceOfFile(string directoryPath, string fileNameToRead)
        {
            string fileName = fileNameToRead + ".txt";

            this.fileName = fileName;

            string[] files = Directory.GetFiles(directoryPath);

            bool fileExists = false;

            foreach (string file in files)
            {
                if (Path.GetFileName(file) == fileName)
                {
                    fileExists = true;
                    break;
                }
            }

            return fileExists;
        }
    }
}
