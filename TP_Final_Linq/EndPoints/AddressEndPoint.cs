using Microsoft.Extensions.Logging.Abstractions;
using TP_Final_Linq.DAL;

namespace TP_Final_Linq.EndPoints
{
    public class AddressEndPoint
    {
        private EatDomicileDbContext? Context { get; set; }
        public AddressEndPoint(EatDomicileDbContext context)
        {
            this.Context = context;
        }
        public void GetAll()
        {
            try
            {
                var adresses = this.Context.Adresses;

                foreach (var adresse in adresses)
                {
                    Console.WriteLine(
                        $"ID : {adresse.AdresseId} - {adresse.Street} | {adresse.Zip} | {adresse.City} | {adresse.State} | {adresse.Country}"
                        );

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Les adresses n'ont pas pu être récupérées");
            }
        }
        public Adress? GetOne(int id)
        {
            try
            {
                var adress = this.Context.Adresses.FirstOrDefault(a => a.AdresseId == id);
                if (adress != null)
                {
                    Console.WriteLine($"1 - Rue : {adress.Street}");
                    Console.WriteLine($"2 - Ville : {adress.City}");
                    Console.WriteLine($"3 - Département : {adress.State}");
                    Console.WriteLine($"4 - Code Postal : {adress.Zip}");
                    Console.WriteLine($"5 - Pays : {adress.Country}");
                    return adress;
                }
                else
                {
                    Console.WriteLine("Il n'existe pas d'adresse pour cet ID");
                    return null;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("L'adresse sélectionnée n'a pas pu être récupérée");
                return null;
            }
        }

        public void Create(string street, string city, string state, string zip, string country)
        {
            try
            {
                var address = new Adress
                {
                    Street = street,
                    City = city,
                    Zip = zip,
                    State = state,
                    Country = country
                };
                this.Context.Adresses.Add(address);
                this.Context.SaveChanges();
                Console.WriteLine("L'adresse a bien été créée");
            }
            catch (Exception ex)
            {
                Console.WriteLine("L'adresse n'a pas pu être créée");
            }
        }

        public void Update(Adress address, int param, string value)
        {
            switch (param)
            {
                case 1: address.Street = value; break;
                case 2: address.City = value; break;
                case 3: address.State = value; break;
                case 4: address.Zip = value; break;
                case 5: address.Country = value; break;
                default:
                    break;
            }

            try
            {
                this.Context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("L'adresse n'a pas pu être modifiée");
            }
        }

        public void Delete(Adress address)
        {
            try
            {
                this.Context.Remove(address);
                this.Context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("L'adresse n'a pas pu être supprimée");
            }
        }

    }
}
