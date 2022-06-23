using System.Collections.Generic;

namespace TDDMicroExercises.LeaderBoard
{
  public class Race
  {
    /*
    Encapsulamento dos Campos fornecendo metodos de acesso
    Renomeei funcoes
    Usei Interface como parametros das funcoes ao inves da class
    */
    private int[] _points = { 25, 18, 15 };
    private Dictionary<IDriver, string> _driverNames = new Dictionary<IDriver, string>();
    private string _name;
    private List<IDriver> _results = new List<IDriver>();

    public Race(string name, params IDriver[] Idrivers)
    {
      this._name = name;
      this._results.AddRange(Idrivers);

      foreach (var driver in Idrivers)
      {
        _driverNames.Add(driver, driver.Name);
      }
    }

    public int GetPosition(IDriver Idriver)
    {
      return this._results.FindIndex(d => Equals(d, Idriver));
    }

    public int GetPoints(IDriver Idriver)
    {
      return this._points[this.GetPosition(Idriver)];
    }

    public string GetDriverName(IDriver Idriver)
    {
      return this._driverNames[Idriver];
    }

    public List<IDriver> GetResults()
    {
      return this._results;
    }
  }
}