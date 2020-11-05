using System;

namespace Snake {
  class Program {
    public static void Main (string[] args) {
      
      Point p1 = new Point(5, 5, '$');
      p1.Draw();

      Point p2 = new Point(3, 3, '#');
      p2.Draw();


      Console.ReadLine();
    }
  }
}
