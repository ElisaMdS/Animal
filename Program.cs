using System;
using System.Text;

class MainClass
{
    public static void Main(string[] args)
    {
        String PrimeiraPalavra; //declare as suas variaveis
        String SegundaPalavra;
        String TerceiraPalavra;

        PrimeiraPalavra = Console.ReadLine(); //insira suas variaveis
        SegundaPalavra = Console.ReadLine();
        TerceiraPalavra = Console.ReadLine();

        if ((PrimeiraPalavra == "vertebrado") && (SegundaPalavra == "ave") && (TerceiraPalavra == "carnivoro"))
        {
            //complete o desafio
            Console.WriteLine("aguia\n");
        }

        if ((PrimeiraPalavra == "vertebrado") && (SegundaPalavra == "ave") && (TerceiraPalavra == "onivoro"))
        {
            //complete o desafio
            Console.WriteLine("pomba\n");
        }

        if ((PrimeiraPalavra == "vertebrado") && (SegundaPalavra == "mamifero") && (TerceiraPalavra == "onivoro"))
        {
            //complete o desafio
            Console.WriteLine("homem\n");
        }

        if ((PrimeiraPalavra == "vertebrado") && (SegundaPalavra == "mamifero") && (TerceiraPalavra == "herbivoro"))
        {
            //complete o desafio
            Console.WriteLine("vaca\n");
        }

        if ((PrimeiraPalavra == "invertebrado") && (SegundaPalavra == "inseto") && (TerceiraPalavra == "hematofago"))
        {
            //complete o desafio
            Console.WriteLine("pulga\n");
        }

        if ((PrimeiraPalavra == "invertebrado") && (SegundaPalavra == "inseto") && (TerceiraPalavra == "herbivoro"))
        {
            //complete o desafio
            Console.WriteLine("lagarta\n");
        }

        if ((PrimeiraPalavra == "invertebrado") && (SegundaPalavra == "anelideo") && (TerceiraPalavra == "hematofago"))
        {
            Console.WriteLine("sanguessuga\n");
        }

        if ((PrimeiraPalavra == "invertebrado") && (SegundaPalavra == "anelideo") && (TerceiraPalavra == "onivoro"))
        {
            Console.WriteLine("minhoca\n");
        }
    }
}