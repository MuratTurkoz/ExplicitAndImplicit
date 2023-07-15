using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitAndImplicit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Basit örnekler
            int sayi = 123456;
            byte value = 12;
            sayi = value;//Implicit Örtük atama
            sayi = (int)value;//Explicit Açık Atama
            //2 adet sınıfımız var Dog ve Bird Bu sınıfların içinde Implicit ve Explicit Methodlar tanımladım
            //Bir Köpek Oluşturalım
            Dog dog = new Dog()
            {
                Name = "Kamil",
                Genus = "Toy Poodle",
                Id = 9
            };
            //Bir kuş Oluşturalım
            Bird bird = new Bird()
            {
                Name = "Boncuk",
                Genus = "Sturnidae",
                Id = 1,
            };

            /*dog = bird;*/  //Doğrudan atama yapılamaz Referans tiplerde atama olmaz.Ancak bu durumlarda örtük(Implicit) ya da açıktan(Explicit) atama yapılabilir.

            //Hadi Implicit Operator kullanalım=>Lütfen Bird sınıfının içene bakın..
            bird = dog;//Artık köpeğimiz kuş oldu:D

            //Hadi Explicit Operator kullanalım=>Lütfen Dog sınıfının içene bakın..
            dog = (Dog)bird;//Artık kuşumuz köpek oldu:D
        }
    }
}
