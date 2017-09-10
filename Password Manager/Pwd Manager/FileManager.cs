using System;
using System.Collections.Generic;
using System.IO;

namespace Pwd_Manager
{
    public class FileManager
    {
        private string Path;

        public FileManager()
        {
            InitializeDirectory();
        }

        private void InitializeDirectory()
        {
            try
            {
                Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                Path += "\\PasswordManager";
                DirectoryInfo dinfo = new DirectoryInfo(Path);
                Directory.CreateDirectory(Path);
            }
            catch(Exception e)
            {
                Console.WriteLine("Erreur : {0}", e.Message);
            }
            
        }

        public void WriteDomains(List<Domain> ListDomain)
        {
            // écrit un fichier texte correspondant aux fichier .domain à charger, chaque fichier.domain contenant tous les
            // mots de passe du domaine en question
            BinaryWriter bw;
            string FilePath = Path + "\\Domains.txt";

            try
            {
                //Création du fichier
                bw = new BinaryWriter(new FileStream(FilePath, FileMode.OpenOrCreate));
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot create file.");
                return;
            }

            try
            {
                foreach(Domain element in ListDomain)
                {
                    string WriteFile = element.Domaine + ";"; //Pour qu'à la relecture -> string.split
                    bw.Write(WriteFile);
                }
                bw.Flush();
                bw.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot write to file.");
                return;
            }
        }

        public string ReadDomains()
        {
            BinaryReader br;
            string FilePath = Path + "\\Domains.txt";
            string ReturnFile = "";

            try
            {
                br = new BinaryReader(new FileStream(FilePath, FileMode.Open));
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot open file.");
                return "NOT FOUND";
            }

            try
            {
                string ReadFile = "";
                while ((ReadFile = br.ReadString()) != null)
                {
                    ReturnFile += ReadFile;
                }

                return null;
            }
            catch(IOException e)
            {
                br.Close();
                ReturnFile = ReturnFile.Remove(ReturnFile.Length - 1);
                return ReturnFile;
            }
        }

        public void WritePasswords(Domain Domaine)
        {
            BinaryWriter bw;
            string FilePath = Path + "\\" + Domaine.Domaine + ".domain";

            try
            {
                bw = new BinaryWriter(new FileStream(FilePath, FileMode.OpenOrCreate));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot create file.");
                return;
            }

            try
            {
                string WriteFile = "";

                foreach(User element in Domaine.ListUser)
                {
                    WriteFile = element.Nickname + "\t" + element.Password + "\n";
                    bw.Write(WriteFile);
                }

                bw.Flush();
                bw.Close();
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot write to file.");
                return;
            }
        }

        public Domain ReadPasswords(string DomainName)
        {
            Domain ReturnValue = new Domain(DomainName);
            BinaryReader br;
            string FilePath = Path + "\\" + DomainName + ".domain";
            string ReadValue = "";

            try
            {
                br = new BinaryReader(new FileStream(FilePath, FileMode.Open));
            }
            catch(IOException e)
            {
                Console.WriteLine("{0} - Can't open file", e.Message);
                return null;
            }

            try
            {
                while((ReadValue = br.ReadString()) != null)
                {
                    string[] tabUser = ReadValue.Split('\t');
                    tabUser[1] = tabUser[1].Remove(tabUser[1].Length - 1);
                    ReturnValue.AddUser(tabUser[0], tabUser[1]);
                }
                return null;
            }
            catch(IOException e)
            {
                br.Close();
                return ReturnValue;
            }
        }
    }
}
