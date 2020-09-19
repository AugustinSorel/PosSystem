using System.Drawing;

namespace PosSystem
{
    class SetLocationLoginPage
    {
        public static Point SetLabel1Location()
        {
            LoginPage loginPage = new LoginPage();
            return new Point(loginPage.GetLoginPageWidth/ 2 - loginPage.GetLoginPageLabel1.Width / 2, 50);
        }
    }
}
