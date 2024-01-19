using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    //Olika hårtyper som går att sätta som längd och färg
    public struct Hair
    {
        public string HairLength { get; set; }
        public string HairColor { get; set; }

        public override string ToString()
        {
            return $"Hårlängd: {HairLength}, Hårfärg: {HairColor}";
        }
    }

