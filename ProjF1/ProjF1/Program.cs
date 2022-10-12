using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System;
using System.Data.Entity;

namespace ProjF1
{
    internal class Program
    {
        static void Main(string[] args) {

            BaseContext context = new BaseContext();
            //Equipe e = new Equipe() { Nome = "Ferrari", UltimoAnoCampeao = 2017 };
            //context.Equipes.Add(e);
            //context.SaveChanges();

            //var equipes = context.Equipes.ToList();

            //foreach (var item in equipes) {
            //    Console.WriteLine(item.ToString());
            //}
            //Console.ReadKey();

            //string n = Console.ReadLine();

            //var e = new Equipe();

            //foreach (var item in equipes) {
            //    if (n == item.Nome)
            //        e = item;
            //}
            //Carro c = new Carro() { Nome = "Baratex F1", Equipe = e };
            //context.Carros.Add(c);
            //context.SaveChanges();

     
            var carros = new BaseContext().Carros.Include(item => item.Equipe);
            foreach (var item in carros) {
                Console.WriteLine("\n" + item.ToString());
            }

            Console.ReadKey();
        }
    }
}
