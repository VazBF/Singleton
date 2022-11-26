using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Email
    {
        private Email() { } //construtor privado

        private static Email instancia; //atributo para armazenamento da instância

        public static Email GetInstancia() //método pra acessar o construtor
        {
            if(instancia == null) //verifica se a instância já foi inicializada
            {
                instancia = new Email(); // se ainda não, inicia 
            }
            return instancia; //retorna a instância
        }
    }
}
