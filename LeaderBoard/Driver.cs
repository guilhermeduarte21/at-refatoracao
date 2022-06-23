namespace TDDMicroExercises.LeaderBoard
{
  public class Driver : IDriver
  {
    /*
    Encapsular Campo fornecendo metodos de acesso
    Implementar interface
    */
    private string _name;
    private string _country;

    public string Name { get => _name; }
    public string Country { get => _country; }

    public Driver(string name, string country)
    {
      this._name = name;
      this._country = country;
    }
  }
}