/* Implement the "Falling Rocks" game in the text console. A small dwarf stays at the bottom of the screen and 
 * can move left and right (by the arrows keys). A number of rocks of different sizes and forms constantly fall 
 * down and you need to avoid a crash. Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with 
 * appropriate density. The dwarf is (O). Ensure a constant game speed by Thread.Sleep(150). Implement collision 
 * detection and scoring system.*/

using System;
using System.Collections.Generic;
using System.Threading;

class FallingRock
{
    struct Element
    {
        public int x;
        public int y;
        public ConsoleColor color;
        public char symbol;
    }
    static void PrintOnPosition(int x, int y, char symbol, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(symbol);
    }
    static void PrintStringOnPosition(int x, int y, string str, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(str);
    }    
    static void Main()
    {
        int playfieldWidth = 30;
        int livesCount = 5;
        int scoresCount = 0;
        int indexRockSymbol;
        char[] rockSymbol = new char[] { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };
        Random randomGenerator = new Random();
        string[] colors = ConsoleColor.GetNames(typeof(ConsoleColor));
        
        Console.BufferHeight = Console.WindowHeight = 30;
        Console.BufferWidth = Console.WindowWidth = 50;

        // user element - dwarf
        Element dwarf = new Element();
        dwarf.x = (playfieldWidth/2) - 1;
        dwarf.y = Console.WindowHeight - 1;
        dwarf.color = ConsoleColor.White;
        dwarf.symbol = 'O';
        // element - rocks
        List<Element> rocks = new List<Element>();
        
        while (true)
        {
            bool hitted = false;
            // create rock
            {
                indexRockSymbol = randomGenerator.Next(0, rockSymbol.Length);
                ConsoleColor color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colors[randomGenerator.Next(0, colors.Length)]);
                Element newRock = new Element();
                newRock.color = color;
                newRock.symbol = rockSymbol[indexRockSymbol];
                newRock.x = randomGenerator.Next(0, playfieldWidth);
                newRock.y = 0;
                rocks.Add(newRock);
            }
            // move dwarf (key pressed)
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                while (Console.KeyAvailable) Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (dwarf.x - 1 >= 0)
                    {
                        dwarf.x--;
                    }
                }
                if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (dwarf.x + 1 < playfieldWidth)
                    {
                        dwarf.x++;
                    }
                }
            }
            // move rocks
            List<Element> newListRocks = new List<Element>();
            for (int i = 0; i < rocks.Count; i++)
            {
                Element oldRock = rocks[i];
                Element newRock = new Element();
                newRock.x = oldRock.x;
                newRock.y = oldRock.y + 1;
                newRock.symbol = oldRock.symbol;
                newRock.color = oldRock.color;               
                if (newRock.y < Console.WindowHeight)
                {
                    newListRocks.Add(newRock);
                }
                else
                {
                    scoresCount++;
                }
                // Collision detection
                if ((newRock.x == (dwarf.x)) && (newRock.y == (dwarf.y)))
                {
                    livesCount--;
                    hitted = true;
                    if (livesCount == 0)
                    {
                        PrintStringOnPosition(36, 4, "GAME OVER!", ConsoleColor.Red);
                        PrintStringOnPosition(35, 6, "Press Enter!", ConsoleColor.Red);
                        Console.ReadLine();
                        return;
                    }
                }                
            }
            rocks = newListRocks;
            // Clear the console
            Console.Clear();
            // Redraw playfield
            if (hitted)
            {                
                PrintOnPosition(dwarf.x, dwarf.y, 'X', ConsoleColor.Red);
                rocks.Clear();
            }
            else
            {
                PrintOnPosition(dwarf.x, dwarf.y, dwarf.symbol, dwarf.color);
            }     
            foreach (Element rock in rocks)
            {
                PrintOnPosition(rock.x, rock.y, rock.symbol, rock.color);
            }
            for (int i = 0; i < Console.WindowHeight; i++)
            {
                PrintOnPosition(30, i, '|');
            }
            // Draw info
            PrintStringOnPosition(34, 10, "Falling Rocks", ConsoleColor.Green);
            PrintStringOnPosition(36, 12, "Scores: " + scoresCount, ConsoleColor.Cyan);
            PrintStringOnPosition(37, 14, "Lives: " + livesCount, ConsoleColor.Cyan);
            // Slow down program
            Thread.Sleep(150);
        }        
    }
}    

