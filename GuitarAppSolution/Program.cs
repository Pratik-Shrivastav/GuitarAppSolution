using GuitarAppSolution.Model;

public class Program
{
    
    static void Main(string[] args)
    {
        Inventory inventory = new Inventory();
        inventory.AddGuitar("SN12345", 1500.00, GuitarSpecs.Builder.Fender, "Stratocaster", GuitarSpecs.Type.Electric, GuitarSpecs.Wood.Alder, GuitarSpecs.Wood.Maple);
        inventory.AddGuitar("SN67890", 2000.00, GuitarSpecs.Builder.Gibson, "Les Paul", GuitarSpecs.Type.Electric, GuitarSpecs.Wood.Mahogany, GuitarSpecs.Wood.Rosewood);
        inventory.AddGuitar("SN11223", 1200.00, GuitarSpecs.Builder.Taylor, "314ce", GuitarSpecs.Type.Acoustic, GuitarSpecs.Wood.Mahogany, GuitarSpecs.Wood.SitkaSpruce);

        //PrintClass.PrintGuitar(inventory.GetGuitar("SN67890"));

        PrintClass.PrintGuitar(inventory.SearchGuitar(new GuitarSpecs(null, null ,null , GuitarSpecs.Wood.Mahogany,null)));

    }
}