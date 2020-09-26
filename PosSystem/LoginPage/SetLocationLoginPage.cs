namespace PosSystem
{
    static class SetLocationLoginPage
    {
        public static System.Drawing.Point SetLabelLocation(int LoginPageWidth, int Label1Width)
        {
            return new System.Drawing.Point(LoginPageWidth / 2 - Label1Width / 2, 10);
        }

        public static System.Drawing.Point SetButtonLocation(int LoginPageWidth, int Button1Width)
        {
            return new System.Drawing.Point(LoginPageWidth / 2 - Button1Width / 2, 330);
        }
    }
}
