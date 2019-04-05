using System;

namespace Ex10Dados
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Exibindo características");

            int homens = 0;
            int mulheres = 0;
            float idadeH = 0;
            float idadeM = 0;
            float pesoH = 0; 
            float pesoM = 0;
            string sexo = "";
            
            for (int i = 0; i < 10; i++)
            {
                do{ 
                    Console.WriteLine("Digite seu sexo (M ou F)");
                    sexo = Console.ReadLine().ToUpper();
                    if (sexo !=("M") && sexo != ("F")){
                        Console.WriteLine("Valor inválido");
                    }

                } while (!sexo.Equals("M")&&(!sexo.Equals("F")));
 
                Console.WriteLine("Digite sua idade");
                int idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite seu peso, em kg");
                float peso = float.Parse(Console.ReadLine());

                if (sexo.Equals("M")){
                    homens++;
                    idadeH += idade;
                    pesoM += peso;
                }else{
                    mulheres++;
                    idadeM += idade;
                    pesoM += peso;
                }
            }//fim for
            
            if (homens != 0){
                float mediaIdadeH = idadeH/homens;
                float mediaPesoH = pesoH/homens;
                Console.WriteLine("São homenes:{0}", homens);
                Console.WriteLine("Média de idade dos homens:{0}", mediaIdadeH);
                Console.WriteLine("Média de peso dos homens:{0}", mediaPesoH);
            }else{
                Console.WriteLine("Nenhum homem cadastrado");
            }

            if (mulheres != 0)
            {
                float mediaIdadeM = idadeM/mulheres;
                float mediaPesoM = pesoM/mulheres;
                Console.WriteLine("São mulheres:{0}", mulheres);      
                Console.WriteLine("Média de idade das mulheres:{0}", mediaIdadeM);
                Console.WriteLine("Média de peso das mulheres:{0}", mediaPesoM);   
            }else{
                Console.WriteLine("Nenhuma mulher cadastrada");
            }
        }
    }
}
