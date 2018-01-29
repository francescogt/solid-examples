using System;

namespace SolidExamples.OpenClosedPrinciple.Solution
{
    public class CircleDrawer : IDrawer
    {

        private readonly Circle _circle;

        public CircleDrawer(Circle circle)
        {
            _circle = circle;
        }

        public void Draw()
        {
            DrawCircle(_circle.Radius);
        }

        private void DrawCircle(int radius)
        {
            throw new NotImplementedException();
        }
    }
}