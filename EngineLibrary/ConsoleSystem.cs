using System;

namespace EngineLibrary
{
  struct ConsoleStyle
  {
    public ConsoleColor Foreground;
    public ConsoleColor Background;
    public ConsoleStyle(ConsoleColor fG, ConsoleColor bG)
    {
      Foreground = fG;
      Background = bG;
    }
  }
}