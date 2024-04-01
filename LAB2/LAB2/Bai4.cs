using System.Runtime.Serialization.Formatters.Binary;

namespace LAB2
{
    public partial class Bai4 : Form
    {
        public class Student
        {
            public string mssv = "";
            public string hoten = "";
            public string sdt = "";
            public float DiemToan = 0f;
            public float DiemVan = 0f;
            public float DiemTB = 0f;

            public bool Check()
            {
                if (mssv.Length > 9)
                {
                    return false;
                }
                if (sdt.Length > 11)
                {
                    return false;
                }
                if (DiemToan < 0 || DiemToan > 10 || DiemVan < 0 || DiemVan > 10)
                {
                    return false;
                }
                return true;
            }
        }

        List<Student> students = new List<Student>();

        public Bai4()
        {
            InitializeComponent();
        }



        public void XuatStuden(Student student)
        {
            MessageBox.Show(student.mssv + "\n" + student.hoten + "\n" + student.sdt
                            + "\n" + student.DiemToan.ToString() + "\n" + student.DiemVan.ToString());
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("input.txt", FileMode.OpenOrCreate))
            {
                BinaryFormatter bf = new BinaryFormatter();
                fs.Position = 0;
                string allstudent = (string)bf.Deserialize(fs);
                string[] data = allstudent.Split();

                try
                {
                    students.Clear();
                    for (int i = 0; i < data.Length; i++)
                    {
                        Student student = new Student();
                        student.mssv = data[i];
                        i++;
                        student.hoten = data[i];
                        i++;
                        student.sdt = data[i];
                        i++;
                        student.DiemToan = float.Parse(data[i]);
                        i++;
                        student.DiemVan = float.Parse(data[i]);
                        student.DiemTB = (student.DiemVan + student.DiemToan) / 2;
                        if (student.Check())
                        {
                            students.Add(student);
                        }
                        else
                        {
                            MessageBox.Show("Phat hien 1 sinh vien bi nhap sai");
                            MessageBox.Show(student.mssv + "\n" + student.hoten + "\n "
                                + student.sdt + "\n" + student.DiemToan + "\n" + student.DiemVan + "\n");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Format file sai");
                }

                foreach (Student student in students)
                {
                    Data.Text += student.mssv + "\n";
                    Data.Text += student.hoten + "\n";
                    Data.Text += student.sdt + "\n";
                    Data.Text += student.DiemToan + "\n";
                    Data.Text += student.DiemVan + "\n";
                    Data.Text += student.DiemTB + "\n\n";
                }
            }
        }

        private void WriteButton_Click(object sender, EventArgs e)
        {

            using (FileStream fs = new FileStream("formatted_output.txt", FileMode.OpenOrCreate))
            {
                fs.Flush();
                BinaryFormatter formatter = new BinaryFormatter();
                string content = Data.Text;
                formatter.Serialize(fs, content);
                using (FileStream ff = new FileStream("output.txt", FileMode.OpenOrCreate))
                {
                    ff.Flush();
                    StreamWriter writer = new StreamWriter(ff);
                    writer.Write(content);
                }

            }
        }

        private void Write_Input_btn_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("input.txt", FileMode.OpenOrCreate))
            {
                BinaryFormatter bf = new BinaryFormatter();
                fs.Flush();
                bf.Serialize(fs, Data.Text);
                Data.Text = string.Empty;
            }
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MENU mENU = new MENU();
            mENU.Show();
           
        }
    }
}