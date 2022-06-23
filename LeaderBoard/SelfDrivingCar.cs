namespace TDDMicroExercises.LeaderBoard
{
  public class SelfDrivingCar : IDriver
  {
    //Implementar Interface
    private string _algorithmVersion;
    private string _company;

    public SelfDrivingCar(string algorithmVersion, string company)
    {
      this._company = company;
      this.AlgorithmVersion = algorithmVersion;
    }

    public string AlgorithmVersion { set => _algorithmVersion = value; }

    string IDriver.Name => "Self Driving Car - " + this._company + " (" + this._algorithmVersion + ")";
  }
}