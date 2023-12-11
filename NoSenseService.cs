namespace ClassLibraryRelease;

public class NoSenseService
{
    public ValueTask<bool> IsSense()
    {
        return ValueTask.FromResult(true);
    }

    public ValueTask<bool> IsNosense()
    {
        return ValueTask.FromResult(false);
    }
}