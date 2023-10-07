using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinForms_C__LESSON_2._1
{
    public partial class Form1 : Form
    {
        public List<Person> persons = new();
        public List<Country> countrys = new List<Country>();

        public Form1()
        {
            InitializeComponent();
            countrys = JsonSerializer.Deserialize<List<Country>>(File.ReadAllText("../../../Olkeler.json"));
            persons = JsonSerializer.Deserialize<List<Person>>(File.ReadAllText("../../../Persons.json"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aramaTextBox_TextChanged(object sender, EventArgs e)
        {

            if (aramaTextBox.TextLength == 26)
            {

                bool yoxla = true;
                bool y1y = true;
                string gml = "@gmail.com";

                for (int i = 0; i < 26; i++)
                {

                    if (i < 16 && (int)aramaTextBox.Text[i] > 96 && (int)aramaTextBox.Text[i] < 123) { }
                    else if (i > 15 && aramaTextBox.Text[i] == gml[i - 16]) { }
                    else { yoxla = false; break; }
                }

                for (int i = 0; i < persons.Count; i++)
                {
                    if (persons[i].email == aramaTextBox.Text) { y1y = false; }
                }
                if (y1y) { yoxla = false; }

                if (yoxla) { aramaTextBox.ForeColor = Color.Green; }
                else { aramaTextBox.ForeColor = Color.Red; }


            }
            else { aramaTextBox.ForeColor = Color.Red; }
        }

        private void NameTextBox1_TextChanged(object sender, EventArgs e)
        {

            bool yoxla = true;

            for (int i = 0; i < NameTextBox1.TextLength; i++)
            {

                if ((int)NameTextBox1.Text[i] > 96 && (int)NameTextBox1.Text[i] < 123 || (int)NameTextBox1.Text[i] > 64 && (int)NameTextBox1.Text[i] < 91) { }

                else { yoxla = false; break; }
            }

            if (yoxla) { NameTextBox1.ForeColor = Color.Green; }
            else { NameTextBox1.ForeColor = Color.Red; }



        }

        private void SurnameTextBox1_TextChanged(object sender, EventArgs e)
        {
            bool yoxla = true;

            for (int i = 0; i < SurnameTextBox1.TextLength; i++)
            {

                if ((int)SurnameTextBox1.Text[i] > 96 && (int)SurnameTextBox1.Text[i] < 123 || (int)SurnameTextBox1.Text[i] > 64 && (int)SurnameTextBox1.Text[i] < 91) { }

                else { yoxla = false; break; }
            }

            if (yoxla) { SurnameTextBox1.ForeColor = Color.Green; }
            else { SurnameTextBox1.ForeColor = Color.Red; }

        }

        private void VetenTextBox1_TextChanged(object sender, EventArgs e)
        {
            bool yoxla = false;

            for (int i = 0; i < countrys.Count; i++)
            {
                if (countrys[i].name == VetenTextBox1.Text) { yoxla = true; break; }
            }
            if (yoxla) { VetenTextBox1.ForeColor = Color.Green; }
            else { VetenTextBox1.ForeColor = Color.Red; }
        }

        private void EmailTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (EmailTextBox1.TextLength == 26)
            {

                bool yoxla = true;
                string gml = "@gmail.com";

                for (int i = 0; i < 26; i++)
                {

                    if (i < 16 && (int)EmailTextBox1.Text[i] > 96 && (int)EmailTextBox1.Text[i] < 123) { }
                    else if (i > 15 && EmailTextBox1.Text[i] == gml[i - 16]) { }
                    else { yoxla = false; break; }
                }


                for (int i = 0; i < persons.Count; i++)
                {
                    if (persons[i].email == EmailTextBox1.Text) { yoxla = false; }
                }

                if (yoxla) { EmailTextBox1.ForeColor = Color.Green; }
                else { EmailTextBox1.ForeColor = Color.Red; }

                if (aramaTextBox.Text == EmailTextBox1.Text) { EmailTextBox1.ForeColor = Color.Green; }

            }
            else { EmailTextBox1.ForeColor = Color.Red; }
        }


        private void CreatButton1_Click(object sender, EventArgs e)
        {

            bool name = true;
            bool surname = true;
            bool veten = false;
            bool email = true;

            for (int i = 0; i < NameTextBox1.Text.Length; i++)
            {
                if ((int)NameTextBox1.Text[i] > 96 && (int)NameTextBox1.Text[i] < 123 || (int)NameTextBox1.Text[i] > 64 && (int)NameTextBox1.Text[i] < 91) { }
                else { name = false; break; }
            }

            for (int i = 0; i < SurnameTextBox1.TextLength; i++)
            {
                if ((int)SurnameTextBox1.Text[i] > 96 && (int)SurnameTextBox1.Text[i] < 123 || (int)SurnameTextBox1.Text[i] > 64 && (int)SurnameTextBox1.Text[i] < 91) { }

                else { surname = false; break; }
            }

            for (int i = 0; i < countrys.Count; i++)
            {
                if (countrys[i].name == VetenTextBox1.Text) { veten = true; break; }
            }

            if (EmailTextBox1.TextLength == 26)
            {
                string gml = "@gmail.com";

                for (int i = 0; i < 26; i++)
                {

                    if (i < 16 && (int)EmailTextBox1.Text[i] > 96 && (int)EmailTextBox1.Text[i] < 123) { }
                    else if (i > 15 && EmailTextBox1.Text[i] == gml[i - 16]) { }
                    else { email = false; break; }
                }


            }

            if (name && surname && veten && email && NameTextBox1.Text.Length != 0 && SurnameTextBox1.TextLength != 0 && VetenTextBox1.TextLength != 0 && EmailTextBox1.TextLength != 0)
            {

                int yoxlaAra = -1;


                for (int i = 0; i < persons.Count; i++)
                {
                    if (persons[i].email == EmailTextBox1.Text) { yoxlaAra = i; break; }
                }


                if (yoxlaAra > -1)
                {

                    persons[yoxlaAra].name = NameTextBox1.Text;
                    persons[yoxlaAra].surname = SurnameTextBox1.Text;
                    persons[yoxlaAra].veteni = VetenTextBox1.Text;
                    persons[yoxlaAra].email = EmailTextBox1.Text;
                    persons[yoxlaAra].DateTime = dateTimePicker1.Value;
                    persons[yoxlaAra].cinsiyet = KisiRadioButton1.Checked == true ? true : false;
                    persons[yoxlaAra].isiVar = IsVarCheckBox1.Checked;
                    persons[yoxlaAra].evlidi = EvlidiCheckBox1.Checked;
                    File.WriteAllText("../../../Persons.json", JsonSerializer.Serialize(persons, new JsonSerializerOptions() { WriteIndented = true }));
                }
                else
                {
                    persons.Add(new Person(NameTextBox1.Text, SurnameTextBox1.Text, VetenTextBox1.Text, dateTimePicker1.Value, KisiRadioButton1.Checked == true ? true : false, EmailTextBox1.Text, EvlidiCheckBox1.Checked, IsVarCheckBox1.Checked));

                    File.WriteAllText("../../../Persons.json", JsonSerializer.Serialize(persons, new JsonSerializerOptions() { WriteIndented = true }));
                }




            }
            else { CreatButton1.BackColor = Color.Red; }



        }


        private void CreatButton1_MouseEnter(object sender, EventArgs e)
        {
            bool name = true;
            bool surname = true;
            bool veten = false;
            bool email = true;

            for (int i = 0; i < NameTextBox1.Text.Length; i++)
            {
                if ((int)NameTextBox1.Text[i] > 96 && (int)NameTextBox1.Text[i] < 123 || (int)NameTextBox1.Text[i] > 64 && (int)NameTextBox1.Text[i] < 91) { }
                else { name = false; break; }
            }

            for (int i = 0; i < SurnameTextBox1.TextLength; i++)
            {
                if ((int)SurnameTextBox1.Text[i] > 96 && (int)SurnameTextBox1.Text[i] < 123 || (int)SurnameTextBox1.Text[i] > 64 && (int)SurnameTextBox1.Text[i] < 91) { }

                else { surname = false; break; }
            }

            for (int i = 0; i < countrys.Count; i++)
            {
                if (countrys[i].name == VetenTextBox1.Text) { veten = true; break; }
            }

            if (EmailTextBox1.TextLength == 26)
            {
                string gml = "@gmail.com";

                for (int i = 0; i < 26; i++)
                {

                    if (i < 16 && (int)EmailTextBox1.Text[i] > 96 && (int)EmailTextBox1.Text[i] < 123) { }
                    else if (i > 15 && EmailTextBox1.Text[i] == gml[i - 16]) { }
                    else { email = false; break; }
                }


            }



            if (name && surname && veten && email && NameTextBox1.Text.Length != 0 && SurnameTextBox1.TextLength != 0 && VetenTextBox1.TextLength != 0 && EmailTextBox1.TextLength != 0)
            {

                CreatButton1.BackColor = Color.Green;

            }
            else { CreatButton1.BackColor = Color.Red; }
        }

        private void CreatButton1_MouseLeave(object sender, EventArgs e)
        {
            CreatButton1.BackColor = SystemColors.Highlight;
        }

        private void aramaButton_Click(object sender, EventArgs e)
        {

            if (aramaTextBox.ForeColor == Color.Green)
            {

                for (int i = 0; i < persons.Count; i++)
                {
                    if (persons[i].email == aramaTextBox.Text)
                    {
                        NameTextBox1.Text = persons[i].name;
                        SurnameTextBox1.Text = persons[i].surname;
                        VetenTextBox1.Text = persons[i].veteni;
                        EmailTextBox1.Text = persons[i].email;
                        dateTimePicker1.Value = persons[i].DateTime;
                        if (persons[i].cinsiyet) { KisiRadioButton1.Checked = true; }
                        else { QadinRadioButton1.Checked = true; }
                        IsVarCheckBox1.Checked = persons[i].isiVar;
                        EvlidiCheckBox1.Checked = persons[i].evlidi;

                    }
                }







            }


        }

        private void aramaButton_MouseEnter(object sender, EventArgs e)
        {
            if (aramaTextBox.ForeColor == Color.Green)
            {

                for (int i = 0; i < persons.Count; i++)
                {
                    if (persons[i].email == aramaTextBox.Text)
                    {

                        aramaButton.BackColor = Color.Green;
                    }
                }


            }
            else { aramaButton.BackColor = Color.Red; }
        }

        private void aramaButton_MouseLeave(object sender, EventArgs e)
        {
            aramaButton.BackColor = SystemColors.Highlight;
        }
    }
}