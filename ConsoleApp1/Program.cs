using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        
        for(int i = 1;i<=100;i++){                                         //FizzBuzz
            if(i%3==0 && i%5==0){
                Console.WriteLine("FizzBuzz");
            }
            else if(i%3==0){
                Console.WriteLine("Fizz");
            }
            else if(i%5==0){
                Console.WriteLine("Buzz");
            }
            else{
                Console.WriteLine(i);
            }
        }
        
        /*Klasa os = new Klasa();
        Klasa os2 = new Klasa();
        os.imie="Andrzej";
        os.nazwisko="Kowalski";
        os.UstawLata(19);
        os2.imie="Michał";
        os2.nazwisko="Góra";
        os2.UstawLata(20);
        Console.WriteLine(os.imie+" "+os.nazwisko+" lat "+os.GetLata());
        Console.Write(os2.imie+" "+os2.nazwisko+" lat "+os2.GetLata());*/
        /*string[] a = {"mango", "papaja", "kokos"};                        //tablice
        for(int i = 0; i<a.Length; i++){
            Console.WriteLine(a[i]);
        }*/
        /*int a = 1;                                                       //liczby do stop na 0
        int s = 0;
        int m = 0;
        while(a != 0){
        Console.WriteLine("Podaj liczbę");
        a = int.Parse(Console.ReadLine());
        s = s + a;
        if(a>m){
            m = a;
        }
        }
        Console.WriteLine("Suma liczb to "+s);
        Console.WriteLine("Najwieksza liczba to "+m);8/
        /*Console.WriteLine("Wpisz swoją datę(dd mm rrrr):");               //ile dni temu sie urodziles
        int dzien = int.Parse(Console.ReadLine());
        int miesiac = int.Parse(Console.ReadLine());
        int rok = int.Parse(Console.ReadLine());
        DateTime atkualna = DateTime.Now;
        DateTime data = new DateTime(rok, miesiac, dzien);
        TimeSpan wyn = (atkualna - data);
        Console.Write("Urodziles sie "+wyn.TotalDays+" dni temu");*/
        /*Console.WriteLine("Podaj rozmiar choinki: ");                     //choinka
        int q = Convert.ToInt32(Console.ReadLine());
        int t = 0;
        int r = 1;
        for(int i = 0; i<q; i++){
            
            for(int n = t; n<q-1; n++){
            Console.Write(" ");
            
            }
            for(int j = 0; j<r; j++){
        Console.Write("#");
            }
        Console.Write("\n");
        t+=1;
        r+=2;
        }
        for(int i = 1;i < q; i++){
            Console.Write(" ");
        }
        Console.WriteLine("#");*/
        
    }
}