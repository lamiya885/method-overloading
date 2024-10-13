namespace minimum_element
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("eded daxil et");
            int[] ededler = new int[4];
            int.TryParse(Console.ReadLine(), out ededler[0]);
            int.TryParse(Console.ReadLine(), out ededler[1]);
            int.TryParse(Console.ReadLine(), out ededler[2]);
            int.TryParse(Console.ReadLine(), out ededler[3]);
            int a=Min(ededler);
            Console.WriteLine(a);
            
         

            static int Min(int[] arry)
            {

                //int minValue = numbers.Min();
                //return minValue;
                for (int i = 0; i < arry.Length; i++)
                {
                    if (arry[i] < arry[i + 1])
                    {

                    }
                    
                   return arry[i];
                }               
            }
        }
    }
}
    
