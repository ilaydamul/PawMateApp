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
    public partial class BusinessManagement : Form
    {
        public BusinessManagement()
        {
            InitializeComponent();
        }

        //Ekrana gelindiğinde işletme bilgileri businessesList'de görünecek
        //Listede herhangi bir işletmeye tıklanılınca soldaki inputlar dolacak. Değişiklik yapıldığında güncelleme yapılacak
        //Dikkat! Üstüne tıklanıldığında ve input içerikleri silindiğinde uyarı verilmeli, dolu olan veriler boş kaydedilmemeli!
        private void btn_addUpdateBusiness_Click(object sender, EventArgs e)
        {

        }

        private void btn_addBusiness_Click(object sender, EventArgs e)
        {
            //Soldaki input alanlarının içi temizlenmeli, btn_addUpdateBusiness buton Texti Ekle olmalı, herhangi listede -
            //bir işletmeye tıklanıldığında Güncelle yazmalı.
        }
    }
}
