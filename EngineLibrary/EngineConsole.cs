using System;
using static System.Console;
using System.Collections;
using System.Collections.Generic;
namespace EngineLibrary
{
  public class EngineConsole
  {
    private static ConsoleStyle _colorScheme = new ConsoleStyle(ConsoleColor.White,ConsoleColor.Black);
    public static void SetColor(ConsoleColor fG, ConsoleColor bG)
    {
      _colorScheme.Foreground = fG;
      _colorScheme.Background = bG;
    }
    public static void SetColor()
    {
      _colorScheme.Foreground = ConsoleColor.Black;
      _colorScheme.Background = ConsoleColor.White;
    }
    public static void Print(string text)
    {
      Write(text);
    }
    public static void Print(int x, int y, string text)
    {
      Goto(x,y);
      Write(text);
    }
    public static void Goto(int x, int y)
    {
      SetCursorPosition(Math.Min(BufferWidth-1,x),Math.Min(BufferHeight-1,y));
    }
  }
}