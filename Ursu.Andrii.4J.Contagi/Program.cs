using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ursu.Andrii._4J.Contagi.Models;
using System.IO;
using Newtonsoft.Json;

namespace Ursu.Andrii._4J.Contagi
{
    class Program
    {
        static void Main(string[] args)
        {
           
           string path = "ContagiRimini.json";
           CRimini contagi = new CRimini(path);
           contagi.salvaFile(path);
           contagi.CambiaData();
        }
    }
}
