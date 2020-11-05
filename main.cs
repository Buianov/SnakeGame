using System;
using System.Collections.Generic;

namespace Snake {
  class Program {
    public static void Main (string[] args) {
      
      HorizontalLine hLine1 = new HorizontalLine(1, 15, 2, '-');
      hLine1.Draw();

      HorizontalLine hLine2 = new HorizontalLine(1, 15, 10, '-');
      hLine2.Draw();

      VerticalLine vLine1 = new VerticalLine(2, 10, 1, '|');
      vLine1.Draw();

      VerticalLine vLine2 = new VerticalLine(2, 10, 15, '|');
      vLine2.Draw();

      Console.ReadLine();
    }
  }
}
