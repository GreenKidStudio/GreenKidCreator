namespace GreenKidEditor.MainWindow.Panels.Transform
{
    public struct MathVector
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public MathVector(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}