using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        private List<Musteri> list;
        public MusteriManager()
        {
            list = new List<Musteri>();
            list.Add(new Musteri(1, "Ecem", "Yıldız", "111122223"));
            list.Add(new Musteri(2, "Salih", "Değirmenci", "116123223"));
            list.Add(new Musteri(3, "Ceyda", "Kasabalı", "111122423"));
            list.Add(new Musteri(4, "Tarık", "Mengüç", "111122253"));
            list.Add(new Musteri(5, "Murat", "Kobra", "111122273"));
        }

        public void Add(Musteri musteri)
        {
            list.Add(musteri);
            Console.WriteLine(musteri.Name + " Eklendi!");
        }

        public List<Musteri> GetAll()
        {
            return list;
        }

        public void Delete(int Id)
        {
            Musteri musteri;
            musteri = list.Find(m => m.Id == Id);
            if (musteri != null)
            {
                list.Remove(musteri);
                Console.WriteLine(musteri.Name + " Silindi!");
            }
            else
            {
                Console.WriteLine("Müşteri Bulunamadı!!!");
            }

        }
    }
}
