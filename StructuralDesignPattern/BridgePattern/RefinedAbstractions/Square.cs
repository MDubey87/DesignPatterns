using BridgePattern.Abstraction;
using BridgePattern.BridgeInterface;

namespace BridgePattern.RefinedAbstractions
{
    /// <summary>
    /// Refined Abstractions
    /// </summary>
    public class Square : Shape
    {
        private int side;
        private int x;
        private int y;

        public Square(int side, int x, int y, IDrawingEngine drawingEngine) : base(drawingEngine)
        {
            this.side = side;
            this.x = x;
            this.y = y;
        }

        public override void Draw()
        {
            drawingEngine.DrawSquare(side, x, y);
        }
    }
}
