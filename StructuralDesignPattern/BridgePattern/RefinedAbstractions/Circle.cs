using BridgePattern.Abstraction;
using BridgePattern.BridgeInterface;

namespace BridgePattern.RefinedAbstractions
{
    /// <summary>
    /// Refined Abstractions
    /// </summary>
    public class Circle : Shape
    {
        private int radius;
        private int x;
        private int y;

        public Circle(int radius, int x, int y, IDrawingEngine drawingEngine) : base(drawingEngine)
        {
            this.radius = radius;
            this.x = x;
            this.y = y;
        }

        public override void Draw()
        {
            drawingEngine.DrawCircle(radius, x, y);
        }
    }
}
