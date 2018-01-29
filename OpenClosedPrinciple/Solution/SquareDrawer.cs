namespace SolidExamples.OpenClosedPrinciple.Solution
{
    public class SquareDrawer : IDrawer
    {
        private readonly Square _square;
        public SquareDrawer(Square square)
        {
            _square = square;
        }

       private void drawLine(int xa, int ya, int xb, int yb)
        {
            //Do something;
        }

        public void Draw()
        {
            drawLine(0, 0, _square.SideLength, 0);
            drawLine(0, 0, 0, _square.SideLength);
            drawLine(0, _square.SideLength, _square.SideLength, _square.SideLength);
            drawLine(_square.SideLength, 0, _square.SideLength, _square.SideLength);
             //diagonal
            drawLine(0, 0, _square.SideLength,  _square.SideLength);
        }
    }
}