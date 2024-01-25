using BridgePattern.BridgeInterface;

namespace BridgePattern.Abstraction
{
    /// <summary>
    /// Abstraction Class
    /// </summary>
    public abstract class Shape
    {
        protected IDrawingEngine drawingEngine;

        protected Shape(IDrawingEngine drawingEngine)
        {
            this.drawingEngine = drawingEngine;
        }

        public abstract void Draw();
    }
}
