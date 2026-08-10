using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class ExercicioControl
    {
        ExercicioModel modelo;//Conectando a Classe Model e Control
        private int opcao;

        public ExercicioControl()
        { 
            this.modelo = new ExercicioModel();
            SetOpcao(0);
        }//Contrutor Padrão

        public int GetOpcao()
        { 
            return this.opcao;
        }//fim do getOpcao

        public void SetOpcao(int opcao)
        {
            this.opcao = opcao;
        }

        public void Coletar()
        {
            //Peguei os dois
            Console.Write("Informe o primeiro número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //Vou passar para o construtor com pârametro
            this.modelo = new ExercicioModel(num1, num2);
        }//fim do coletar = Pegar os dois números digitados

        public void ColetarReal()
        {
            //Pegar dois números
            Console.WriteLine("Informe o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            //Chamar o construtor que receba reais
            this.modelo = new ExercicioModel(num1, num2
                );
        }//fim do ColetarReal

        //Mostrar as opções de operaçã na tela
        public void Menu()
        {
            Console.WriteLine("\nEscolha uma das opções abaixo: \n" +
                              "0. Sair\n" +
                              "1. Soma \n" +
                              "2. Subtração \n" +
                              "3. Divisão \n" +
                              "4. Multiplicação\n" +
                              "5. Potência\n" +
                              "6. Potência com Parâmetros\n" +
                              "7. Raiz\n" +
                              "8. Raiz com Parâmetros\n" +
                              "9. Exercicio01\n" +
                              "10. Exercicio02\n" +
                              "11. Exercicio03\n" +
                              "12. Excercico04\n" +
                              "13. Exercicio05\n" +
                              "14. Exercicio06\n" +
                              "15. Exercicio07\n" +
                              "16. Exercicio08\n" +
                              "17. Exercicio09\n" +
                              "18. Exercicio10\n" +
                              "19. Exercicio11\n" +
                              "20. Exercicio12\n" +
                              "21. Exercicio13\n" +
                              "22. Excercico14\n" +
                              "23. Exercicio15\n" +
                              "24. Exercicio16\n" +
                              "25. Exercicio17\n" +
                              "26. Exercicio18\n" +
                              "27. Exercicio19\n" +
                              "28. Exercicio20\n");
            SetOpcao(Convert.ToInt32(Console.ReadLine()));
            Console.Clear();//Limpa o console
        }//fim

        //Executar o menu
        public void ExecutarMenu()
        {
            do
            {
                Menu();//Mostar as opções
                switch (GetOpcao())
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Coletar();//Pegar os dois números
                        Console.WriteLine("A soma é: " + this.modelo.Somar());//Fazer a operação de soma
                        break;//Finalizar o caso
                    case 2:
                        Coletar();
                        this.modelo.Subtrair();
                        Console.WriteLine("A subtração é:" + this.modelo.Subtrair());
                        break;
                    case 3:
                        Coletar();
                        //validação
                        if (this.modelo.Dividir() <= -1)
                        {
                            Console.WriteLine("Impossível dividir por zero!");
                        }
                        else
                        {
                            Console.WriteLine("A divisão é: " + this.modelo.Dividir());
                        }
                        break;
                    case 4:
                        Coletar();
                        Console.WriteLine("A multiplicação é: " + this.modelo.Multiplicar());
                        break;
                    case 5:
                        ColetarReal();
                        Console.WriteLine("A potência é: " + this.modelo.Potencia());
                        break;
                    case 6:
                        Console.WriteLine("Informe a base: ");
                        double bas = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe o expoente: ");
                        double expoente = Convert.ToDouble(Console.ReadLine());
                        //Mostrar o Resultado da operação
                        Console.WriteLine("A potência é: " + this.modelo.Potencia(bas, expoente));
                        break;
                    case 7:
                        ColetarReal();
                        Console.WriteLine("A raiz do primeiro número é: " + this.modelo.RaizNum3());
                        Console.WriteLine("A raiz do segundo número é: " + this.modelo.RaizNum4());
                        break;
                    case 8:
                        Console.WriteLine("Informe o primeiro número: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe o segundo número: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        //Chamar o método que calcula a raiz
                        Console.WriteLine("A raiz do primeiro número é: " + this.modelo.Raiz(num1));
                        Console.WriteLine("A raiz do segundo número é: " + this.modelo.Raiz(num2));
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não é valida!");
                        break;
                    case 9:
                        Console.WriteLine("Infome o ano: ");
                        int ano = Convert.ToInt32(Console.ReadLine());
                        //Mostrar o resultado
                        Console.WriteLine(this.modelo.Exer01(ano));
                        break;
                    case 10:
                        Console.WriteLine("Informe um número: ");
                        int cem = Convert.ToInt32(Console.ReadLine());
                        //Mostrar Resultado
                        Console.WriteLine(this.modelo.Exer02(cem));
                        break;
                    case 11:
                        Console.WriteLine("Informe sua idade: ");
                        int idade = Convert.ToInt32(Console.ReadLine());
                        //Mostrar resultado
                        Console.WriteLine(this.modelo.Exer03(idade));
                        break;
                    case 12:
                        Console.WriteLine("Informe o Primeiro número: ");
                        int d1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o Segundo número: ");
                        int d2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o Terceiro número: ");
                        int d3 = Convert.ToInt32(Console.ReadLine());
                        //Mostar Resultado
                        Console.WriteLine(this.modelo.Exer04(d1, d2, d3));
                        break;
                    case 13:
                        Console.WriteLine(this.modelo.Exer05());
                        break;
                    case 14:
                        Console.WriteLine(this.modelo.Exer06());
                        break;
                    case 15:
                        Console.WriteLine(this.modelo.Exer07());
                        break;
                    case 16:
                        Console.WriteLine("Crie Sua senha: ");
                        int criar = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe sua senha:");
                        int senha = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(this.modelo.Exer08(senha, criar));
                        break;
                    case 17:
                        Console.WriteLine("Digite um horário: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite outro horário: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        //Resultado
                        Console.WriteLine(this.modelo.Exer09(num1, num2));
                        break;
                    case 18:
                        Console.WriteLine("Digite o primeiro número: ");
                        int h5 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número: ");
                        int h6= Convert.ToInt32(Console.ReadLine());
                        //Resultado
                        Console.WriteLine(this.modelo.Exer10(h5, h6));
                        break;
                    case 19:
                        Console.WriteLine("Digite o primeiro número: ");
                        int l1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número: ");
                        int l2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o terceiro número: ");
                        int l3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o quarto número: ");
                        int l4 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o quinto número: ");
                        int l5 = Convert.ToInt32(Console.ReadLine());
                        //resultado
                        Console.WriteLine(this.modelo.Exer11(l1, l2, l3, l4, l5));
                        break;
                    case 20:
                        Console.WriteLine(this.modelo.Exer12());
                        break;
                }//fim escolha
            } while (GetOpcao() != 0);//fim do do...while
        }//fim do método executar menu


    }//fim da classe
}//fim do projeto
