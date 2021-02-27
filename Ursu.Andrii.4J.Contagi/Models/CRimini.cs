using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Ursu.Andrii._4J.Contagi.Models
{
    class CRimini
    {
        string FPath;
        public string Data { get; set; }
        public string Progressivo { get; set; }
        public string Contagi { get; set; }

        List<CRimini> ListaC = new List<CRimini>();

        public CRimini()
        {

        }

        public CRimini(string path)
        {
            caricaDaFile(path);
        }

       
        public void caricaDaFile(string FPath)
        {
            //Deserializza dal formato JSON
            string file;
            using (var reader = new StreamReader(FPath))
            {
                file = reader.ReadToEnd();
            }
            ListaC = JsonConvert.DeserializeObject<List<CRimini>>(file);

            //ListaC.ForEach(Console.WriteLine);
                
        }

        //metodo per la conversione della data non finito
        public void CambiaData()
        {

            
            DateTime dt = DateTime.ParseExact(ListaC[1].Data, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            dt.ToString("dd/MM/yyyy"); 
           

        }

       

        public void salvaFile(string FPath)
        {
            //Serializza in formato JSON
            string jsonToWrite = JsonConvert.SerializeObject(ListaC, Formatting.Indented);
            using (StreamWriter writer = new StreamWriter(FPath))
            {
                writer.Write(jsonToWrite);
            }
        }
    }
    
}
