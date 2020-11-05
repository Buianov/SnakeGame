using System;

namespace Snake {
  class Point {
    public int x;
    public int y;
    public char sym;

    public Point(Point p) {
      x = p.x;
      y = p.y;
      sym = p.sym;
    }

    public Point(int _x, int _y, char _sym) {
      x = _x;
      y = _y;
      sym = _sym;
    }

    public void Draw() {
      Console.SetCursorPosition(x, y);
      Console.Write(sym);
    }

    public void Clear() {
      sym = ' ';
      Draw();
    }

    public void Move(int offset, Direction dir) {
      switch (dir) {
        case Direction.RIGHT:
          x += offset;
          break;
        case Direction.LEFT:
          x -= offset;
          break;
        case Direction.UP:
          y -= offset;
          break;
        case Direction.DOWN:
          y += offset;
          break;
      }
    }
  }
}