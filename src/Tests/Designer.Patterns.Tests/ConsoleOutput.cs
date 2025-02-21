namespace Designer.Patterns.Tests;

public class ConsoleOutput : IDisposable
{
    private readonly StringWriter _stringWriter;
    private readonly TextWriter _originalOutput;

    public ConsoleOutput()
    {
        this._stringWriter = new StringWriter();
        this._originalOutput = Console.Out;

        Console.SetOut(this._stringWriter);
    }

    public string GetOutput() => this._stringWriter.ToString();

    public void Dispose()
    {
        Console.SetOut(this._originalOutput);
        this._stringWriter.Dispose();
        GC.SuppressFinalize(this);
    }
}
