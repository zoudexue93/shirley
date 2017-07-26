using System;
using System.Collections.Generic;

namespace SeeSharp7Features
{
  public class SeeSharp7Test
  {
    public void MySeeSharp7Method()
    {
      var dict = new Dictionary<string, string> {{"test", "value"}};
      dict.TryGetValue("test", out string value);

      Console.WriteLine(value);
      Console.ReadLine();
    }
  }
}