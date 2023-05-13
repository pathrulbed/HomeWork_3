class Program
{
    static void Main(string[] args)
    {
        bool IsRun = true;
        string? choose;
        int R_size, C_size;
        float[,] A_box, B_box;
        while (IsRun)
        {
            Console.WriteLine("Choose Operation Of Matrix (+,-)");
            choose = Console.ReadLine();
            switch (choose)
            {
                case "+":
                Console.WriteLine("Input Size Of Matrix");
                R_size = int.Parse(Console.ReadLine());
                C_size = int.Parse(Console.ReadLine());
                Console.WriteLine("Input Number Of Matrix A");
                A_box = new float[R_size,C_size];
                for (int row = 0;row < R_size;row++)
                {
                    for (int col = 0;col < C_size;col++)
                    {
                        A_box[row,col] = float.Parse(Console.ReadLine());
                    }
                }

                Console.WriteLine("Input Number Of Matrix B");
                B_box = new float[R_size,C_size];
                for (int row = 0;row < R_size;row++)
                {
                    for (int col = 0;col < C_size;col++)
                    {
                        B_box[row,col] = float.Parse(Console.ReadLine());
                    }
                }
                
                Console.WriteLine("Result Of Matrix");
                for (int row = 0;row < R_size;row++)
                {
                    for (int col = 0;col < C_size;col++)
                    {
                        Console.Write("{0:N1}",(A_box[row,col])+(B_box[row,col]));
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                break;

                case "-":
                Console.WriteLine("Input Size Of Matrix");
                R_size = int.Parse(Console.ReadLine());
                C_size = int.Parse(Console.ReadLine());
                Console.WriteLine("Input Number Of Matrix A");
                A_box = new float[R_size,C_size];
                for (int row = 0;row < R_size;row++)
                {
                    for (int col = 0;col < C_size;col++)
                    {
                        A_box[row,col] = float.Parse(Console.ReadLine());
                    }
                }

                Console.WriteLine("Input Number Of Matrix B");
                B_box = new float[R_size,C_size];
                for (int row = 0;row < R_size;row++)
                {
                    for (int col = 0;col < C_size;col++)
                    {
                        B_box[row,col] = float.Parse(Console.ReadLine());
                    }
                }
                
                Console.WriteLine("Result Of Matrix ");
                for (int row = 0;row < R_size;row++)
                {
                    for (int col = 0;col < C_size;col++)
                    {
                        Console.Write("{0:N1}",(A_box[row,col])-(B_box[row,col]));
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                break;

                default:
                IsRun = false;
                break;
            }
        }
    }    
}
