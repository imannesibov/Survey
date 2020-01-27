using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survey
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Survey_Enter(object sender, EventArgs e)
        {

        }

        private void Survey_Enter_1(object sender, EventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {

            Customer customer = new Customer();

            customer.Name = name.Text;
            customer.Surname = surname.Text;
            customer.FatherName = dadname.Text;
            customer.Country = countryText.Text;
            customer.City = cityText.Text;
            customer.Phone = phoneText.Text;
            customer.BirthDay = birthdaycl.Value;
            Gender gender;


            if (malegender.Checked)
            {
                gender = Gender.Male;
            }
            else
            {
                gender = Gender.Female;
            }


            customer.Gender = gender;

           
            if (name.Text != String.Empty && surname.Text != String.Empty && dadname.Text != String.Empty && countryText.Text != String.Empty && cityText.Text != String.Empty && phoneText.Text != String.Empty)
            {
                var json = JsonConvert.SerializeObject(customer);
                File.WriteAllText($"{customer.Name}.json", json);

                MessageBox.Show("Succesfully saved");
                name.Text = String.Empty;
                surname.Text = String.Empty; 
                dadname.Text = String.Empty; 
                countryText.Text = String.Empty;
                cityText.Text = String.Empty;
                phoneText.Text = String.Empty;
                birthdaycl.Value = DateTime.Now;
                malegender.Checked = false;
                femalegender.Checked = false;
            }
            else
            {
                MessageBox.Show("Not saved");
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
             

            if (File.Exists($"{customerText.Text}.json") && customerText.Text != "")
            {

                var obj = File.ReadAllText($"{customerText.Text}.json");

                Customer customer = JsonConvert.DeserializeObject<Customer>(obj);

                name.Text = customer.Name;
                surname.Text = customer.Surname;
                dadname.Text = customer.FatherName;
                countryText.Text = customer.Country;
                cityText.Text = customer.City;
                phoneText.Text = customer.Phone;
                birthdaycl.Value = customer.BirthDay;

                if (customer.Gender == Gender.Male)
                {
                    malegender.Checked = true;
                }
                else
                {
                    femalegender.Checked = true;
                }

            }
            else
            {
                MessageBox.Show("Not found");
            }

           

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }



}
