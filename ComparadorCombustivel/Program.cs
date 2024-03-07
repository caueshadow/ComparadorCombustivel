namespace ComparadorCombustivel
{

    class Program
    {
        static void Main(string[] args)
        {
            double resuletanol = 0;
            double resulgasolina = 0;
            int tipo = 0;
            int op = 1;
            double valorgasolina = 0;
            double valoretanol = 0;
            double kmgasolina = 0;
            double kmetanol = 0;

            static void calculo(double valorgasolina, double valoretanol, double kmgasolina, double kmetanol)
            {
                double opdados = kmetanol / kmgasolina;
                double resuldadosgas = valorgasolina / 100 * opdados;
                double resuldadoseta = valoretanol / 100 * opdados;

                double resulgasolina = valorgasolina / 100 * 70;
                double resuletanol = valoretanol / 100 * 70;

                if (kmgasolina == 0)
                {
                    if (resulgasolina > resuletanol) // GASOLINA MELHOR OPÇÃO
                    {
                        Console.Clear();
                        Console.WriteLine("Abastecer com GASOLINA é a melhor opção para seu veiculo\n");

                    }
                    else if (resulgasolina < resuletanol)  // ETANOL MELHOR OPÇÃO

                    {
                        Console.Clear();
                        Console.WriteLine("Abastecer com ETANOL é a melhor opção para seu veiculo\n");

                    }
                    else if (resulgasolina == resuletanol)// IGUAIS
                    {
                        Console.Clear();
                        Console.WriteLine("Ambos combustiveis possuem o mesmo valor\n");

                    }
                }
                else if (kmgasolina != 0)
                {
                    if (resuldadosgas > resuldadoseta) // GASOLINA MELHOR OPÇÃO
                    {
                        Console.Clear();
                        Console.WriteLine("Abastecer com GASOLINA é a melhor opção para seu veiculo\n");

                    }
                    else if (resuldadosgas < resuldadoseta)  // ETANOL MELHOR OPÇÃO
                    {
                        Console.Clear();
                        Console.WriteLine("Abastecer com ETANOL é a melhor opção para seu veiculo\n");

                    }
                    else if (resuldadosgas == resuldadoseta)// IGUAIS
                    {
                        Console.Clear();
                        Console.WriteLine("Ambos combustiveis possuem o mesmo valor\n");

                    }
                }

            }


            while (op != 3)
            {
                Console.WriteLine("Bem Vindo, escolha uma das opções:");
                Console.WriteLine("1. Calcular Combustivel");
                Console.WriteLine("2. Editar Dados");
                Console.WriteLine("3. Sair do Programa\n");
                op = int.Parse(Console.ReadLine());
                Console.Clear();
                if (op == 3) //AO SELECIONAR OPÇÃO 3
                {
                    Console.WriteLine("Digite 1 para encerrar o programa, ou 2 para continuar");

                    int sair = int.Parse(Console.ReadLine());

                    if (sair == 1)
                    {
                        Console.Clear();
                        Environment.Exit(0);
                    }

                    else if (sair == 2)
                    {
                        Console.Clear();
                        op = 4;
                    }

                    // FIM OP 3
                }
                else if (op == 1)  //AO SELECIONAR OPÇÃO 1
                {
                    Console.Clear();
                    if (valorgasolina != 0)
                    {
                        calculo(valorgasolina, valoretanol, kmgasolina, kmetanol);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Opção selecionada: Calcular Combustivel");
                        Console.WriteLine("Insira: 1. Gasolina , 2. Etanol ou 3. FLEX para o combustível aceito por seu automóvel.");
                        tipo = int.Parse(Console.ReadLine());

                        if (tipo == 1) // SELECIONOU GASOLINA
                        {
                            Console.Clear();
                            Console.WriteLine("Insira o valor médio da gasolina:");
                            valorgasolina = Convert.ToDouble(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("Abastecer com GASOLINA é a melhor opção para seu veiculo\n");

                        }

                        else if (tipo == 2) // SELECIONOU ETANOL
                        {
                            Console.Clear();
                            Console.WriteLine("Insira o valor médio do etanol:");
                            valoretanol = Convert.ToDouble(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("Abastecer com ETANOL é a melhor opção para seu veiculo\n");
                        }
                        else if (tipo == 3) // SELECIONOU FLEX
                        {
                            Console.Clear();
                            Console.WriteLine("Insira o valor médio da gasolina:");
                            valorgasolina = Convert.ToDouble(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("Insira o valor médio do etanol:");
                            valoretanol = Convert.ToDouble(Console.ReadLine());
                            Console.Clear();
                            calculo(valorgasolina, valoretanol, kmgasolina, kmetanol);

                        }
                    }



                }
                else if (op == 2)  //AO SELECIONAR OPÇÃO 2
                {
                    Console.Clear();
                    Console.WriteLine("Insira: 1. Gasolina , 2. Etanol ou 3. FLEX para o combustível aceito por seu automóvel.");
                    tipo = int.Parse(Console.ReadLine());

                    if (tipo == 1) // SELECIONOU GASOLINA
                    {
                        Console.Clear();
                        Console.WriteLine("Insira quantos Km/L seu veiculo faz com gasolina:");
                        kmgasolina = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Insira o valor médio da gasolina:");
                        valorgasolina = Convert.ToDouble(Console.ReadLine());

                    }
                    else if (tipo == 2) // SELECIONOU ETANOL
                    {
                        Console.Clear();
                        Console.WriteLine("Insira quantos Km/L seu veiculo faz com etanol:");
                        kmetanol = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Insira o valor médio do etanol:");
                        valoretanol = Convert.ToDouble(Console.ReadLine());
                    }
                    else if (tipo == 3) // FLEX
                    {
                        Console.Clear();
                        Console.WriteLine("Insira quantos Km/L seu veiculo faz com gasolina:");
                        kmgasolina = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Insira o valor médio da gasolina:");
                        valorgasolina = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Insira quantos Km/L seu veiculo faz com etanol:");
                        kmetanol = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Insira o valor médio do etanol:");
                        valoretanol = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                    }
                }
                else if (op > 3 || op <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Opção incorreta, digite novamente\n");
                }
            }
        }
    }


}
