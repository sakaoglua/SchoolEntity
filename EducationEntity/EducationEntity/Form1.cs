using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationEntity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SchoolDal _schoolDal = new SchoolDal();
        public void Form1_Load(object sender, EventArgs e)
        {
            LoadSchools();
        }

        private void LoadSchools()
        {
            dgwSchool.DataSource = _schoolDal.GetAll();
        }

        public void btnAdd_Click(object sender, EventArgs e)
        {
            _schoolDal.Add(new School
            {
                Name = txtboxName.Text,
                City = txtboxCity.Text,
                District = txtboxDistrict.Text,
                Type = txtboxType.Text
            });
            LoadSchools();
            MessageBox.Show("School added!");
        }

        public void dgwSchool_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtboxUName.Text = dgwSchool.CurrentRow.Cells[1].Value.ToString();
            txtboxUCity.Text = dgwSchool.CurrentRow.Cells[2].Value.ToString();
            txtboxUDistrict.Text = dgwSchool.CurrentRow.Cells[3].Value.ToString();
            txtboxUType.Text = dgwSchool.CurrentRow.Cells[4].Value.ToString();
        }

        public void btnUpdate_Click(object sender, EventArgs e)
        {
            _schoolDal.Update(new School
            {
                Id = Convert.ToInt32(dgwSchool.CurrentRow.Cells[0].Value),
                Name = txtboxUName.Text,
                City = txtboxUCity.Text,
                District = txtboxUDistrict.Text,
                Type = txtboxUType.Text
            });
            LoadSchools();
            MessageBox.Show("School updated!");
        }

        public void btnDelete_Click(object sender, EventArgs e)
        {
            _schoolDal.Delete(new School
            {
                Id = Convert.ToInt32(dgwSchool.CurrentRow.Cells[0].Value)
            });
            LoadSchools();
            MessageBox.Show("School deleted!");
        }
    }
}
