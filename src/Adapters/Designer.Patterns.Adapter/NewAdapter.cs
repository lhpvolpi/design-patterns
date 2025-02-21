namespace Designer.Patterns.Adapter;

public interface INewAdapter
{
    void SendRequest();
}

public class OldAdapter
{
    public static void OldRequest() => Console.WriteLine("Executing OldRequest");
}

public class NewAdapter : INewAdapter
{
    private readonly OldAdapter _oldAdapter;

    public NewAdapter(OldAdapter oldAdapter) => this._oldAdapter = oldAdapter;

    public void SendRequest() => OldAdapter.OldRequest();
}
