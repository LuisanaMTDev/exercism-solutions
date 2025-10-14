class Lasagna
{
    public int ExpectedMinutesInOven() => 40;

    public int RemainingMinutesInOven(int minutesInOven)
    {
      return ExpectedMinutesInOven() - minutesInOven;
    }

    public int PreparationTimeInMinutes(int lasagnaLayers)
    {
      return lasagnaLayers * 2;
    }

    public int ElapsedTimeInMinutes(int lasagnaLayers, int minutesInOven)
    {
      return PreparationTimeInMinutes(lasagnaLayers) + minutesInOven;
    }
}
