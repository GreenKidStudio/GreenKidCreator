namespace GreenKidEditor.Utils
{
    public struct Color
    {
        public int R;
        public int G;
        public int B;
        public int A;

        public Color(int r, int g , int b, int a = 255)
        {
            R = r;
            G = g;
            B = b;
            A = a;
        }

        public void SetR(int r) 
        {
            R = r;
        }

        public void SetG(int g)
        {
            G = g;
        }

        public void SetB(int b)
        {
            B = b;
        }

        public void SetA(int a)
        {
            A = a;
        }

        public static Color White
        {
            get
            {
                Color c;

                c.R = 255;
                c.G = 255;
                c.B = 255;
                c.A = 255;

                return c;
            }
        }

        public static Color Black
        {
            get
            {
                Color c;

                c.R = 0;
                c.G = 0;
                c.B = 0;
                c.A = 255;

                return c;
            }
        }

        public static Color Red
        {
            get
            {
                Color c;

                c.R = 255;
                c.G = 0;
                c.B = 0;
                c.A = 255;

                return c;
            }
        }

        public static Color Green
        {
            get
            {
                Color c;

                c.R = 0;
                c.G = 255;
                c.B = 0;
                c.A = 255;

                return c;
            }
        }

        public static Color Blue
        {
            get
            {
                Color c;

                c.R = 0;
                c.G = 0;
                c.B = 255;
                c.A = 255;

                return c;
            }
        }
    }
}