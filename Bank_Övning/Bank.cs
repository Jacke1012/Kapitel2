using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.IO;

namespace Bank_Övning
{
    static class Bank
    {
        public static List<BankKonto> bankKonton = new List<BankKonto>();

        public static void UpdateraMedÅrsränta()
        {
            foreach (BankKonto konto in bankKonton)
            {
                konto.BeräknaRänta();
            }
        }

        public static void SaveAccounts()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Bank";

            DataContractSerializer ser = new DataContractSerializer(typeof(List<BankKonto>));

            Directory.CreateDirectory(path);

            using(FileStream fs = new FileStream(path + "\\Save.xml", FileMode.Create))
            {
                ser.WriteObject(fs, bankKonton);
            }
        }

        public static void LoadAccounts()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) 
                + "\\Bank\\Save.xml";

            if (!File.Exists(path))
            {
                return;
            }
            FileStream fs = new FileStream(path, FileMode.Open);

            DataContractSerializer ser = new DataContractSerializer(typeof(List<BankKonto>));

            bankKonton = (List<BankKonto>) ser.ReadObject(fs);

            fs.Dispose();
        }

        public static void DeleteAccount(int index)
        {
            bankKonton.RemoveAt(index);
        }
    }
}
