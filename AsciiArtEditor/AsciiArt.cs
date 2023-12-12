using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AsciiArtEditor
{
    internal class AsciiArt
    {
        public static int selectionMinX, selectionMinY = -1;
        public static int selectionMaxX, selectionMaxY = -1;
        public static int width = 80;
        public static int height = 10;
        public static int cursorX, cursorY = -1;
        public static Random r = new Random();
        public static string cFileName = "Untitled.hurp";
        public static string fileExt = "hurp";
        public static string cFilePath = "";


        public static Stack<CharInfo[,]> undoHistory = new Stack<CharInfo[,]>();
        public static Stack<CharInfo[,]> redoHistory = new Stack<CharInfo[,]>();

        public static CharInfo[,] characters;

        public static bool hasUnsavedChanges = false;

        public static CharInfo brush  = new CharInfo("░");
        public static CharInfo brush2 = new CharInfo(" ");

        public struct CharInfo
        {
            public string character = " ";
            public ConsoleColor FG;
            public ConsoleColor BG;
            public CharInfo(string characterIn = " ", ConsoleColor fgc = ConsoleColor.White, ConsoleColor bgc = ConsoleColor.Black)
            {
                character = characterIn;
                FG = fgc;
                BG = bgc;
            }

            public CharInfo(CharInfo original)
            {
                character = original.character;
                FG = original.FG;
                BG = original.BG;
            }
            public static bool operator ==(CharInfo a, CharInfo b)
            {
                return a.character == b.character && a.BG == b.BG && a.FG == b.FG;
            }
            public static bool operator !=(CharInfo a, CharInfo b)
            {
                return !(a == b);
            }
        }

        public static void CreateBlankFile()
        {
            characters = new CharInfo[width, height];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //characters[x, y] = new CharInfo("!", (ConsoleColor)r.Next(0, 15), (ConsoleColor)r.Next(0, 15));
                    characters[x, y] = new CharInfo();
                }
            }
        }
        public static void FixConsoleSize()
        {
            Console.SetWindowSize(82, 40);
            Console.SetBufferSize(82, 40);
            //Console.SetWindowSize(Math.Max(width + 1, 10), Math.Max(height + 1, 5));
            //Console.SetBufferSize(Math.Max(width + 1, 10), Math.Max(height + 1, 5));
        }
        public static void ResizeH(int newSize, int alignment)
        {
            CharInfo[,] currentChars = characters;
            int sizeDiff = newSize - width;
            MessageBox.Show(sizeDiff + ", " + alignment);
            int alignOffset = 0; //correct for left alignment
            if (alignment == 0) //center align
            {
                alignOffset = -sizeDiff/2;
            }
            else if (alignment == 1) //right align
            {
                alignOffset = -sizeDiff;
            }
            CharInfo[,] newCharacters = new CharInfo[width + sizeDiff, height];
            for (int x = 0; x < newSize; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    if (x + alignOffset >= currentChars.GetLength(0) || x + alignOffset < 0) //if larger than old width or out of range
                    {
                        newCharacters[x, y] = new CharInfo();
                    }
                    else
                    {
                        newCharacters[x, y] = currentChars[x + alignOffset, y];
                    }
                }
            }
            width = newSize;
            characters = newCharacters;
            FixConsoleSize();
        }
        public static void ResizeV(int newSize, int alignment)
        {
            CharInfo[,] currentChars = characters;
            int sizeDiff = newSize - height;
            int alignOffset = 0; //correct for top alignment
            if (alignment == 1) //center align
            {
                alignOffset = sizeDiff / 2;
            }
            else if (alignment == 1) //bottom align
            {
                alignOffset = sizeDiff;
            }
            CharInfo[,] newCharacters = new CharInfo[width, height + sizeDiff];
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < newSize; y++)
                {
                    if (y > height || y + alignOffset >= currentChars.GetLength(1) || y + alignOffset < 0) //if larger than old height or our of range
                    {
                        newCharacters[x, y] = new CharInfo();
                    }
                    else
                    {
                        newCharacters[x, y] = currentChars[x, y + alignOffset];
                    }
                }
            }
            height = newSize;
            characters = newCharacters;
            FixConsoleSize();
        }

        private static CharInfo[,] getCharactersClone()
        {
            CharInfo[,] clone = new CharInfo[width, height];
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    clone[x, y] = new CharInfo(characters[x, y]);
                }
            }
            return clone;
        }

        public static void ClearUndo()
        {
            undoHistory.Clear();
            redoHistory.Clear();
        }
        public static void AddUndoState()
        {
            undoHistory.Push(getCharactersClone());
            redoHistory.Clear();
            hasUnsavedChanges = true;
        }
        public static void Undo()
        {
            if (undoHistory.Count <= 0)
            {
                Console.Beep(500, 20);
                return;
            }
            redoHistory.Push(getCharactersClone());
            characters = undoHistory.Pop();
            width = characters.GetLength(0);
            height = characters.GetLength(1);

        }
        public static void Redo()
        {
            if (redoHistory.Count <= 0)
            {
                Console.Beep(500, 20);
                return;
            }
            undoHistory.Push(getCharactersClone());
            characters = redoHistory.Pop();
            width = characters.GetLength(0);
            height = characters.GetLength(1);
        }

        public static void SetCharacter(int x, int y, CharInfo charInfo)
        {
            if(x >= 0 && x < width && y >= 0 && y < height)
            {
                characters[x, y] = charInfo;
            }
        }
        //newlines ignored during loading, just makes file more readable
        public static void Save(string fileName)
        {
            string saveFileText = "{" + width.ToString() + "," + height.ToString() + "}\n";
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    CharInfo charInfo = characters[x, y];
                    saveFileText += Util.consoleColorToChar[charInfo.FG];
                    saveFileText += Util.consoleColorToChar[charInfo.BG];
                    if (charInfo.character == null)
                    {
                        saveFileText += " ";
                    }
                    else
                    {
                        saveFileText += charInfo.character;
                    }
                }
                saveFileText += "\n";
            }
            File.WriteAllText(fileName, saveFileText, Encoding.UTF8);
            hasUnsavedChanges = false;
        }
        public static void LoadFile(string fileName)
        {
            string saveFileText = File.ReadAllText(fileName).ReplaceLineEndings("");
            if (!saveFileText.StartsWith('{'))
            {
                MessageBox.Show("Header missing.", "Malformed File!");
                return;
            }
            int endOfHeaderPos = saveFileText.IndexOf('}');
            if(endOfHeaderPos == -1)
            {
                MessageBox.Show("Header missing.", "Malformed File!");
                return;
            }
            string headerContents = saveFileText.Substring(1, endOfHeaderPos - 1);
            string[] headerElements = headerContents.Split(",");
            if (headerElements.Length < 2)
            {
                MessageBox.Show("Header invalid.", "Malformed File!");
                return;
            }
            int newWidth = 0;
            int newHeight = 0;
            if(!int.TryParse(headerElements[0], out newWidth) || !int.TryParse(headerElements[1], out newHeight))
            {
                MessageBox.Show("Header invalid: Width or Height are non-number.", "Malformed File!");
                return;
            }
            string bodyContents = saveFileText.Substring(endOfHeaderPos+1);

            CharInfo[,] newData = new CharInfo[newWidth, newHeight];
            int i = 0;
            for (int y = 0; y < newHeight; y++)
            {
                for (int x = 0; x < newWidth; x++)
                {
                    string thisSegment = bodyContents.Substring(i * 3, 3);
                    string c = thisSegment.Substring(2,1);
                    ConsoleColor fgc = Util.charToConsoleColor[thisSegment[0]];
                    ConsoleColor bgc = Util.charToConsoleColor[thisSegment[1]];
                    newData[x,y] = new CharInfo(c, fgc, bgc);
                    i++;
                }
            }

            //LOADING past this point!
            height = newHeight;
            width = newWidth;

            characters = newData;
            
        }

        public static void DisplayArt()
        {
            Console.SetCursorPosition(0, 1);
            Console.ResetColor();
            Console.Write("╔");
            for (int x = 0; x < width; x++)
            {
                Console.Write("═");
            }
            Console.Write("╗");
            for (int y = 0; y < height; y++)
            {
                if (y >= Console.BufferHeight) continue;
                Console.SetCursorPosition(0, y+2);
                Console.ResetColor();
                Console.Write("║");
                for (int x = 0; x < width; x++)
                {
                    CharInfo charInfo = characters[x, y];
                    Console.BackgroundColor = charInfo.BG;
                    Console.ForegroundColor = charInfo.FG;
                    if(charInfo.character == null)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(charInfo.character);
                    }
                }
                Console.ResetColor();
                Console.Write("║");
            }
            Console.SetCursorPosition(0, height+2);
            Console.ResetColor();
            Console.Write("╚");
            for (int x = 0; x < width; x++)
            {
                Console.Write("═");
            }
            Console.Write("╝");
        }


        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        public static void Init()
        {
            AllocConsole();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            FixConsoleSize();
            Console.Title = "Console Preview - HURP Editor";
            CreateBlankFile();
            DisplayArt();
            
            /*while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                Console.WriteLine(key.Key);
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.Clear();
                DisplayArt();
                Thread.Sleep(200);
            }*/
        }
    }
}
