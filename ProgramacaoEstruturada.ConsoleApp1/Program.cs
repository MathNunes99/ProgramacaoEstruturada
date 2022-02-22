using System;

//Desenvolver um algoritmo que dados 10 valores inteiros permita:

//• Encontrar o Maior Valor da sequência - OK
//• Encontrar o Menor Valor da sequência - OK
//• Encontrar o Valor Médio da sequência - OK
//• Encontrar os 3 maiores valores da sequência - OK
//• Encontrar os valores negativos da sequência - OK
//• Mostrar na Tela os valores da sequência - OK
//• Remover um item da sequência - OK

//Critérios de Aceite:

//• Para obter o Maior valor utilize o modificador de parâmetro: ref
//• Para obter o Menor valor utilize o modificador de parâmetro: out

namespace ProgramacaoEstruturada.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApresentaçãoDoPrograma();

            int[] EntradaDeValores = EntradaDaSequencia();

            MaiorValorDaSequencia(EntradaDeValores);

            MenorValorDaSequencia(EntradaDeValores);

            ValorMédioDaSequencia(EntradaDeValores);

            TresMaioresValores(EntradaDeValores);

            TresMenoresValores(EntradaDeValores);

            ValoresQueEntraram(EntradaDeValores, "Os valores da Sequencia são: ");

            RemoveUmNumeroDaSequencia(EntradaDeValores);
        }

        #region

        //Apresentação
        static void ApresentaçãoDoPrograma()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Bem-vindo a programação estruturada");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Insira 10 valores quaisquer para ter o resultado");
            Console.WriteLine();
            Console.WriteLine("Aperte ENTER para começar!");
            Console.ReadLine();
            Console.Clear();
        }

        //Entrada
        static int[] EntradaDaSequencia()
        {
            int[] EntradaDeValores = new int[10];
            for (int i = 1; i <= 10; i++)
            {

                Console.WriteLine("Escreva o " + i + " valor da sequência");
                string TesteDeEntrada = Console.ReadLine();
                //TESTE DE ENTRADA PARA NUMERO INTEIRO
                if (int.TryParse(TesteDeEntrada, out EntradaDeValores[i - 1])) 
                {

                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Erro de Entrada!");
                    Console.WriteLine("Escreva um Numero inteiro!");
                    Console.WriteLine("aperte ENTER para prosseguir.");
                    Console.ReadLine();
                    Console.Clear();
                    i--;
                }
                
            }            

            return EntradaDeValores;
        }

        //Valor Maximo
        static void MaiorValorDaSequencia(int[] EntradaDeValores)
        {
            //Ordenar Array
            Array.Sort(EntradaDeValores);

            int ValorMaximo = EntradaDeValores[EntradaDeValores.Length-1];
            
            Console.Clear();
            Console.WriteLine("O maior valor é: " + ValorMaximo);                        
        }

        //Valor Minimo      
        static void MenorValorDaSequencia(int[] EntradaDeValores)
        {
            int ValorMinimo = EntradaDeValores[0];           
            Console.WriteLine("O menor valor é: " + ValorMinimo);                               
        }

        //Valor Médio
        static void ValorMédioDaSequencia(int[] EntradaDeValores)
        {
            
            decimal ValorMedio = 0;
            for (int i = 0; i < 10; i++)
            {
                ValorMedio = ValorMedio + EntradaDeValores[i];
            }
            ValorMedio = ValorMedio / EntradaDeValores.Length;
            Console.WriteLine("O valor médio é: " + ValorMedio);           
        }

        //Tres Maiores
        static void TresMaioresValores(int[] EntradaDeValores)
        {
            int[] TresMaiores = new int[3];
            
            for (int i = 7; i < 10; i++)
            {
                TresMaiores[i-7] = EntradaDeValores[i];
            }
            Console.WriteLine("Os tres maiores valores são:");
            for (int i = 2; i >= 0; i--)
            {
                Console.WriteLine(TresMaiores[i]);
            }           
        }

        //Tres Menores
        static void TresMenoresValores(int[] EntradaDeValores)
        {
            int[] TresMenores = new int[3];

            for (int i = 0; i < 3; i++)
            {
                TresMenores[i] = EntradaDeValores[i];
            }
            Console.WriteLine("Os tres menores valores são:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(TresMenores[i]);
            }            
            Console.ReadLine();
            
        }

        //Tabela de Entrada
        static void ValoresQueEntraram(int[] EntradaDeValores, string mensagem)
        {
            //"Os valores da Sequencia são: "
            Console.Clear();
            Console.WriteLine(mensagem);
            for (int i = 0; i < EntradaDeValores.Length; i++)
            {                
                    Console.WriteLine(EntradaDeValores[i]);               
            }                                   
        }

        //Remover Numero da Tabela
        static void RemoveUmNumeroDaSequencia(int[] EntradaDeValores)
        {
            
            Console.WriteLine();
            Console.WriteLine("Escreva o valor que deseja retirar da sequencia");
            int RetirarDaSequencia = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("O valor que foi Retirado é o " + RetirarDaSequencia);
            Console.WriteLine("A nova tabela é:");
            int contadordeRetirada = 0;
            int novaArrayContador = 0;
            for (int i = 0; i < 10; i++)
            {
                if (RetirarDaSequencia == EntradaDeValores[i])
                {
                    continue;                    
                }
                else
                {                   
                    contadordeRetirada++;
                }
                
            }
            int[] NovaTabela = new int[contadordeRetirada];

            for (int i = 0; i<10; i++)
            {
                if (RetirarDaSequencia == EntradaDeValores[i])
                {
                    novaArrayContador++;
                    continue;
                }
                else
                {
                    NovaTabela[i-novaArrayContador] = EntradaDeValores[i];
                }
                
            }

            for (int i = 0;i< contadordeRetirada; i++)
            {
                Console.WriteLine(NovaTabela[i]);
            }
            Console.ReadLine();
        }

        #endregion
    }
}
