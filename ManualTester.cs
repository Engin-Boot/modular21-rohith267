using System;
using System.Collections.Generic;
using System.Text;

namespace ColorCoderProject
{
    public class ManualTester : IManualOutput
    {
        public List<string> content=new List<string> ();

        public void PrintLine(string line)
        {
            this.content.Add(line);

            
        }
    }
    
}