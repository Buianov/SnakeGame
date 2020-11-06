using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Snake {
  class Program {
    public static void Main (string[] args) {
      
      //create borders
      HorizontalLine hLine1 = new HorizontalLine(0, 30, 2, '+');
      HorizontalLine hLine2 = new HorizontalLine(0, 30, 20, '+');
      VerticalLine vLine1 = new VerticalLine(2, 20, 0, '+');
      VerticalLine vLine2 = new VerticalLine(2, 20, 30, '+');

      //draw borders
      hLine1.Draw();
      hLine2.Draw();
      vLine1.Draw();
      vLine2.Draw();

      //create snake
      Point start = new Point(5, 5, '*');
      Snake sn = new Snake(start, 7, Direction.RIGHT);
      sn.Draw();

      while(true) {
        if (Console.KeyAvailable) {
          ConsoleKeyInfo key = Console.ReadKey();
          sn.HandleKey(key.Key);
        }
      
      System.Threading.Thread.Sleep(300);
      sn.Move();
      }

      Console.ReadLine();
    }
  }
}
