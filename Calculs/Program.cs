﻿using System;
using System.Diagnostics.Eventing.Reader;

namespace Calculs
{
    /// <summary>
    /// Application Calculs : addition ou multiplication de 2 nombres
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // variables 
            Random rand = new Random(); // outil de génération de nombre aléatoire
            int val1, val2; // mémorisation de nombres aléatoires
            int solution; // calcul de la solution
            int reponse; // saisie de la réponse de l'utilisateur
            int choix; // saisie du choix de l'utilisateur
            val1 = rand.Next(1, 10);
            val2 = rand.Next(1, 10);

            // boucle sur le menu
            choix = 1;
            while (choix != 0)
            {
                try
                {
                    // affiche le menu et saisi le choix
                    Console.WriteLine("Addition ....................... 1");
                    Console.WriteLine("Multiplication ................. 2");
                    Console.WriteLine("Quitter ........................ 0");
                    Console.Write("Choix :                          ");
                    choix = int.Parse(Console.ReadLine());
                    // traitement des choix
                    if (choix != 0)
                    {
                        try
                        {
                            if (choix == 1)
                            {
                                // saisie de la réponse
                                Console.Write(val1 + " + " + val2 + " = ");
                                reponse = int.Parse(Console.ReadLine());
                                // comparaison avec la bonne réponse
                                solution = val1 + val2;
                                if (reponse == solution)
                                {
                                    Console.WriteLine("Bravo !");
                                }
                                else
                                {
                                    Console.WriteLine("Faux : " + val1 + " + " + val2 + " = " + solution);
                                }
                            }
                            if (choix == 2)
                            {
                                // saisie de la réponse
                                Console.Write(val1 + " x " + val2 + " = ");
                                reponse = int.Parse(Console.ReadLine());
                                // comparaison avec la bonne réponse
                                solution = val1 * val2;
                                if (reponse == solution)
                                {
                                    Console.WriteLine("Bravo !");
                                }
                                else
                                {
                                    Console.WriteLine("Faux : " + val1 + " x " + val2 + " = " + solution);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Erreur de saisie");
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Erreur de saisie");
                        }

                    }
                }
                catch
                {
                    Console.WriteLine("Erreur de saisie");
                }
                }
            

        }
    }
}
