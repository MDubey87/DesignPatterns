namespace BridgePattern.BridgeInterface
{
    /// <summary>
    /// Bridge Interface
    /// </summary>
    public interface IDrawingEngine
    {
        void DrawCircle(int radius, int x, int y);
        void DrawSquare(int side, int x, int y);
    }
}
