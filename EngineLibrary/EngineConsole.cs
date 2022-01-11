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
    public static List<string> PreviousResponses = new List<string>(30);
    public static string GetLine(uint length = 0)
    {
      int maxLength = (int)Math.Clamp(3,length,50);
      ConsoleKeyInfo key;
      int keyStrokeLength = 0;
      string result = "";
      bool done = false;
      NOT_DONE:
      key = ReadKey(true);
      switch(key.Key.ToString())
      {
        case "Enter":
          //
          break;
        case "Spacebar":
          //
          break;
        case "Tab":
          //
          break;
        case "UpArrow":
          //
          break;
        case "DownArrow":
          //
          break;
        case "Backspace":
          if(result.Length >= 1) result = result.Remove(result.Length - 1 , 1);
          break;
        case "Shift":
          //
          break;
        case "Control":
          //
          break;
        case "Alt":
          //
          break;
        case "Escape":
          //
          break;
        default:
          //
          break;
      }
      //
      //
      DONE:
      return result;
    }
  }
  // public class KeySet : List<KeyBind>
  // {
  //   // private 
  // }
  public struct KeyBind
  {
    public Action keyAction;
    public string keyName;
    public KeyBind(string key, Action action)
    {
      keyName = key;
      keyAction = action;
    }
    public bool Match(ConsoleKeyInfo cki)
    {
      bool result = cki.Key.ToString().Equals(keyName);
      if(result) keyAction();
      return result;
    }
    public void Deconstruct(out string key, out Action binding)
    {
      key = keyName;
      binding = keyAction;
    }
    public static explicit operator KeyBind((string keyName, Action keyAction) pair) => new KeyBind(pair.keyName, pair.keyAction);
    public static implicit operator (string keyName, Action keyAction)(KeyBind kb) => (kb.keyName, kb.keyAction);
  }
}