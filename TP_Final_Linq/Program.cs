using TP_Final_Linq.DAL;
using Microsoft.EntityFrameworkCore;
using TP_Final_Linq.EndPoints;

using (EatDomicileDbContext context = new EatDomicileDbContext())
{
    var adressEp = new AddressEndPoint(context);

    Console.WriteLine("GESTION DES ADRESSES");
    Console.WriteLine("Que voulez-vous faire?");
    Console.WriteLine("1 - Afficher les adresses");
    Console.WriteLine("2 - Créer une nouvelle adresse");
    Console.WriteLine("3 - Modifier une adresse existante");
    Console.WriteLine("4 - Supprimer une adresse existante");

    var userChoise = Console.ReadLine();

    switch (userChoise)
    {
        case "1":
            adressEp.GetAll();
            break;
        case "2":
            CreateAddress(adressEp);
            break;
        case "3": 
            UpdateAddress(adressEp); 
            break;
        default:
            break;
    }
}

static void CreateAddress(AddressEndPoint endPoint)
{
    Console.WriteLine("Veuillez saisir un nom de rue");
    var street = Console.ReadLine();
    Console.WriteLine("Veuillez saisir un nom de ville");
    var city = Console.ReadLine();
    Console.WriteLine("Veuillez saisir un code postal");
    var zip = Console.ReadLine();
    Console.WriteLine("Veuillez saisir un nom de département");
    var state = Console.ReadLine();
    Console.WriteLine("Veuillez saisir un nom de pays");
    var country = Console.ReadLine();
    endPoint.Create(street, city, state, zip, country);
}

static int GetEntier(string input)
{
    if (int.TryParse(input, out int val))
        return val;
    else
        return -1;
}

static void UpdateAddress(AddressEndPoint endPoint)
{
    endPoint.GetAll();
    Console.WriteLine("Veuillez sélectionner une id d'adresse");
    var input = Console.ReadLine();
    int id = GetEntier(input);
    var address = endPoint.GetOne(id);
    Console.WriteLine("Veuillez sélectionner un champ à modifier");
    var paramInput = Console.ReadLine();
    int paramId = GetEntier(input);
    Console.WriteLine("Veuillez saisir une valeur pour ce champ");
    var value = Console.ReadLine();
    endPoint.Update(address, paramId, value);
}
