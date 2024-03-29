public static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
  {
      if (y1 > y2) { 
          return 10000;
      };
      
      if (m1 > m2 && y1 > y2) {
          return Math.Abs(m1 - m2) % 12 * 500;
      }
      
      if (d1 > d2 && m1 == m2 && y1 > y2) {
          return Math.Abs(d1 - d2) % 31 * 15;
      }
      
      return 0;
  }
