using BridgePattern.BridgeInterface;

namespace BridgePattern.Implementor
{
    /// <summary>
    /// Concrete Implementors
    /// </summary>
    public class DrawingEngineA : IDrawingEngine
    {
        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine($"Drawing Circle with Engine A: Radius={radius}, X={x}, Y={y}");
        }
        public void DrawSquare(int side, int x, int y)
        {
            Console.WriteLine($"Drawing Square with Engine A: Side={side}, X={x}, Y={y}");
        }
    }
}
