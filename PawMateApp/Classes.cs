using System.Drawing;
using System.Windows.Forms;

namespace PawMateApp
{
    public class MoveForm
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private Form form;

        public MoveForm(Form form)
        {
            this.form = form;
        }

        public void Form_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = form.Location;
        }

        public void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = new Point(Cursor.Position.X - dragCursorPoint.X, Cursor.Position.Y - dragCursorPoint.Y);
                form.Location = new Point(dragFormPoint.X + diff.X, dragFormPoint.Y + diff.Y);
            }
        }

        public void Form_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
    public class CheckInputs
    {
        private string[] strings;
        /// <param name="Inputs">txt_degiskenismi.Text olarak değerleri array şeklinde girin.</param
        public CheckInputs(string[] Inputs)
        {

            this.strings = Inputs;
        }
        /// 
        /// <returns>Boş alan olursa messagebox ile false döner, boş alan yok ise true ile messagebox döner</returns>
        public bool Check(string MessageBoxTextForSuccess)
        {
            foreach (string input in strings)
            {
                if (string.IsNullOrEmpty(input))
                {
                    MessageBox.Show("Lütfen boş alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            if (MessageBoxTextForSuccess == "")
            {
                return true;
            }
            else
            {
                MessageBox.Show(MessageBoxTextForSuccess, "Başarılı", MessageBoxButtons.OK);
                return true;
            }
        }
    }
}
