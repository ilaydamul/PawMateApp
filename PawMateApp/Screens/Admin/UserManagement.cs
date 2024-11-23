using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PawMateApp.Screens.Admin
{
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            //Ekrana gelindiğinde kullanıcılar userListte görünecek
            //Listede herhangi bir kullanıcıya tıklanılınca soldaki inputlar dolacak. Değişiklik yapıldığında güncelleme yapılacak
            //Dikkat! Üstüne tıklanıldığında ve input içerikleri silindiğinde uyarı verilmeli, dolu olan veriler boş kaydedilmemeli!

            //İşletmeler cb_businesses içine gelmeli
        }

        private void btn_addUser_Click(object sender, EventArgs e)
        {
            //Soldaki input alanlarının içi temizlenmeli, btn_addUpdateUser buton Texti Ekle olmalı, herhangi listede -
            //bir işletmeye tıklanıldığında Güncelle yazmalı.
        }
    }
}
