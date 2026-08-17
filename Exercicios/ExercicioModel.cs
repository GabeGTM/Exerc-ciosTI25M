using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class ExercicioModel
    {
        //Área para declaração de variáveis globais
        private int num1;
        private int num2;
        private double num3;
        private double num4;
        private int resultado;

        //Método Construtor: Instância as variáveis na memória
        public ExercicioModel()
        {
            SetNum1(0);
            SetNum2(0);
            SetResultado(0);   
        }//fim do métododo construtor

        public ExercicioModel(int num1, int num2)
        {
            SetNum1(num1);
            SetNum2(num2);
            SetResultado(0);
        }//fim do construtor

        public ExercicioModel(double num1,double num2)
        {
            SetNum3(num1);
            SetNum4(num2);
        }//fim do construtor

        //Método GETS E SETS
        //GET = Pegar, Obter, Consultar
        //SET = Alterar, Modificar, Configurar

        public int GetNum1() 
        { 
            return this.num1;
        }//fim do GetNum1

        public void SetNum1(int num1)
        {
            this.num1 = num1;
        }//fim do SetNum1

        public int GetNum2()
        {
            return this.num2;
        }//fim do GetNum2

        public void SetNum2(int num2) 
        {
            this.num2 = num2;
        }//fim do SetNum2

        public int GetResultado()
        {
            return this.resultado;
        }//fim do método GetResultado

        public void SetResultado(int resultado)
        {
            this.resultado = resultado;
        }//fim do método SetResultado

        public double GetNum3()
        {
            return this.num3;
        }//Fim do GetNum3

        public void SetNum3(double num3)
        {
            this.num3 = num3;
        }//fim do SetNum3

        public double GetNum4()
        {
            return this.num4;
        }//fim do GetNum4

        public void SetNum4(double num4)
        {
            this.num4 = num4;
        }//fim do SetNum4

        public int Somar()
        {
            return this.num1 + this.num2;    
        }//fim do método soma

        public int Subtrair()
        {
            SetResultado(GetNum1() - GetNum2());
            return GetResultado();
        }//fim do método subtrair

        public int Multiplicar()
        {
            SetResultado(GetNum1() * GetNum2());
            return GetResultado();
        }//fim do multiplicar

        public double Dividir()
        {
            if (GetNum2() <= 0)
            {
                return -1;
            }
            else
            {
                SetResultado(GetNum1() / GetNum2());
                return GetResultado();
            }//fim do if
        }//fim do dividir


        public double Potencia(double bas, double expoente)
        {
            return Math.Pow(bas, expoente);
        }//fim da potencia

        public double Raiz(double num)
        {
            return Math.Sqrt(num);
        }//Fim da raiz

        public double Potencia()
        {
            return Math.Pow(GetNum3(), GetNum4());
        }//fimda potencia sem parâmetros

        public double RaizNum3()
        {
            return Math.Sqrt(GetNum3());
        }//fim da raiz Num3

        public double RaizNum4()
        {
            return Math.Sqrt(GetNum4());
        }//fim da raiz Num4

        //Leia um número inteiro e retornar todos os múltiplos menores que 100
        public string multiplo(int numero)
        {
            //contador
            int i = 1; //Criando contador e definindo o ponto de partida
            string resultado = "";
            while(i < numero)
            {
                if(numero % i == 0)
                {
                    resultado += i + "\n";
                }
                //Rodar o meu contador
                i++;
            }//fim do while
            return resultado;
        }
        public string multiploFor(int numero)
        {
            string resultado = "";
            for (int i = 1;  i < 100; i++)
            {
                if (numero % i == 0)
                {
                    resultado += i + "\n";
                }//fim if
            }//fim do for
            return resultado;
        }//fim do metodo

        public bool EhPalindromo(string palin)
        {
            int fim = palin.Length - 1;//Meço o tamanho de um conjunto de caracteres
            int inicio = 0;

            while (inicio < fim)
            {
                if (palin.Substring(inicio, 1) != palin.Substring(fim, 1))
                {
                    return false;
                }
                inicio++;
                fim--;
            }//fim do while
            return true;
        }//fim do método

        public void ContarParImpar()
        {
            int contarPar = 0;
            int contarImpar = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + 1 + "º número: ");
                int num = Convert.ToInt32(Console.ReadLine());
                //Comparações
                if (num % 2 == 0)
                {
                    contarPar++;
                }
                else
                {
                    contarImpar++;
                }
            }//fim do for
            Console.WriteLine("A quantidade de pares é: " + contarPar + "\nA quantidade de ímpares é: " + contarImpar);
        }//fim do parImpar

        public string Exer01(int ano)
        {
            if(ano % 4 == 0)
            {
                return ano + " É Bissexto;";  
            }
            else
            {
                return ano + " Não é biSSexto";
            }
        }//fim Exercicio01

        public string Exer02(int num1)
        {
            if (num1 >= 100 && num1 <= 200)
            {
                return num1 + " Está entre 100 e 200";
            }
            else
            {
                return num1 + " Não está entre 100 e 200";
            }
        }//fim Execicio02

        public string Exer03(int num1)
        {
            if (num1 >= 18)
            {
                return " Você pode votar";
            }
            else
            {
                return " Você não pode votar";
            }
        }//fim Exercicio03

        public string Exer04(int num1, int num2, int num3)
        {
            if ((num3 >= num1) && (num3 <= num2))
            {
                return "O número " + num3 + " está dentro do Intervalo";
            }
            else
            {
                return "O número " + num3 + " não está dentro do intervalo";
            }
        }//fim exercicio04

        public string Exer05()
        {
            int num1, num2;
            bool achou = false;

            Console.WriteLine("Informe o número que deseja procurar: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                Console.Write((i + 1) + "º Numero: ");
                num2 = Convert.ToInt32(Console.ReadLine());
            
            if(num1 == num2)
                {
                    achou = true;
                }  
            }//fim for

            if (achou)
            {
                return ("" + num1 + "" + " Está dentro dos valores");
            }
            else
            {
                return ("" + num1 + "" + " Não está dentro do valores");
            }//fim if

        }//fim Exercicio05

        public string Exer06()
        {
            int num1, num2, num3;


            Console.WriteLine("Informe o Primeiro lado: ");
            num1 = Convert.ToInt32((Console.ReadLine()));

            while (num1 <= 0)
            {

                Console.WriteLine("Não existe lado negativo ou zero, digite novamente: ");
                num1= Convert.ToInt32(Console.ReadLine());
            }//fim while 

            Console.WriteLine("Informe o Segundo lado: ");
            num2 = Convert.ToInt32((Console.ReadLine()));

            while (num2 <= 0)
            {
                Console.WriteLine("Não existe lado negativo ou zero, digite novamente: ");
                num2 = Convert.ToInt32(Console.ReadLine());
            }//fim while 

            Console.WriteLine("Informe o Terceiro lado: ");
            num3 = Convert.ToInt32((Console.ReadLine()));

            while (num3 <= 0)
            {
                Console.WriteLine("Não existe lado negativo ou zero, digite novamente: ");
                num3 = Convert.ToInt32(Console.ReadLine());
            }//fim while 

            if ((num1 == num2) && (num1 == num3))
                {
                    return "Triângulo Equilátero";
                }
            else
            {
                if ((num1 != num2) && (num1 != num3) && (num2 != num3))
                {
                    return "Triângulo Escaleno";
                }
                else
                {
                    return "Triângulo Isósceles";
                }//fim if else
            }//fim if else
        }//fim Exercicio06 

        public string Exer07()
        {
            int num;

            Console.WriteLine("Informe um número (1 a 7): ");
            num = Convert.ToInt32(Console.ReadLine());

            while ((num < 1) || (num > 7))
            {
                Console.WriteLine("Informe um número válido (1 a 7): ");
                num = Convert.ToInt32(Console.ReadLine());
            }

            //Verificação dos dias
            if (num == 1)
            {
                return "Domingo";
            }
            else
            {
                if (num == 2)
                {
                    return "Segunda";
                }
                else
                {
                    if (num == 3)
                    {
                        return "Terça";
                    }
                    else
                    {
                        if (num == 4)
                        {
                            return "Quarta";
                        }
                        else
                        {
                            if (num == 5)
                            {
                                return "Quinta";
                            }
                            else
                            {
                                if (num == 6)
                                {
                                    return "Sexta";
                                }
                                else
                                {
                                    return "Sabado";
                                }
                            }
                        }
                    }
                }
            }

        }//fim Exercicio07

        public String Exer08(int senha, int criar)
        {
            if (senha == criar)
            {
                return "Acesso liberado, olá Gabriel";
            }
            else
            {
                return "Acesso negado";
            }//fim se      
        }//fim Exercicio08

        public string Exer09(double num1, double num2)
        {
            if (num1 > num2)
            {
                return (num1 + " é maior que " + num2);
            }
            else
            {
                return (num1 + " é menor que " + num2);
            }
        }//fim Exercicio09

        public string Exer10(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1 + " é maior que " + num2;
            }
            else
            {
                return num1 + " é menor que " + num2;
            }//fim if
        }//fim Exercicio10

        public string Exer11(int n1, int n2, int n3, int n4, int n5)
        {
            int n6 = 0;
            n6 = (n1 + n2 + n3 + n4 + n5) / 5;
            return "A sua média é: " + n6;
        }//fim Exercicio11

        public string Exer12()
        {
            int n1;
            int soma = 0;

            Console.WriteLine("Escreva 0 primeiro número: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            soma = soma + n1;

            while (soma < 100)
            {
                Console.WriteLine("Escreva outro número: ");
                n1 = Convert.ToInt32(Console.ReadLine());
                soma = soma + n1;
            }//fim while
                return "Você chegou em: " + soma;
        }//fim Exercicio12

        public String Exer13(int senha, int criar)
        {
            if (senha.Equals(criar))
            {
                return "Acesso liberado, olá magnata";
            }
            else
            {
                return "Incorreto";
            }//fim se
        }//fim Exercicio13

        public String Exer14(int maior, int menor)
        {
            if (maior > menor)
            {
                return maior + " é maior que " + menor;
            }
            else if (maior < menor)
            {
                return menor + " é menor que " + menor;
            }
            else
            {
                return "";
            }//fim se
        }//fim Exercicio14


        public string Exer15(int idade)
        {
            if (idade < 0) return "Idade inválida";
            if (idade <= 12) return "Criança";
            if (idade <= 18) return "Jovem";
            if (idade <= 60) return "Adulto";
            return "Idoso";
        }//Fim Exercicio15

        public String Exer16(double peso, double altura)
        {
            if (altura <= 0)
            {
                return "Altura inválida";
            }

            double imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                return "Abaixo do peso";
            }
            else if (imc < 25)
            {
                return "Peso normal";
            }
            else if (imc < 30)
            {
                return "Sobrepeso";
            }
            else
            {
                return "Obesidade";
            }
        }//fim Exercicio16


        public string Exer17(double numero)
        {
            if (numero > 0) return "Positivo";
            if (numero < 0) return "Negativo";
            return "Zero";
        }//fim Exercicio17


        public string Exer18(int numero)
        {
            if (numero % 2 == 0)
            {
                return "par";
            }
            else
            {
                return "impar";
            }

        }//fim Exercicio18

        public string Exer19(double n1, double n2, double n3)
        {
            double maior = Math.Max(n1, Math.Max(n2, n3));
            double menor = Math.Min(n1, Math.Min(n2, n3));
            double soma = n1 + n2 + n3;
            double media = soma / 3;
            double potencia = Math.Pow(n1, n2);

            return "Maior: " + maior +
                   "\nMenor: " + menor +
                   "\nSoma: " + soma +
                   "\nMédia: " + media +
                   "\nPotência: " + potencia;
        }//fim Exercicio19


        public string Exer20(int idade)
        {
            if (idade < 6)
            {
                return "Tarifa: R$ 0,00";
            }
            else if (idade <= 17)
            {
                return "Tarifa: R$ 800";
            }
            else if (idade >= 60)
            {
                return "Tarifa: R$ 6000";
            }
            else
            {
                return "Tarifa: R$ 5,00";
            }
        }//fim Exercicio20

        public string rept4(int contar)
        {
            int total = contar.ToString().Length;
            return ("A quatidade é: " + total);
        }//fim Exercicio de repetição04

        public string rept5()
        {
            string senhaCorreta = "123";
            int Tentativas = 3;

            for (int tentativa = 1; tentativa <= Tentativas; tentativa++)
            {
                Console.Write("Digite sua senha: ");
                string senha = Console.ReadLine();

                if (senha == senhaCorreta)
                {
                    return "Acesso permitido";
                }

                if (tentativa < Tentativas)
                {
                    Console.WriteLine("- Senha Incorreta - Tente novamente: ");
                }
            }

            return "Acesso bloqueado";
        }//fim Exercicio de repetição05

        public string rept6()
        {
            int maior = 0;
            int menor = 0;
            int contar = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + 1 + "º idade: ");
                int num = Convert.ToInt32(Console.ReadLine());
                //Comparações
                if (num >= 18)
                {
                    maior = maior + num;
                    contar++;
                }
                else
                {
                    menor = num;
                    menor++;
                }
            }//fim do for
            if (maior == 0)
            {
                return "Não foram digitadas idades maiores ou iguais a 18";
            }
            else
            {
                return ("O resultado da média é: " + maior / contar);
            }
        }//fim Exercicio de repetição06

        public void rept7()
        {
            int num1;
            do
            {
                Console.WriteLine("Digite um número: ");
                num1 = Convert.ToInt32(Console.ReadLine());

            } while (num1 > 0);

            Console.WriteLine("Fim.");
        }//fim Exercicio de repetição07

        public void rept8(int n)
        {
            for (int i = 2;i <= n ;i+=2)
            {
                int quadrado = i * i;
                Console.WriteLine($"{i}² {quadrado}");
            }
         }

    }//fim da classe
}//fim do projeto
    
