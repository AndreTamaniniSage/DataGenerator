

using System;
using System.Linq;
using Bogus;
using Bogus.Extensions.Brazil;

namespace SAGE.BR.HyperCube.data.generator.Utils
{
    public class FakeDataGenerator
    {
        public static string FakeCnpj()
        {
            Faker fake = new Faker("pt_BR"); 

            return fake.Company.Cnpj();

        }

        public static string FakeNomeDaEmpresa()
        {
            Faker fake = new Faker("pt_BR"); 

            return fake.Company.CompanyName();
        }

        public static string FakeCpf()
        {
            Faker fake = new Faker("pt_BR"); 

            return fake.Person.Cpf();
        }

        public static string FakeNomeCompleto()
        {
            Faker fake = new Faker("pt_BR"); 

            return fake.Person.FullName;
        }

        public static string FakeMatricula()
        {
            Random rnd = new Random();

            return rnd.Next().ToString();
        }

        public static string FakeDescricao(int StringLength)
        {
            var chars = "[]{}.|!@#%&abcdefghijklmnopqrstuvxwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, StringLength)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            return result;
        } 
        public static string FakeNis()
        {
             // 9 números aleatórios
            string arNumeros = "";
            var somaJ = 0;
            Random rnd = new Random();
            int[] multiplicadores = new int[] { 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            foreach (int multiplicador in multiplicadores)
            {
                int random = rnd.Next(0, 9);
                arNumeros = arNumeros + random;

                somaJ = somaJ + (random * multiplicador);
            }

            //var somaj2 = ((arNumeros[0] * 3) + (arNumeros[1] * 2) + (arNumeros[2] * 9) + (arNumeros[3] * 8) + (arNumeros[4] * 7) + (arNumeros[5] * 6) + (arNumeros[6] * 5) + (arNumeros[7] * 4) + (arNumeros[8] * 3) + (arNumeros[9] * 2));

            var restoJ = somaJ % 11;
            var digitoVerificador = 11 - restoJ;
            if (digitoVerificador == 10 || digitoVerificador == 11)
                digitoVerificador = 0;

            arNumeros = arNumeros + digitoVerificador;

            return arNumeros;
        }

        public static string FakeRg()
        {
            string arNumeros = "";
            var somaJ = 0;
            Random rnd = new Random();
            int[] multiplicadores = new int[] { 2, 3, 4, 5, 6, 7, 8, 9};

            foreach (int multiplicador in multiplicadores)
            {
                int random = rnd.Next(0, 10);
                arNumeros = arNumeros + random;

                somaJ = somaJ + (random * multiplicador);
            }
           
            int resto = somaJ % 11;
            string DV;

            if (resto == 0)
            {
                DV = "0";
            }
            else if (resto == 1)
            {
                DV = "X";
            }
            else
            {
                DV = (11 - resto).ToString();
            }

            return arNumeros + DV;
        }


    }
}