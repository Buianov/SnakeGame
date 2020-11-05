using System;

namespace Snake {
  class Program {
    public static void Main (string[] args) {
      
      Point p1 = new Point();
      p1.x = 5;
      p1.y = 5;
      p1.sym = '^';
      p1.Draw();

      Console.ReadLine();
    }
  }
}
