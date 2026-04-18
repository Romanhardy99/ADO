using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
    public partial class HumanForm : Form
    {
        internal Models.Human human;
        public HumanForm()
        {
            InitializeComponent();
        }

        protected virtual void Compress()
        {
            human = new Models.Human
                (
                Convert.ToInt32(labelID.Text == "" ? "0" : labelID.Text.Split(':').Last()),
                textBoxLastName.Text,
                textBoxFirstName.Text,
                textBoxMiddleName.Text,
                dtpBirthDate.Value.ToString("yyyy-MM-dd"),
                textBoxEmail.Text,
                textBoxPhone.Text,
                pictureBoxPhoto.Image);
        }

        protected virtual void Extract()
        {
            labelID.Text = $"ID:{human.id}";
            textBoxLastName.Text = human.last_name;
            textBoxFirstName.Text = human.first_name;
            textBoxMiddleName.Text = human.middle_name;
            dtpBirthDate.Value = Convert.ToDateTime(human.birth_date);
            textBoxEmail.Text = human.email;
            textBoxPhone.Text = human.phone;
        }

        protected virtual void buttonOK_Click(object sender, EventArgs e)
        {
            Compress();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            //ofd.Title = "Выберите фотографию";
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPhoto.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
