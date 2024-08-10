using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAppSolution.Model
{
    public class GuitarSpecs
    {
        public enum Builder { Fender , Gibson , Taylor };
        public enum Type { Electric, Acoustic };

        public enum Wood { Alder , Mahogany , Maple , Rosewood , SitkaSpruce };
        public Builder? GuitarBuilder { get; set; }
        public string GuitarModel { get; set; }
        public Type? GuitarType { get; set; }
        public Wood? GuitarBackWood { get; set; }
        public Wood? GuitarTopWood { get; set; }

        public GuitarSpecs(Builder? guitarBuilder, string guitarModel, Type? guitarType, Wood? guitarBackWood, Wood? guitarTopWood)
        {
            GuitarBuilder = guitarBuilder;
            GuitarModel = guitarModel;
            GuitarType = guitarType;
            GuitarBackWood = guitarBackWood;
            GuitarTopWood = guitarTopWood;
        }
    }
}
