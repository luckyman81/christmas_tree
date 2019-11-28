using System;
using System.Text;

namespace TreeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            tree.Draw(20);
            tree.DrawWithTopping(20);
        }
    }


    class Tree 
    {
        public void Draw(int height) 
        {
            StringBuilder sb = new StringBuilder();

            int cnt = 1;
            for (int i = 1; i < height*2; i += 2)
            {
                string line = sb.Append('X', i).ToString();
                line = line.PadLeft(cnt+height);
                
                Console.WriteLine(line);
                sb.Clear();
                cnt++;
            }

            string stem = "I";
            stem =stem.PadLeft(height + 1);
            Console.WriteLine(stem);
        }

        public void DrawWithTopping(int height) 
        {
            string top = "*";
            top = top.PadLeft(height + 1);
            Console.WriteLine(top);

            Draw(height);
        }
        
    }
}
