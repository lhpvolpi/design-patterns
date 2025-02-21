namespace Designer.Patterns.Facade;

public class Facade
{
    public Facade()
    {
        var homeTheater = new HomeTheaterFacade();
        homeTheater.WatchMovie();
    }
}
