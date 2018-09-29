using System;
using System.Collections.Generic;
using System.Linq;

namespace matriciHard
{
    class Program
    {
       static int playerRow;
       static int playerCol;
        static char[][] jagetArray;
        static bool isOutSide;
        static bool isDead;
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimension[0];
            int cols = dimension[1];

            jagetArray = new char[rows][];

            GetJaget(cols);
         //   PrintJagetArray();
            string direction = Console.ReadLine();
            MoovePlayer(direction);
            
        }

        private static void MoovePlayer(string direction)
        {
            for (int i = 0; i < direction.Length; i++)
            {
                char curent = direction[i];

                if (curent == 'U')
                {
                    Move(-1,0);
                }
                else if (curent == 'L')
                {
                    Move(0, -1);
                }
                else if (curent == 'R')
                {
                    Move(0, 1);
                }
                else if (curent == 'D')
                {
                    Move(1, 0);
                }
                Spread();

                if (isDead)
                {
                    PrintJagetArray();
                    Console.WriteLine($"dead: {playerRow} {playerCol}");
                    break;
                }
                if (isOutSide)
                {
                    PrintJagetArray();
                    Console.WriteLine($"won: {playerRow} {playerCol}");
                    break;
                }
            }
        }

        private static void Spread()
        {
            Queue<int[]> indexes = new Queue<int[]>();
            for (int row = 0; row < jagetArray.Length; row++)
            {
                for (int col = 0; col < jagetArray[row].Length; col++)
                {
                    if (jagetArray[row][col] == 'B')
                    {
                        indexes.Enqueue(new int[] {row,col });
                    }
                }
            }
            while (indexes.Count > 0)
            {
                int[] curentIndex = indexes.Dequeue();
                int targetRow = curentIndex[0];
                int targetCol = curentIndex[1];

                if (IsInside(targetRow - 1,targetCol))
                {
                    if (IsPlayer(targetRow - 1, targetCol))
                    {
                        isDead = true;
                    }
                    jagetArray[targetRow - 1][targetCol] = 'B';

                }
                if (IsInside(targetRow + 1, targetCol))
                {
                    if (IsPlayer(targetRow + 1, targetCol))
                    {
                        isDead = true;
                    }
                    jagetArray[targetRow + 1][targetCol] = 'B';

                }
                if (IsInside(targetRow, targetCol - 1))
                {
                    if (IsPlayer(targetRow, targetCol - 1))
                    {
                        isDead = true;
                    }
                    jagetArray[targetRow][targetCol -1] = 'B';

                }
                if (IsInside(targetRow, targetCol + 1))
                {
                    if (IsPlayer(targetRow, targetCol + 1))
                    {
                        isDead = true;
                    }
                    jagetArray[targetRow][targetCol + 1] = 'B';

                }
            }
        }

        private static bool IsPlayer(int row, int col)
        {
            return jagetArray[row][col] =='P';
        }

        private static void Move(int row, int col)
        {
            int targetRow = playerRow + row;
            int targetCol = playerCol + col;

            if (!IsInside(targetRow,targetCol))
            {
                jagetArray[playerRow][playerCol] = '.';
                isOutSide = true;
            }
          else if (IsBuny(targetRow,targetCol))
            {
                jagetArray[playerRow][playerCol] = '.';
                playerRow += row;
                playerCol += col;
                isDead = true;
            }
            else
            {
                jagetArray[playerRow][playerCol] = '.';

                playerCol += col;
                playerRow += row;

                jagetArray[playerRow][playerCol] = 'P';
            }
           

        }

        private static bool IsBuny(int row, int col)
        {
            return jagetArray[row][col] == 'B';
        }

        private static bool IsInside(int row, int col)
        {
            return row >= 0 && row < jagetArray.Length && col >= 0 && col < jagetArray[row].Length;
        }

        private static void PrintJagetArray()
        {
            for (int row = 0; row < jagetArray.Length; row++)
            {
                Console.WriteLine(String.Join("",jagetArray[row]));
            }
            
        }

        private static void GetJaget(int cols)
        {
            for (int row = 0; row < jagetArray.Length; row++)
            {
                string input = Console.ReadLine();
                jagetArray[row] = new char[cols];
                for (int col = 0; col < jagetArray[row].Length; col++)
                {
                    jagetArray[row][col] = input[col];
                    if (jagetArray[row][col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }
        }
    }
}
