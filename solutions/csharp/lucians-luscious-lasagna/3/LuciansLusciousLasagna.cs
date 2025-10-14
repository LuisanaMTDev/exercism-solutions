class Lasagna
{
    public int ExpectedMinutesInOven() => 40;

    public int RemainingMinutesInOven(int minutesInOven) => ExpectedMinutesInOven() - minutesInOven;

    public int PreparationTimeInMinutes(int lasagnaLayers) => lasagnaLayers * 2;

    public int ElapsedTimeInMinutes(int lasagnaLayers, int minutesInOven) => PreparationTimeInMinutes(lasagnaLayers) + minutesInOven;
}
