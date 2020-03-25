using System;
using System.Diagnostics;

class MainClass {

  
  public static void Main (string[] args) {
    Stopwatch sw = new Stopwatch();

    
    for (int x = 5; x < 50; x = x+5) {
      sw.Reset();
      sw.Start();
      int fib = fibrecurse (x, false);
      sw.Stop();
      Console.WriteLine("Recursive {1}th Fib={2}, Elapsed={0}",sw.Elapsed, x, fib);
    }

    Console.WriteLine ("\n\n");
    
    for (int x = 5; x < 50; x = x+5) {
      sw.Reset();
      sw.Start();
      int fib = fibiterate (x, false);
      sw.Stop();
      Console.WriteLine("Iterative {1}th Fib={2}, Elapsed={0}",sw.Elapsed, x, fib);
    }

  }

//
// Return the xth fibanacci number using recursion
// If print set to true, print out debug 
//
  static int fibrecurse (int x, bool print = false) {


    int fib = 0;

    fib = fibadd(x-2) + fibadd(x-1);
    
    static int fibadd(int x)
    {
      if (x==1)
        return 0;
      else if (x==2)
        return 1;
      return fibadd(x-2) + fibadd(x-1)
    }
    
    if (print == true)
      Console.Write ("Fibanacci = {0}\n", fib);
    return (fib);
  }

//
// Return the xth fibanacci number using iteration
// If print set to true, print out debug 
//

  static int fibiterate (int x, bool print = false) {
    int [] fiblist = new int [100];
    
    fiblist [0] = 0;
    fiblist [1] = 1;
    
    for (int i = 2; i < x; i++)
    {
      fiblist[i] = fiblist[i-2] + fiblist[i-1];
    }
  
    if (print == true)
      Console.Write ("Fibanacci = {0}\n", fiblist[x-1]);
    return (fiblist[x-1]);
  }
}
