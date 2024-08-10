using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAppSolution.Model
{
    
        public class Guitar
        {
            public string GuitarSerialNo { get; set; }
            public double GuitarPrice { get; set; }
            public GuitarSpecs GuitarSpec { get; set; }

            

            public Guitar(string serialNo, double price, GuitarSpecs guitarSpecs)
            {
                GuitarSerialNo = serialNo;
                GuitarPrice = price;
                GuitarSpec = guitarSpecs;
            }
        }
    }

