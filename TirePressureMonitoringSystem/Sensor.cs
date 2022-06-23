using System;

namespace TDDMicroExercises.TirePressureMonitoringSystem
{
  public class Sensor : ISensor
  {
    //Encapsular Campo
    //Implementacao de interface
    //removi metodos estaticos
    private double offset = 16;

    public double PopNextPressurePsiValue()
    {
      var pressureTelemetryValue = this.SamplePressure();

      return this.offset + pressureTelemetryValue;
    }

    private double SamplePressure()
    {
      Random basicRandomNumbersGenerator = new Random();
      double pressureTelemetryValue = Math.Floor(6 * basicRandomNumbersGenerator.NextDouble() * basicRandomNumbersGenerator.NextDouble());

      return pressureTelemetryValue;
    }
  }
}
