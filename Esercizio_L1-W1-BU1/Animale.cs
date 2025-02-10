namespace Esercizio_L1_W1_BU1
{
    internal class Animale
    {
        public string FirstName { get; set; }
        public string Species { get; set; }
        public string Family { get; set; }
        public int Weight { get; set; }

        public Animale(string firstName, string species,string family, int weight)
        {
            FirstName = firstName;
            Species = species;
            Family = family;
            Weight = weight;
        }

        public void showAnimalInfo()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Dati dell'animale:");
            Console.WriteLine($"Nome: {FirstName} \nSpecie: {Species} \nRazza: {Family} \nPeso: {Weight}Kg");
        }
    }
}
