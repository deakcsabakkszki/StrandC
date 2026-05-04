namespace StrandC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Furdo> list = new List<Furdo>();
            string[] sorok = File.ReadAllLines("strandadatok.txt").Skip(1).ToArray();
            foreach (string s in sorok) { 
                list.Add(new Furdo(s));
            }
            Console.WriteLine("7.feladat:");
            Console.WriteLine($"Fürdők száma: {list.Count}");
            //8.	Adja meg, mennyi a fürdőbelépők átlagos ára! Az eredmény egy tizedesre kerekítve írja ki!   
            int összeg = 0;
            foreach (var item in list)
            {
                összeg += item.Ár;
            }
            double átlag=összeg/(double)list.Count;
            Console.WriteLine($"8. feladat\r\nA fürdőbelépők átlagos ára: {átlag:F1}\r\n");
        }
    }
}
