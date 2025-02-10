namespace Esercizio_L1_W1_BU1
{
    internal class Veicolo
    {
        public string Company { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public Veicolo(string company, string model, string color, int year)
        {
            Company = company;
            Model = model;
            Color = color;
            Year = year;
        }
        public void showVehicleInfo()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Dati del veicolo:");
            Console.WriteLine($"Marca: {Company} \nModello: {Model} \nColore: {Color} \nAnno: {Year}");
        }
    }
}
