class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
      return 40;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int minutesInOven)
    {
      return ExpectedMinutesInOven() - minutesInOven;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int lasagnaLayers)
    {
      return lasagnaLayers * 2;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int lasagnaLayers, int minutesInOven)
    {
      return PreparationTimeInMinutes(lasagnaLayers) + minutesInOven;
    }
}
