using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_Nr_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1 uzduotis
            //suma
            Console.WriteLine(7 + 2);
            //skirtumas
            Console.WriteLine(7 - 2);
            //sandauga
            Console.WriteLine(7 * 2);
            //dalyba
            Console.WriteLine(7.0 / 2);
            Console.WriteLine();
            //2 uzduotis
            int skaicius = 4;
            Console.WriteLine();
            // kvadratas 
            Console.WriteLine(skaicius * skaicius);
            // kubas
            Console.WriteLine(skaicius * skaicius * skaicius);
            //3 uzduotis
            Console.WriteLine(5 * 7 * 2);
            //5 uzduotis
            //KAZKO TRUKSTA, NEISSIAISKINAU, KO, kazkas su rezultatu blogai
            Console.WriteLine("Daugybos lentelė iš skaičiaus 5");
            int daugiklis = 0;
            int rezultatas = 5 * daugiklis;

            Console.WriteLine($"5 * {daugiklis++} = {rezultatas}");
            Console.WriteLine($"5 * {daugiklis++} = {rezultatas}");
            Console.WriteLine($"5 * {daugiklis++} = {rezultatas}");
            Console.WriteLine($"5 * {daugiklis++} = {rezultatas}");
            Console.WriteLine($"5 * {daugiklis++} = {rezultatas}");
            Console.WriteLine($"5 * {daugiklis++} = {rezultatas}");
            Console.WriteLine($"5 * {daugiklis++} = {rezultatas}");
            Console.WriteLine($"5 * {daugiklis++} = {rezultatas}");
            Console.WriteLine($"5 * {daugiklis++} = {rezultatas}");
            Console.WriteLine($"5 * {daugiklis++} = {rezultatas}");
            Console.WriteLine();


            //Susikurkite sveikojo skaičiaus kintamąjį su dviženklio skaičiaus reikšme. Išveskite į ekraną šio skaičiaus skaitmenų sandaugą.
            // ChatGPT kodas
            int sveikas = 42;
            int desimtys = sveikas / 10; // išskiriame dešimtis
            int vienetai = sveikas % 10; // išskiriame vienetus
            int sandauga = desimtys * vienetai; // skaitmenų sandauga
            Console.WriteLine($"Skaičiaus {sveikas} skaitmenų sandauga: {sandauga}");
            Console.WriteLine();

            //Liepkite vartotojui įvesti savo vardą ir amžių.Į ekraną išveskite: “Jūsų vardas { vardas}, o amžius { amžius}.”
            Console.Write("Įveskite savo vardą: ");
            string vardas = Console.ReadLine();
            Console.Write("Įveskite savo amžių: ");
            double amzius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Jūsų vardas {vardas}, o amžius {amzius}");
            Console.WriteLine();

            //Liepkite vartotojui įvesti bet kokį simbolį. Atspausdinkite 3x3 kvadratą iš to simbolio.
            //Console.Write("Įveskite simbolį: ");
            //int simbolis = Console.Read();  
            //char simbolisSi = Convert.ToChar(simbolis);
            //Console.Write(simbolisSi);
            //Console.Write(simbolisSi);
            //Console.WriteLine(simbolisSi);
           // Console.Write(simbolisSi);
            //Console.Write(simbolisSi);
            //Console.WriteLine(simbolisSi); 
           // Console.Write(simbolisSi);
           // Console.Write(simbolisSi);
           // Console.Write(simbolisSi);
           // Console.WriteLine();
            
            //Liepkite vartotojui įvesti bet kokį skaičių. Išveskite į ekraną šio skaičiaus kvadratą.

            //Liepkite vartotojui įvesti tris skaičius.Išveskite visų šių skaičių sumą, skirtumą, sandaugą ir dalmenį, nurodant atliekamus veiksmus ir šių skaičių reikšmes ekrane. Pvz.:
            //5 + 3 + 8 = 16


            //Liepkite vartotojui įvesti tris skaičius. Į ekraną išveskite šiuos skaičius ir jų vidurkį. Pvz.: Įvestų skaičių 4, 5, 8 vidurkis: 5,7.
            int trys = 3;
            Console.Write("Įveskite skaičių: ");
            Double numeris1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Įveskite dar vieną skaičių: ");
            Double numeris2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Įveskite dar vieną skaičių: ");
            Double numeris3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Jūsų įvestų skaičių vidurkis yra: {(numeris1 + numeris2 + numeris3) / trys}");
            Console.WriteLine();
            //Liepkite įvesti tris skaičius. Išveskite įvestus skaičius, jų kvadratus, juos pakeltus trečiuoju laipsniu, taip pat tuos skaičius, padalintus iš dviejų.

            //Liepkite vartotojui įvesti savo amžių.Jei amžius yra 18 arba daugiau, tuomet į ekraną išveskite, kad “jūs galite balsuoti”.
            Console.Write("Įveskite savo amžių: ");
            int years = Convert.ToInt32(Console.Read());
            if (years <= 18)
            { 
                Console.WriteLine("Jūs galite balsuoti");
            }
            else Console.WriteLine("Jūs neturite teisės balsuoti");
            Console.WriteLine();

            //Liepkite vartotojui įvesti bet kokį skaičių. Parašykite šias atskiras if sąlygas:
            //Patikrinti, ar skaičius neigiamas, jei taip -aprėkti vartotoją:)
            //Patikrinti, ar skaičius teigiamas, jei taip -pasveikinti vartotoją;
            //Patikrinti, ar skaičius lyginis, jei taip -išvesti “taip, skaičius yra lyginis”;
            //Patikrinti, ar skaičius dalinasi iš 4, jei taip -išvesti “taip, dalinasi iš 4”;
            //Patikrinti, ar skaičius yra didesnis nei 10, jei taip -išvesti “taip, skaičius yra didesnis už 10”.
            
            
            
            //Liepkite vartotojui įvesti penkis  du savo pažymius, raskite šių pažymių vidurkį, patikrinkite, ar vidurkis yra lygus arba didesnis už 5, jei taip, išveskite “Valio!!!”.
            
            
            //  Liepkite įvesti skaičių.
            //Jei skaičius lyginis, tuomet išveskite šį skaičių bei jo penktą laipsnį.
            //Jei skaičius nesidalina iš 4, tuomet liepkite įvesti antrąjį skaičių.Išveskite abiejų skaičių sumą ir sandaugą.

            //Liepkite vartotojui įvesti tris skaičius, parašyti šią patikrinimo sąlygą, naudojant else if dalis:
            //ar pirmas skaičius didesnis už antrą;
            // ar antras skaičius didesnis už trečią;
            // ar trečias skaičius didesnis už pirmą;
            // ar pirmi du skaičiai lygūs;
            
            
            
            // Liepkite vartotojui įvesti šios dienos oro temperatūrą, atlikite šiuos patikrinimus:
            // ar temperatūra< 0 - išvesti “žiauriai šalta”;
            //  ar temperatūra< 10 - išvesti “labai šalta”;
            //  ar temperatūra< 20 - išvesti “šalta”;
            //  ar temperatūra< 30 - išvesti “normali temperatūra”;
            //  ar temperatūra< 40 - išvesti “karšta”;
            //  ar temperatūra >= 40 - išvesti “visiškai degina”;

        }
    }



      
    
}
