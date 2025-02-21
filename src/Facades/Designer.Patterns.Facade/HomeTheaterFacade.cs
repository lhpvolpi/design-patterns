namespace Designer.Patterns.Facade;

public class Amplifier
{
    public void On()
        => Console.WriteLine("On");
}

public class Tuner
{
    public void Tune()
        => Console.WriteLine("Tune");
}

public class Speaker
{
    public void SetVolume(int level)
        => Console.WriteLine($"Set volume: {level}.");
}

public class HomeTheaterFacade
{
    private readonly Amplifier _amplifier = new();
    private readonly Tuner _tuner = new();
    private readonly Speaker _speaker = new();

    public void WatchMovie()
    {
        this._amplifier.On();
        this._tuner.Tune();
        this._speaker.SetVolume(10);

        Console.WriteLine("Start watching movie.");
    }
}
