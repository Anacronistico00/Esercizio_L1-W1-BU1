namespace Esercizio_L1_W1_BU1
{
    internal class Atleta
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sport { get; set; }
        public int Age { get; set; }
        public Atleta(string firstName, string lastName, string sport, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Sport = sport;
            Age = age;
        }
        public void showAthleteInfo()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Dati dell'atleta:");
            Console.WriteLine($"Nome: {FirstName} \nCognome: {LastName} \nSport: {Sport} \nEtà: {Age}");
        }
    }
}
