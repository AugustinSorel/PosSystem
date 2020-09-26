using System.Windows.Forms;

namespace PosSystem
{
    class MenuPageLabelEffect
    {
        public static void MouseEnter(Label label2)
        {
            label2.Font = GetUnderLineFont(label2);
            Form.ActiveForm.Cursor = Cursors.Hand;
        }

        public static void MouseLeave(Label label2)
        {
            label2.Font = GetRegularFont(label2);
            Form.ActiveForm.Cursor = Cursors.Default;
        }

        private static System.Drawing.Font GetRegularFont(Label label)
        {
            return new System.Drawing.Font(label.Font, System.Drawing.FontStyle.Regular);
        }

        private static System.Drawing.Font GetUnderLineFont(Label label)
        {
            return new System.Drawing.Font(label.Font, System.Drawing.FontStyle.Underline);
        }
    }
}
