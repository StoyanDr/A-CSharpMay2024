using P01.Stream_Progress.Models.Interfaces;

namespace P01.Stream_Progress.Models;

public class StreamProgressInfo
{
    private IStreamable streamable;

    // If we want to stream a music file, we can't
    public StreamProgressInfo(IStreamable streamable)
    {
        this.streamable = streamable;
    }

    public int CalculateCurrentPercent()
    {
        return streamable.BytesSent * 100 / streamable.Length;
    }
}
