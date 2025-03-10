using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeExample.Examples
{
    public class EncapsulationExample
    {
        //geter seter methodlar 
        //propertyler 

        public string name;

        public void SetName(string _name)
        {
            name = _name;
        }
        
        public string GetName()
        {
            return name;
        }
        
    }
}
