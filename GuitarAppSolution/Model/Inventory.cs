using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAppSolution.Model
{
    public class Inventory
    {
        public List<Guitar> guitars = new List<Guitar>();

        public void AddGuitar(string serialNo, double price, GuitarSpecs.Builder builder, string model, GuitarSpecs.Type type, GuitarSpecs.Wood backWood, GuitarSpecs.Wood topWood)
        {
            GuitarSpecs guitarSpecs = new GuitarSpecs(builder, model, type, backWood, topWood);
            Guitar guitar = new Guitar(serialNo, price, guitarSpecs);
            guitars.Add(guitar);
        }

        public Guitar GetGuitar(string serialNo)
        {
            Guitar searchGuitar = null;
            foreach (var guitar in guitars)
            {
                if (guitar.GuitarSerialNo == serialNo)
                {
                    searchGuitar = guitar;
                }
            }
            return searchGuitar;
        }

        public List<Guitar> SearchGuitar(GuitarSpecs requiredGuitar)
        {
            List<Guitar> recomendedGuitars = new List<Guitar>();
            foreach (var guitar in guitars)
            {
                if ((string.IsNullOrEmpty(requiredGuitar.GuitarModel) || requiredGuitar.GuitarModel == guitar.GuitarSpec.GuitarModel)
                    && (requiredGuitar.GuitarBuilder == null || requiredGuitar.GuitarBuilder == guitar.GuitarSpec.GuitarBuilder)
                    && (requiredGuitar.GuitarType == null || requiredGuitar.GuitarType == guitar.GuitarSpec.GuitarType)
                    && (requiredGuitar.GuitarBackWood == null|| requiredGuitar.GuitarBackWood == guitar.GuitarSpec.GuitarBackWood)
                    && (requiredGuitar.GuitarTopWood == null || requiredGuitar.GuitarTopWood == guitar.GuitarSpec.GuitarTopWood))
                {
                    
                    recomendedGuitars.Add(guitar);
                }
            }
            return recomendedGuitars;
        }
    }
}
