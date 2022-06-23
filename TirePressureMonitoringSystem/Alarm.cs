namespace TDDMicroExercises.TirePressureMonitoringSystem
{
  public class Alarm
  {
    private double LowPressureThreshold;
    private double HighPressureThreshold;

    private ISensor sensor;
    private bool alarmOn;

    public Alarm(ISensor sensor)
    {
      this.LowPressureThreshold = 17;
      this.HighPressureThreshold = 21;
      this.sensor = sensor;
      this.alarmOn = false;
    }

    public void Check()
    {
      double psiPressureValue = this.sensor.PopNextPressurePsiValue();

      if (psiPressureValue < LowPressureThreshold ||
      HighPressureThreshold < psiPressureValue)
      {
        this.alarmOn = true;
      }
    }

    public bool AlarmOn()
    {
      return this.alarmOn;
    }
  }
}
