using ClassMetotDemo;
public class Program
{
    public static void Main(string[] args)
    {
        MusteriManager musteriManager = new MusteriManager();
        ListeYazdir(musteriManager.GetAll());

        musteriManager.Add(new Musteri(6, "Hale", "Kenanoğlu", "15846849"));
        ListeYazdir(musteriManager.GetAll());

        musteriManager.Delete(5);
        ListeYazdir(musteriManager.GetAll());
    }

    public static void ListeYazdir(List<Musteri> musteriList)
    {
        foreach (var item in musteriList)
        {
            Console.WriteLine(" Id= " + item.Id + " İsim= " + item.Name + " Soyad= " + item.Surname + " Tc= " + item.Tc);
        }
    }
}