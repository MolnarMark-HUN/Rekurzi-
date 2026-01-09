namespace ConsoleApp2
{
    class Fibonacci
    {
        public int num1, num2, res, count;
        public Fibonacci(int a1, int b2, int c)
        {
            this.num1 = a1;
            this.num2 = b2;
            this.res = this.num1 + this.num2;
            this.count = c;
        }
        public void countfibonacci()
        {
            if (this.count > 1)
            {
                this.num2=this.num1;
                this.num1 = this.res;
                this.res += this.num2;
                this.count--;
                countfibonacci();
            }
        }
    }
    class Faktorialis
    {
        public int n;
        public int res;
        public Faktorialis(int n)
        {
            this.n = n;
            this.res = 1;
        }
        public void CountFaktorialis()
        {
            if (n>1)
            {
                res += n;
                n--;
                CountFaktorialis();
            }
        }
    }
    class Hatvany
    {
        public int alap;
        public int kitevo;
        public int res;
        public Hatvany(int alap, int kitevo)
        {
            this.alap = alap;
            this.kitevo = kitevo;
            this.res = 1;
        }
        public void CountHatvany()
        {
            if (kitevo>0)
            {
                res += alap;
                kitevo--;
                CountHatvany();
            }
        }
    }
     class Program
    {
        
        static void Main(string[] args)
        {
            /*Fibonacci fb = new Fibonacci(1, 1, 9);
            fb.countfibonacci();
            Console.WriteLine("{0}",fb.res);
            Console.ReadKey();*/
            /*Faktorialis f = new Faktorialis(5);
            f.CountFaktorialis();
            Console.WriteLine("5!="+f.res);
            Console.ReadKey();*/
            Hatvany h=new Hatvany(2,5);
            h.CountHatvany();
            Console.WriteLine("2^5="+h.res);
            Console.ReadKey();
        }
        
    }
}
