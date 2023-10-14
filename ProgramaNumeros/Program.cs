class Lista
{
    public double[] numerosLista;
    public int n;

    public Lista(int tamanho)
    {
        Inicializar(tamanho);
    }
    private void Inicializar(int tamanho)
    {
        this.numerosLista = new double[tamanho];
        this.n = 0;
    }
    public void InserirNumero(double num)
    {
        if (n > numerosLista.Length)
        {
            Console.WriteLine("\n****LISTA LOTADA****\n");
        }
        for (int i = n; i > 0; i--)
        {
            numerosLista[i] = numerosLista[i - 1];
        }
        numerosLista[0] = num;
        n++;
        Console.WriteLine($"\n****O NÚMERO {num} FOI ADICIONADO NO INÍCIO DA LISTA****\n");
    }
    public void VerificaNumero(double num)
    {
        bool tem1 = false;
        for (int i = 0; i < n; i++)
        {
            if (numerosLista[i] == num)
            {
                Console.WriteLine($"\n****O NÚMERO {num} EXISTE NA LISTA****\n");
                tem1 = true;
            }
        }
        if (!tem1)
        {
            Console.WriteLine($"\n****O NÚMERO {num} NÃO EXISTE NA LISTA****\n");
        }
    }
    public void SomaNumeros()
    {
        double soma = 0;
        for (int i = 0; i < n; i++)
        {
            soma += numerosLista[i];
        }
        Console.WriteLine($"\n****A SOMA DE TODOS VALORES DA LISTA É {soma}");
    }
    public void VerificaMaior()
    {
        double maior = Double.MinValue;

        for (int i = 0; i < n; i++)
        {
            if (numerosLista[i] > maior)
            {
                maior = numerosLista[i];
            }
        }
        Console.WriteLine($"\n****O MAIOR VALOR DA LISTA DE NÚMEROS É: {maior}****\n");
    }
    public void VerificaMenor()
    {
        double menor = Double.MaxValue;

        for (int i = 0; i < n; i++)
        {
            if (numerosLista[i] < menor)
            {
                menor = numerosLista[i];
            }
        }
        Console.WriteLine($"\n****O MENOR VALOR DA LISTA DE NÚMEROS É: {menor}****\n");
    }
    public void RemoverPares()
    {
        bool tem = false;
        for (int i = 0; i < n; i++)
        {
            if (numerosLista[i] % 2 == 0)
            {
                numerosLista[i] = numerosLista[i + 1];
                tem = true;
            }
            n--;
        }
        if (tem)
        {
            Console.WriteLine("\n****NÚMEROS PARES REMOVIDOS!****\n");
        }
        else
        {
            Console.WriteLine("\n****NÃO EXISTE NÚMEROS PARES PARA REMOVER NA LISTA****\n");
        }

    }
    public void ExibirSemPares()
    {
        bool tem = false;
        for (int i = 0; i < n; i++)
        {
            if (numerosLista[i] % 2 == 0)
            {
                Console.WriteLine("\n****NÃO É POSSÍVEL EXIBIR A LISTA POIS EXISTEM NÚMEROS PARES NELA****\n");
                tem = true;
                break;
            }
        }
        if (!tem)
        {
            Console.WriteLine("\n****LISTA DE NÚMEROS SEM PARES****\n");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(numerosLista[i]);
            }
        }
    }
    public void InverterOrdem()
    {
        Console.WriteLine("\n****LISTA DE NÚMEROS INVERTIDOS****\n");

        for (int i = n-1; i >= 0; i--)
        {
            Console.WriteLine(numerosLista[i]);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Lista listaNumeros = new Lista(50);
        Console.WriteLine("\n****NOSSA LISTA COMPORTA ATÉ 50 NÚMEROS REAIS****");
        while (true)
        {
            try
            {
                Console.WriteLine("\n--------------------MENU DE OPÇÕES--------------------\n\n1)Inserir um número na lista\n2)Verificar se um número consta na lista\n3)Exibir a soma de todos números\n4)Exibir o maior número da lista\n5)Exibir o menor número da lista\n6)Remover números pares\n7)Exibir números da lista sem pares\n8)Inverter os números\n9)Encerrar o programa");
                int opcao = int.Parse(Console.ReadLine());
                if (opcao == 9)
                {
                    Console.WriteLine("\n****PROGRAMA FINALIZADO****");
                    break;
                }
                switch (opcao)
                {
                    case 1:
                        bool tem = false;
                        Console.WriteLine("Digite o número que deseja adicionar na lista");
                        double num1 = double.Parse(Console.ReadLine());
                        for (int i = 0; i < listaNumeros.n; i++)
                        {
                            if (listaNumeros.numerosLista[i] == num1)
                            {
                                Console.WriteLine("\n****ESSE NÚMERO JÁ ESTÁ NA LISTA****\n");
                                tem = true;
                                break;
                            }
                        }
                        if (!tem)
                        {
                            listaNumeros.InserirNumero(num1);
                            break;
                        }
                        break;

                    case 2:
                        Console.WriteLine("Digite o número que deseja verificar se consta na lista");
                        double num2 = double.Parse(Console.ReadLine());
                        listaNumeros.VerificaNumero(num2);
                        break;

                    case 3:
                        listaNumeros.SomaNumeros();
                        break;
                    case 4:
                        listaNumeros.VerificaMaior();
                        break;
                    case 5:
                        listaNumeros.VerificaMenor();
                        break;
                    case 6:
                        listaNumeros.RemoverPares();
                        break;

                    case 7:
                        listaNumeros.ExibirSemPares();
                        break;
                    case 8:
                        listaNumeros.InverterOrdem();
                        break;

                    default:
                        Console.WriteLine("\n****Digite uma opção válida:****\n");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("OPS, você digitou um caractere inválido. Nosso MENU trabalha apenas com números.");
            }
        }
    }
}
