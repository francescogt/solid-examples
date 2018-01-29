using System;

namespace SolidExamples.OpenClosedPrinciple.Violation
{
    public class CircleDrawer
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