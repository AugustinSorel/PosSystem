using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace PosSystem
{
    internal class CreateReceipt
    {
        private readonly ListView listView1;
        private readonly string workerID;
        private readonly string date;
        private readonly Font font = new Font("Courier New", 12);
        private Graphics graphic;

        private const int startX = 10;
        private const int startY = 10;
        private int offset = 40;
        private float cash = 50; // Change this
        private float totalprice = 0.00f;
        private float change = 0;
        private float fontHeight = 0;

        public CreateReceipt(ListView listView1, string workerID, string date)
        {
            this.listView1 = listView1;
            this.workerID = workerID;
            this.date = date;

            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument;
            printDocument.PrintPage += new PrintPageEventHandler(GenerateReceipt);

            DialogResult result = printDialog.ShowDialog();
            if (result == DialogResult.OK)
                printDocument.Print();
        }

        public void GenerateReceipt(object sender, PrintPageEventArgs e)
        {
            graphic = e.Graphics;
            fontHeight = font.GetHeight();

            DrawTop();
            DrawItems();
            DrawBottom();
        }

        private void DrawBottom()
        {
            graphic.DrawString("Total to pay ".PadRight(30) + String.Format("{0:c}", totalprice), new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);

            offset += 30;
            graphic.DrawString("CASH ".PadRight(30) + String.Format("{0:c}", cash), font, new SolidBrush(Color.Black), startX, startY + offset);
            offset += 15;
            graphic.DrawString("CHANGE ".PadRight(30) + String.Format("{0:c}", change), font, new SolidBrush(Color.Black), startX, startY + offset);
            offset += 30;

            graphic.DrawString("WORKER ID ".PadRight(30) + String.Format("{0:c}", workerID), font, new SolidBrush(Color.Black), startX, startY + offset);
            offset += 15;
            graphic.DrawString("DATE ".PadRight(30) + String.Format("{0:c}", date), font, new SolidBrush(Color.Black), startX, startY + offset);
            offset += 30;


            graphic.DrawString("     Thank-you for your custom,", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset += 15;
            graphic.DrawString("       please come back soon!", font, new SolidBrush(Color.Black), startX, startY + offset);
        }

        private void DrawItems()
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                string productBarCode = listView1.Items[i].SubItems[0].Text;
                string quantity = listView1.Items[i].SubItems[1].Text;
                float productPrice = float.Parse(listView1.Items[i].SubItems[3].Text);

                totalprice += productPrice;

                string productLine = productBarCode;

                graphic.DrawString(productLine, font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(quantity, font, new SolidBrush(Color.Black), startX + 200, startY + offset);
                graphic.DrawString(productPrice.ToString(), font, new SolidBrush(Color.Red), startX + 325, startY + offset);

                offset = offset + (int)fontHeight + 5;
            }

            change = cash - totalprice;
            offset += 20;
        }

        private void DrawTop()
        {
            graphic.DrawString(" Toy Shop Test", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);
            string top = "Item CodeBar".PadRight(15) + "Quantity".PadRight(15) + "Price";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)fontHeight;
            graphic.DrawString("-----------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
        }
    }
}