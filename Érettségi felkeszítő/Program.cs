using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //A fájlkezeléshez kell

namespace Érettségi_felkeszítő
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Változó típusok
            int x = 2; //Egész szám
            x++; // x = x + 1
            x--; // x = x - 1
            x += 3; // x = x + 3
            x -= 3; // x = x - 3

            double y = 3.14; //Tört
            char z = 'a'; //Karakter
            String a = "Alma"; //Szöveg
            a += "beka"; // "Alma" + "beka" = "Almabeka"
            a += z;  // "Almabeka" + 'a' = "Almabekaa"

            int[] tomb = new int[10]; //10 elemű tömb
            List<int> list = new List<int>(); //Lista

            int tomb1 = tomb[0]; //tomb 1. eleme
            char alma1 = a[0]; //String 1. eleme

            Console.WriteLine("alma"); //Kiírja azt hogy alma
            
            String s = Console.ReadLine(); //Bekér egy szöveget és elmenti az s változóba
            int szam = Convert.ToInt32(Console.ReadLine()); //Bekér egy számot
            
            StreamWriter sw = new StreamWriter("file.txt");  //Megnyitjuk a file.txt-t íráshoz
            sw.WriteLine("Egy sor"); //Beleír egy sort 
            sw.Close(); //Elmenti, majd bezárja a file.txt-t

            StreamReader sr = new StreamReader("file.txt"); //Megnyitja a file.txt-t olvasáshoz
            String sor = sr.ReadLine(); //Kiolvassuk az első sorát
            sr.Close(); //Bezárjuk a file.txt-t



            //Ciklus ami 10szer fut le
            for (int i = 0; i < 10; i++)
            {

            }

            //Ciklus ami addig fut amíg az i2 nem egyenlő 3-al
            int i2 = 0;
            while (i2!=3)
            {
                i2++;
            }

            //Ciklus ami egyszer mindenképp lefut, majd minden futás végén megnézi, hogy az i2 egyenlő e -3-al. Ha igen kilép
            do
            {
                i2--;
            } while (i2!=-3);


            Random random = new Random();  //Random változó


            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = random.Next(0, 11);  //tömb elemeinek feltöltése 0-tól 10-ig random egeész számokkal
                list.Add(random.Next(-3, 101)); //Adjunk a listához -3 és 100 közötti számokat
            }

            list.RemoveAt(2); //Töröljük a lista 3. elemét


            //Legnagyobb/legkisebb elem kiválasztása
            int max=tomb[0];
            int min=tomb[0];
            for(int i=0;i<tomb.Length;i++){
                if(max<tomb[i]){
                    max=tomb[i];
                }
                if(min>tomb[i]){
                    min=tomb[i];
                }
            }



            //Sorbarendezés növekvő sorrendbe
            for (int i = 0; i < tomb.Length; i++)
            {
                for (int d = i; d < tomb.Length; d++)
                {
                    if (tomb[i] > tomb[d])
                    {
                        int buff = tomb[i];
                        tomb[i] = tomb[d];
                        tomb[d] = buff;
                    }
                }
            }

            //Írjuk ki a tömböt
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
            }



            //Jó ha tudod, de érettségin csak vész esetben használd!!
            list.Sort();
            list.Reverse();
            list.Max();
            list.Min();
            tomb.Max();
            tomb.Min();


            //Várjunk egy billentyű lemonyásra a program kilépéséhez
            Console.ReadKey();
        }
    }
}
