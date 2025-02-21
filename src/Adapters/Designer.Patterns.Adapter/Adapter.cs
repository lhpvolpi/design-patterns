namespace Designer.Patterns.Adapter;

public class Adapter
{
    public Adapter()
    {
        var oldAdapter = new OldAdapter();
        var newAdapter = new NewAdapter(oldAdapter);
        newAdapter.SendRequest();
    }
}
