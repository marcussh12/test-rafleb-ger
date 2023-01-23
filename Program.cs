namespace Goldschmidt_opgaver;
class Program
{
    static void Main(string[] args)
    {
        Terning t1 = new Terning();
        t1.Skriv();
        t1.Ryst();
        t1.Skriv();


        Terning t2 = new Terning(true);
        t2.Skriv();
        t2.Ryst();
        t2.Skriv();

        Terning t3 = new Terning();

        List<Terning> terninger = new List<Terning> { t1, t2, t3 };

        raflebæger bæger = new raflebæger(terninger);

        Console.WriteLine(bæger.antalterninger);

        bæger.antalterninger = 5;

        Console.WriteLine(bæger.antalterninger);


    }
}



internal class raflebæger
{
    private List<Terning> terninger = new List<Terning> { };

    public raflebæger(List<Terning> ternings)
    {
        terninger = ternings;
    }

    public void shake()
    {
        foreach (var i in this.terninger)
        {
            i.Ryst();
        }

    }

    public void vis()
    {
        foreach (var i in this.terninger)
        {
            Console.WriteLine(i.værdi);
        }
        
    }

    public int antalterninger
    {
        get
        {
            return this.terninger.Count;
        }

        set
        {
            if(value > this.terninger.Count)
            {
                for (int i = this.terninger.Count; i < value; i++)
                {
                    Terning t_add = new Terning();
                    this.terninger.Add(t_add);
                }
            }
        }
    }

}

internal class Terning
{

    Random rnd = new Random();
    public int værdi;
    private bool snyd;

    public Terning()
    {
        this.værdi = 1;
        this.snyd = false;
    }

    public Terning(bool argument)
    {
        this.værdi = 1;
        this.snyd = argument;
    }


    public void Skriv()
    {
        Console.WriteLine("[" + this.værdi + "]");
    }

    public int Ryst()
    {
        if (!snyd)
        {
            this.værdi = rnd.Next(1, 7);
            return værdi;
        }
        else
        {
            this.værdi = 6;
            return værdi;
        }
    }



}

