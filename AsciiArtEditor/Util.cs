using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsciiArtEditor
{
    public static class Util
    {
        public static Dictionary<ConsoleColor, char> consoleColorToChar = new Dictionary<ConsoleColor, char>();
        public static Dictionary<char, ConsoleColor> charToConsoleColor = new Dictionary<char, ConsoleColor>();

        static Util()
        {
            consoleColorToChar.Add(ConsoleColor.Black, 'x');
            consoleColorToChar.Add(ConsoleColor.DarkBlue, 'b');
            consoleColorToChar.Add(ConsoleColor.DarkGreen, 'g');
            consoleColorToChar.Add(ConsoleColor.DarkCyan, 'c');
            consoleColorToChar.Add(ConsoleColor.DarkRed, 'r');
            consoleColorToChar.Add(ConsoleColor.DarkMagenta, 'm');
            consoleColorToChar.Add(ConsoleColor.DarkYellow, 'y');
            consoleColorToChar.Add(ConsoleColor.Gray, 'w');

            consoleColorToChar.Add(ConsoleColor.DarkGray, 'X');
            consoleColorToChar.Add(ConsoleColor.Blue, 'B');
            consoleColorToChar.Add(ConsoleColor.Green, 'G');
            consoleColorToChar.Add(ConsoleColor.Cyan, 'C');
            consoleColorToChar.Add(ConsoleColor.Red, 'R');
            consoleColorToChar.Add(ConsoleColor.Magenta, 'M');
            consoleColorToChar.Add(ConsoleColor.Yellow, 'Y');
            consoleColorToChar.Add(ConsoleColor.White, 'W');
            foreach(ConsoleColor cc in consoleColorToChar.Keys)
            {
                charToConsoleColor.Add(consoleColorToChar[cc], cc);
            }
        }

        public static Color ToColor(this ConsoleColor consoleColor)
        {
            switch (consoleColor)
            {
                case ConsoleColor.Black:
                    return Color.FromArgb(12, 12, 12);

                case ConsoleColor.DarkBlue:
                    return Color.FromArgb(0, 55, 218);

                case ConsoleColor.DarkGreen:
                    return Color.FromArgb(19, 161, 14);

                case ConsoleColor.DarkCyan:
                    return Color.FromArgb(58, 150, 221);

                case ConsoleColor.DarkRed:
                    return Color.FromArgb(197, 15, 31);

                case ConsoleColor.DarkMagenta:
                    return Color.FromArgb(136, 23, 152);

                case ConsoleColor.DarkYellow:
                    return Color.FromArgb(193, 156, 0);

                case ConsoleColor.Gray:
                    return Color.FromArgb(204, 204, 204);

                case ConsoleColor.DarkGray:
                    return Color.FromArgb(118, 118, 118);

                case ConsoleColor.Blue:
                    return Color.FromArgb(59, 120, 255);

                case ConsoleColor.Green:
                    return Color.FromArgb(22, 198, 12);

                case ConsoleColor.Cyan:
                    return Color.FromArgb(97, 214, 214);

                case ConsoleColor.Red:
                    return Color.FromArgb(231, 72, 86);

                case ConsoleColor.Magenta:
                    return Color.FromArgb(180, 0, 158);

                case ConsoleColor.Yellow:
                    return Color.FromArgb(249, 241, 165);

                case ConsoleColor.White:
                    return Color.FromArgb(242, 242, 242);

                default:
                    throw new NotSupportedException();
            }
        }
    }
}
