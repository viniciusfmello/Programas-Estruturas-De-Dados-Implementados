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
    public Fila Concatenar(Fila fila1, Fila fila2)
    {
        if (fila2.primeiro == fila2.ultimo)
        {
            Console.WriteLine("\n****NÃO É POSSÍVEL CONCATENAR FILA VAZIA****\n");
        }
        for (Celula i = fila2.primeiro.Prox; i != null; i = i.Prox)
        {
            Celula tmp = fila2.primeiro;
            fila2.primeiro = fila2.primeiro.Prox;
            int elemento = fila2.primeiro.Elemento;
            tmp.Prox = null;
            tmp = null;
            fila1.Inserir(elemento);
        }
        return fila1;
        /*Console.WriteLine("\n****FILA 1 + FILA 2 CONCATENADA****\n");
        for (Celula i = fila1.primeiro.Prox; i != null; i = i.Prox)
        {
            Console.Write(i.Elemento + " ");
        }*/
        Console.WriteLine("\n\n****FILA 2 VAZIA****\n");
        for (Celula i = fila2.primeiro.Prox; i != null; i = i.Prox)
        {
            Console.Write(i.Elemento + " ");
        }
    }
    public Celula getPrimeiro()
    {
        return primeiro;
    }

}
class Program
{
    static void Main(string[] args)
    {
        Fila fila1 = new Fila();
        Fila fila2 = new Fila();
        int valores1 = 0, valores2 = 0;
        Console.WriteLine("\n****PREENCHIMENTO FILA 1****\n");
        Console.WriteLine("Digite abaixo os valores que deseja adicionar na FILA 1 ou -1 para preencher a FILA 2");
        while (true)
        {
            valores1 = int.Parse(Console.ReadLine());
            if (valores1 == (-1))
            {
                break;
            }
            else
            {
                fila1.Inserir(valores1);
            }
        }
        Console.WriteLine("\n****PREENCHIMENTO FILA 2****\n");
        Console.WriteLine("Digite abaixo os valores que deseja adicionar na FILA 2 ou -1 para CONCATENAR ambas");
        while (true)
        {
            valores2 = int.Parse(Console.ReadLine());
            if (valores2 == (-1))
            {
                fila1 = fila1.Concatenar(fila1, fila2);
                Console.WriteLine("\n****FILA 1 + FILA 2 CONCATENADA****\n");
                for (Celula i = fila1.getPrimeiro().Prox; i != null; i = i.Prox)
                {
                    Console.Write(i.Elemento + " ");
                }
                break;
            }
            else
            {
                fila2.Inserir(valores2);
            }
        }
    }
}
