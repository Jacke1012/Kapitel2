using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;

namespace Övning2._1
{
    [DataContract]
    [KnownType(typeof(Media))]
    [KnownType(typeof(Bok))]
    [KnownType(typeof(Film))]
    [KnownType(typeof(LjudSpår))]
    public class Media
    {
        [DataMember]
        protected string titel;
        public static List<Media> bibliotek = new List<Media>();

        public Media()
        {
        }

        public Media(string titel)
        {
            this.titel = titel;
        }

        public override string ToString()
        {
            return titel;
        }

        
        public static void Save()
        {
            DataContractSerializer ser = new DataContractSerializer(typeof(List<Media>));

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Xml file (.xml)|*.xml";
            saveFileDialog1.Title = "Save a bibliotek";

            DialogResult result = saveFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                using (FileStream fs = (FileStream)saveFileDialog1.OpenFile())
                {
                    ser.WriteObject(fs, bibliotek);
                }
            }
            else
            {
                return;
            }
        }

        public static bool LoadData()
        {
            DataContractSerializer ser = new DataContractSerializer(typeof(List<Media>));

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.FileName = "Document"; 
            dlg.DefaultExt = ".xml"; 
            dlg.Filter = "Xml (.xml)|*.xml"; 

            DialogResult result = dlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                using (FileStream fs = (FileStream)dlg.OpenFile())
                {
                    bibliotek = (List<Media>)ser.ReadObject(fs);
                    return true;
                }
            }
            else
            {
                return false;
            }


        }
    }

    [DataContract]
    public class Bok : Media
    {
        [DataMember]
        protected int antalSidor;

        public Bok()
        {
        }
        public Bok(string titel, int antalSidor) : base(titel)
        {
            this.antalSidor = antalSidor;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1} sidor", titel, antalSidor);
        }
    }

    [DataContract]
    public class LjudSpår : Media
    {
        [DataMember]
        protected float spelTidIMin;

        public LjudSpår()
        {
        }
        public LjudSpår(string titel, float spelTidIMin) : base(titel)
        {
            this.spelTidIMin = spelTidIMin;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1} minuter", titel, spelTidIMin);
        }
    }

    [DataContract]
    public class Film : LjudSpår
    {
        [DataMember]
        protected string Upplösning;

        public Film()
        {
        }
        public Film(string titel, float spelTidIMin, string Upplösning) : base(titel, spelTidIMin)
        {
            this.spelTidIMin = spelTidIMin;
            this.Upplösning = Upplösning;
        }
        public override string ToString()
        {
            return string.Format("{0}, {1}: {2} minuter", titel, Upplösning, spelTidIMin);
        }
    }
}
