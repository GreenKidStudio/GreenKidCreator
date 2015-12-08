namespace GreenKidEditor.Utils
{
    public struct MathVector
    {
        public float X;
        public float Y;
        public float Z;

        public MathVector(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public void SetX(float x)
        {
            X = x;
        }

        public void SetY(float y)
        {
            Y = y;
        }

        public void SetZ(float z)
        {
            Z = z;
        }
    }
}