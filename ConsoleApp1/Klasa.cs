using System;

namespace ConsoleApp1;

public class Klasa
{
    public string imie;
    public string nazwisko;
    private int lata;

    public void UstawLata(int rok){
        if(rok<18){
            Console.Write("niepelnoletni ");
            
        }
        else{
        lata = rok;
        }
    }
    public int GetLata(){
        return lata;
    }
}
