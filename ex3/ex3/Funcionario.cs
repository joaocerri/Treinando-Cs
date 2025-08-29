    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ex3
    {
        internal class Funcionario
        {
            string nome;
            double salarioBase;
            double quantidadeHorasExtra;
            double valorHorasExtra;

            public Funcionario()
            {
                this.nome = "";
                this.salarioBase = 0;
                this.quantidadeHorasExtra = 0;
                this.valorHorasExtra = 0;
            }

            public Funcionario(string nome, double salarioBase, double quantidadeHorasExtra, double valorHorasExtra)
            {
                this.nome = nome;
                if (salarioBase >= 954.00)
                {
                    this.salarioBase = salarioBase;
                }

                if (quantidadeHorasExtra <= 10)
                { 
                    this.quantidadeHorasExtra = quantidadeHorasExtra;
                }

                if (valorHorasExtra >= 10.00)
                {
                    this.valorHorasExtra = valorHorasExtra;
                }
            }

            public double calcularSalario()
            {
                return salarioBase + (quantidadeHorasExtra * valorHorasExtra);
            }

            public void GerarRelatorio()
            {
                Console.WriteLine($"Nome: {nome}");
                Console.WriteLine($"Salário Base: {salarioBase:C2}");
                Console.WriteLine($"Horas extra: {quantidadeHorasExtra} horas");
                Console.WriteLine($"Valor extra: {valorHorasExtra:C2}");
                Console.WriteLine($"Salário Total: {calcularSalario():C2}");
            } 

            public void ModificarCampos()
            {
                int opcao = 0;
                do
                {
                    Console.WriteLine("\nQual campo deseja modificar?");
                    Console.WriteLine("1 - Nome");  
                    Console.WriteLine("2 - Salário Base");
                    Console.WriteLine("3 - Quantidade de Horas Extra");
                    Console.WriteLine("4 - Valor da Hora Extra");
                    opcao = int.Parse(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine("Digite o novo nome:");
                            nome = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Digite o novo salário base:");
                            double novoSalarioBase = double.Parse(Console.ReadLine());
                            if (novoSalarioBase >= 954.00)
                            {
                                salarioBase = novoSalarioBase;
                            }
                            else
                            {
                                Console.WriteLine("Salário base deve ser maior ou igual a R$954,00");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Digite a nova quantidade de horas extra:");
                            double novaQuantidadeHorasExtra = double.Parse(Console.ReadLine());
                            if (novaQuantidadeHorasExtra <= 10)
                            {
                                quantidadeHorasExtra = novaQuantidadeHorasExtra;
                            }
                            else
                            {
                                Console.WriteLine("Quantidade de horas extra deve ser menor ou igual a 10");
                            }
                            break;
                        case 4:
                            Console.WriteLine("Digite o novo valor da hora extra:");
                            double novoValorHorasExtra = double.Parse(Console.ReadLine());
                            if (novoValorHorasExtra >= 10.00)
                            {
                                valorHorasExtra = novoValorHorasExtra;
                            }
                            else
                            {
                                Console.WriteLine("Valor da hora extra deve ser maior ou igual a R$10,00");
                            }
                            break;
                        default:
                            Console.WriteLine("Opção inválida");
                            break;
                    }
                    Console.WriteLine("\n\nRelatório atualizado:");
                    GerarRelatorio();
                } while (opcao > 0 && opcao < 5);

            }

        }

    }
