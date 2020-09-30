namespace PosSystem
{
    class MenuSetLocation
    {
        public static System.Drawing.Point SetLabelLocation(int menuWidth, int labelWidth)
        {
            return new System.Drawing.Point(menuWidth / 2 - labelWidth /2, 30);
        }

        public static System.Drawing.Point SetButtonLocation(int menuWidth, int buttonWidth, int yInterval)
        {
            return new System.Drawing.Point(menuWidth / 2 - buttonWidth / 2, yInterval);
        }

        public static System.Drawing.Point SetPictureBoxLocation(int yLocation, int buttonHeight)
        {
            return new System.Drawing.Point(0, yLocation / 2 - buttonHeight / 2);
        }
    }
}
