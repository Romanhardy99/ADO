using Academy.Models;
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
    public partial class TeacherForm : HumanForm
    {
        Models.Teacher teacher;
        public TeacherForm()
        {
            InitializeComponent();
        }
        public TeacherForm(int id) : this()
        {
            DataTable table = DataBase.Connector.Load($"SELECT * FROM Teachers WHERE teacher_id={id}");
            teacher = new Models.Teacher(table.Rows[0].ItemArray);
            human = teacher;
            Extract();
        }

        protected override void Extract()
        {
            base.Extract();
            dtpWorkSince.Value = Convert.ToDateTime(teacher.work_since);
            textBoxRate.Text = teacher.rate.ToString();
        }

        protected override void buttonOK_Click(object sender, EventArgs e)
        {
            base.buttonOK_Click(sender, e);
            decimal rate;
            decimal.TryParse(textBoxRate.Text.Replace(',', '.'), out rate);
            teacher = new Models.Teacher(human, dtpWorkSince.Value.ToString("yyyy-MM-dd"), rate);
            if (teacher.id == 0) teacher.id =
                   Convert.ToInt32(DataBase.Connector.Scalar
                    (
                    $"INSERT Teachers({teacher.GetNames()}) VALUES ({teacher.GetValues()});SELECT SCOPE_IDENTITY();"
                    ));
            else
            {
                DataBase.Connector.Update($"UPDATE Teachers SET {teacher.GetUpdateString()} WHERE teacher_id={teacher.id}");
            }
        }
    }
}
