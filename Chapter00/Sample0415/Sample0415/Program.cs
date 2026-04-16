namespace Sample0415
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            int[] num = new int[10];
            //入力
            for (int i = 0; i < num.Length; i++)
            {
                //num[i] = i + 1;

                Console.Write("num[" + i + "]:");
                String? inputNum = Console.ReadLine();


                int count = int.Parse(inputNum);

                num[i] = count;
                sum += count;
            }

            //出力
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("num[" + i + "]:");
                astOut(num[i]);
                Console.WriteLine();
            }
            Console.WriteLine("合計：" + num.Where(n=>n%2 ==0).Sum());
        }
         static void astOut(int num) {
            for (int j = 0; j < num; j++)
            {
                Console.Write("*");
            }
        }
    }
}
