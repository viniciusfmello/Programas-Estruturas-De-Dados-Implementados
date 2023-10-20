class Celula
{
    private int elemento;
    private Celula prox;

    public Celula(int elemento)
    {
        this.elemento = elemento;
        this.prox = null;
    }
    public Celula()
    {
        this.elemento = 0;
        this.prox = null;
    }
    public Celula Prox
    {
        get { return prox; }
        set { prox = value; }
    }
    public int Elemento
    {
        get { return elemento; }
        set { elemento = value; }
    }
}
class Fila
{
    private Celula primeiro, ultimo;
    public Fila()
    {
        primeiro = new Celula();
        ultimo = primeiro;
    }
    public void Inserir(int valor)
    {
        ultimo.Prox = new Celula(valor);
        ultimo = ultimo.Prox;
    }
    public Celula getPrimeiro()
    {
        return primeiro;
    }
    public Celula getUltimo()
    {
        return ultimo;
    }
    public void MostrarFila3(Fila fila3, Fila fila1)
    {
        Console.WriteLine("\n****FILA 1 E FILA 2 JUNTAS EM ORDEM CRESCENTE****\n");
        for (Celula i = fila3.primeiro.Prox; i != null; i = i.Prox)
        {
            Console.Write(i.Elemento + " ");
        }
    }
    public void JuntarFilas1e2(Fila fila1, Fila fila2, Fila fila3)
    {
        for (Celula i = fila1.primeiro.Prox; i != null; i = i.Prox)
        {
            fila3.Inserir(i.Elemento);
        }
        for (Celula i = fila2.primeiro.Prox; i != null; i = i.Prox)
        {
            fila3.Inserir(i.Elemento);
        }

    }
}
class Program
{
    static void Main(string[] args)
    {
        Fila Fila1 = new Fila();
        Fila Fila2 = new Fila();
        Fila Fila3 = new Fila();
        int numero1 = 0, numero2 = 0;
        Console.WriteLine("\n****JUNÇÃO DE FILAS****\n");
        Console.WriteLine("****PREENCHIMENTO DA FILA 1****\n");
        Console.WriteLine("Digite em cada linha os valores da FILA 1 ou digite -1 para preencher a FILA 2");
        numero1 = int.Parse(Console.ReadLine());
        Fila1.Inserir(numero1);
        while (true)
        {
            numero1 = int.Parse(Console.ReadLine());
            if (numero1 == (-1))
            {
                break;
            }
            else
            {
                for (Celula i = Fila1.getUltimo(); i != null; i = i.Prox)
                {
                    if (numero1 > i.Elemento)
                    {
                        Fila1.Inserir(numero1);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("****VALOR MENOR QUE O ANTERIOR, A FILA DEVE SER CRESCENTE****");
                    }
                }
            }
        }
        Console.WriteLine("\n****PREENCHIMENTO DA FILA 2****\n");
        Console.WriteLine("Digite em cada linha os valores da FILA 2 ou digite -1 para juntar as duas filas");
        while (true)
        {
            numero2 = int.Parse(Console.ReadLine());
            if (numero2 == (-1))
            {
                Fila3.JuntarFilas1e2(Fila1, Fila2, Fila3);
                Fila3.MostrarFila3(Fila3, Fila1);
            }
            else
            {
                for (Celula i = Fila1.getUltimo(); i != null; i = i.Prox)
                {
                    if (numero2 > i.Elemento)
                    {
                        Fila2.Inserir(numero2);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("****VALOR MENOR QUE O ANTERIOR, A FILA DEVE CRESCENTE****");
                    }
                }
            }
        }
    }
}