using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;

namespace IO.RccFicoscore.Client
{
    
    public class GeneraPdf
    {
        
        public bool generaPdf(String rutaJar, String fecha, String json, String rutaPdf)
        {
            bool cadena = false;
            System.Diagnostics.Process myProcess = new System.Diagnostics.Process();
            myProcess.StartInfo.UseShellExecute = false;
            myProcess.StartInfo.FileName = "java";
            myProcess.StartInfo.Arguments = "-jar "+rutaJar+" "+fecha+ " "+rutaPdf+" '"+json+"'";
            myProcess.StartInfo.RedirectStandardOutput = true;
            myProcess.Start();
            myProcess.WaitForExit();

            int cad = Int32.Parse(myProcess.StandardOutput.ReadToEnd());
            
            if(cad== 1){
                cadena = true;
            }
            if(cad== 0){
                cadena = false;
            }
            
            return cadena;
        }

    }
}
