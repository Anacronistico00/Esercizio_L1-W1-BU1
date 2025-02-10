namespace Esercizio_L1_W1_BU1
{
    internal class Dipendente
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Role { get; set; }
        public int Age { get; set; }
        public Dipendente(string firstName, string lastName, string company, string role, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Company = company;
            Role = role;
            Age = age;
        }
        public void showEmployeeInfo()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Dati del dipendente:");
            Console.WriteLine($"Nome: {FirstName} \nCognome: {LastName} \nAzienda: {Company} \nRuolo: {Role} \nEtà: {Age}");
        }
    }
}
