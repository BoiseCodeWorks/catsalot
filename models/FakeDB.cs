using System.Collections.Generic;
using catsalot.Models;

namespace catsalot.Db
{
  static class FakeDB
  {
    public static List<Cat> Cats = new List<Cat>(){
      new Cat("Sir Meowsalot", 4),
      new Cat("King Arpurr", 3),
      new Cat("Meowlin", 100)
  };
  }
}