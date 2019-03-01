using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Market_GerarCount
{
    public class GenerateAccount
    {
        static FileStream fs = new FileStream(@"/home/diegobraun/Documentos/Mercado/Market/teste.txt",FileMode.Create,FileAccess.Write,FileShare.None);
        public void Opa(){
            string texto = "Texto para filestream";
            byte [] byteArray = Encoding.UTF8.GetBytes(texto);
            fs.Write(byteArray,0,byteArray.Length);
            fs.Close();
            
        }

        //using (var fileStream = new)
    }
}