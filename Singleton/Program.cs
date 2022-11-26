using Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Progam
    {
        public static void Main(string[] args)
        {
            Email E1 = Email.GetInstancia();
            Email E2 = Email.GetInstancia();

            if (E1 == E2)
            {
                Console.WriteLine("Instancias iguais");
            }
            else
            {
                Console.WriteLine("Instancias Diferentes");
            }
        }
    }
}