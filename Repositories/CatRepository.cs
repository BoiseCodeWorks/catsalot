using System;
using System.Collections.Generic;
using catsalot.Db;
using catsalot.Models;

namespace catsalot.Repositories
{
  public class CatRepository
  {
    // private readonly FakeDB _db;

    public IEnumerable<Cat> GetAll()
    {
      return _db.Query<IEnumerable<Cat>>(@"
      SELECT * FROM Cats;
      ")



    }

    public Cat GetCatById(int id)
    {
      try
      {
        return FakeDB.Cats[id];
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return null;
      }
    }

    public Cat AddCat(Cat newcat)
    {
      FakeDB.Cats.Add(newcat);
      return newcat;
    }

    public Cat EditCat(int id, Cat newcat)
    {
      try
      {
        FakeDB.Cats[id] = newcat;
        return newcat;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return null;
      }
    }


    public bool DeleteCat(int id)
    {
      try
      {
        FakeDB.Cats.Remove(FakeDB.Cats[id]);
        return true;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return false;
      }
    }







    public CatRepository()
    {

    }
  }
}