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
            ExampleOne();
            ExampleTwo();
            ExampleThree();
            Console.ReadLine();
        }
        static void ExampleOne()
        {
            //Basit örnekler 1
            int tamSayi = 123456;
            byte value = 12;
            tamSayi = value;//Implicit Örtük atama
            tamSayi = (int)value;//Explicit Açık Atama
            Console.WriteLine("Örnek 1 => Büyük içine küçük bir değer atama");
            Console.WriteLine(value);
            Console.WriteLine("**********");
        }
        static void ExampleTwo()
        {
            //Basit örnekler 2
            double ondalikliSayi = 123456.445;
            int value2 = 12;
            value2 = (int)ondalikliSayi;//Explicit Açık Atama
            Console.WriteLine("Örnek 2 => Tamsayı içine ondalıklı sayı atama");
            Console.WriteLine(value2);
            Console.WriteLine("**********");
        }
        static void ExampleThree()
        {

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
            Bird bird2 = new Bird()
            {
                Name = "Maviş",
                Genus = "Sturnidae",
                Id = 1111,
            };

            /*dog = bird;*/  //Doğrudan atama yapılamaz Referans tiplerde atama olmaz.Ancak bu durumlarda örtük(Implicit) ya da açıktan(Explicit) atama yapılabilir.
            Console.WriteLine("Örnek 3 => Tamsayı içine ondalıklı sayı atama");
            //Hadi Implicit Operator kullanalım=>Lütfen Bird sınıfının içene bakın..
            bird = dog;//Artık köpeğimiz kuş oldu:D
            Console.WriteLine("Artık Köpeğimiz Bir kuş oldu:>Implicit Atama (Örtük)");
            Console.WriteLine($"Kuş Özellikleri: Id:{bird.Id},Name:{bird.Name},Genus:{bird.Genus},");
            //Hadi Explicit Operator kullanalım=>Lütfen Dog sınıfının içene bakın..
            dog = (Dog)bird2;//Artık kuşumuz köpek oldu:D
            Console.WriteLine("Artık Kuşumuz Bir Köpek oldu:>Explicit Atama (Açık)");
            Console.WriteLine($"Köpek Özellikleri: Id:{dog.Id},Name:{dog.Name},Genus:{dog.Genus},");
        
        }
    }
}
