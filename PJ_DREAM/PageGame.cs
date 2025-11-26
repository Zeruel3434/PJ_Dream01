using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PJ_DREAM
{
    public partial class PageGame : UserControl
    {
        DGame Dgame = new DGame();

        public PageGame()
        {
            InitializeComponent();
            Dgame.index = 0; //เริ่มที่บท 0
            Dgame.maxIndex = 99; // สูงสุดที่บท 99
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // ทำให้ขนาดภาพที่ใส่ในรูปเท่ากับ pictureBox1

        }

        private void LoadDialogue() // โหลดบทสนทนา
        {
            Dgame.ClearChoices();  //ลบตัวเลือกตอนเริ่มบท

            // บทที่ 1
            if (Dgame.index == 1)
            {
                Dgame.name = "Yu"; // ชื่อ
                Dgame.dialogueText = "ฟ้าสว่างอากาศดี เวลาดีๆแบบนี้ทำไมต้องไปโรงเรียนด้วยนะ";
                Dgame.background = "Home_1.jpg";
                Dgame.AddChoice("ก็เธอลืมของเองนี่นา", 2);
                Dgame.AddChoice("ถ้าไม่ใช่เพราะมีคนซุ่มซ่ามจนลืมของล่ะก็นะ", 4);
                Dgame.AddChoice("นั่นสินะ อากาศน่านอนซะขนาดนี้ ถ้าไม่มีคนโทรมากวนให้ไปด้วยล่ะก็...", 3);
            }

            // บทที่ 2
            if (Dgame.index == 2)
            {
                Dgame.name = "Yu"; // ชื่อ
                Dgame.dialogueText = "ต้องให้พูดอีกกี่ครั้งว่า...ไม่ได้ลืมน่ะมันหายต่างหากเล่า";
                Dgame.background = "School_1.png";
                Dgame.AddChoice("ให้ตายเถอะ เธอนี่มีปัญหาตลอดเลยนะ ในช่วงวันหยุดเนี่ย", 3);
                Dgame.AddChoice("งั้นเอง สงสัยฉันจะเข้าใจผิด", 2);
                Dgame.AddChoice("แน่ใจนะว่ามันหายจริงๆน่ะ", 1);
            }

        }

        private void ShowChoices() //ฟังก์ชั่นแสดง Choice
        {
            // ซ่อนปุ่ม Choice ทั้งหมด
            btnChoice1.Visible = false;
            btnChoice2.Visible = false;
            btnChoice3.Visible = false;

            // ถ้าไม่มี choice ให้แสดงปุ่ม Next ตามปกติ
            if (Dgame.choiceText.Count == 0)
            {
                btnNext.Visible = true;
                return;
            }

            btnNext.Visible = false;  // ซ่อนปุ่ม Next เมื่อมีตัวเลือก


            if (Dgame.choiceText.Count > 0) //ถ้ามี 1 ตัวเลือก
            {
                btnChoice1.Text = Dgame.choiceText[0]; // เอาข้อความ choice ตัวแรกมาใส่
                btnChoice1.Tag = Dgame.choicnextIndex[0]; // เก็บ index ถัดไปไว้ใน tag
                btnChoice1.Visible = true; //ปุ่มทำงาน
            }


            if (Dgame.choiceText.Count > 1) //ถ้ามี 2 ตัวเลือก
            {
                btnChoice2.Text = Dgame.choiceText[1]; // เอาข้อความ choice ตัวที่สองมาใส่
                btnChoice2.Tag = Dgame.choicnextIndex[1];// เก็บ index ถัดไปไว้ใน tag
                btnChoice2.Visible = true;//ปุ่มทำงาน
            }

            if (Dgame.choiceText.Count > 2) //ถ้ามี 3 ตัวเลือก
            {
                btnChoice3.Text = Dgame.choiceText[2]; // เอาข้อความ choice ตัวที่สองมาใส่
                btnChoice3.Tag = Dgame.choicnextIndex[2];// เก็บ index ถัดไปไว้ใน tag
                btnChoice3.Visible = true;//ปุ่มทำงาน
            }
        }

        private void LogText() // ฟังก์ชั่นเก็บบทพูดที่พูดไปแล้ว
        {
            txtLog.Text += Dgame.name + " :" + "\r\n" + "\r\n" +
                            Dgame.dialogueText + "\r\n" + "\r\n";
        }
        private void LogChoice(string text) // ฟังก์ชั่นเก็บ Choice ที่เคยเลือก
        {
            txtLog.Text += "[เลือก] " + text + "\r\n\r\n";
        }

        private void Display()  // ฟังก์ชั่นแสดงผลข้อความกับรูป
        {
            txtText.Text = Dgame.name + " :" + "\r\n" + "\r\n" +
                            Dgame.dialogueText;


            pictureBox1.Image = Image.FromFile(Dgame.background);
        }

        private void btnNext_Click(object sender, EventArgs e) //กด Next เปลี่ยนบท
        {
            Dgame.Next(); // index เพิ่ม 1
            LoadDialogue(); // โหลดบทสนทนาของบทนั้น
            Display(); // แสดงผลข้อความกับรูปของบทนั้น
            LogText(); //เก็บข้อความไว้
            ShowChoices(); //แสดง Choice


            if (Dgame.index == Dgame.maxIndex) // ถ้าถึงบทสุดท้ายปุ่ม Next จะไม่ทำงาน
            {
                btnNext.Enabled = false;
            }
        }

        private void btnReturnTitle_Click(object sender, EventArgs e) // กดกลับหน้าแรก
        {
            DialogResult Return = MessageBox.Show(  // คำเตือน
            "เกมนี้ไม่มี save !! ถ้ากลับหน้าแรกจะเริ่มใหม่ทั้งหมด",
            "คำเตือน",
            MessageBoxButtons.YesNo
            );

            if (Return == DialogResult.Yes) //กด Yes กลับ
            {
                if (this.FindForm() is Form1 main)
                {
                    main.SwitchTo(new MainPage());
                }
            }
        }

        private void btnChoice1_Click(object sender, EventArgs e) //กด Choice (1)
        {
            if (btnChoice1.Tag != null) // เช็ค Tag ว่าว่างรึเปล่า ถ้าไม่ว่างก็ทำงาน
            {
                string choiceText1 = btnChoice1.Text; // สร้าง choiceText เก็บข้อความ

                Dgame.ChoiceHistory.Add(choiceText1); // เก็บข้อความใน ChoiceHistory
                LogChoice(choiceText1); // เก็บข้อความใน Log
                Dgame.index = Convert.ToInt32(btnChoice1.Tag); // เก็บข้อมูล Tag ไว้ใน index
                LoadDialogue();
                Display();
                ShowChoices();
            }
        }

        private void btnChoice2_Click(object sender, EventArgs e) //กด Choice (2)
        {

            if (btnChoice2.Tag != null) // เช็ค Tag ว่าว่างรึเปล่า ถ้าไม่ว่างก็ทำงาน
            {
                string choiceText2 = btnChoice2.Text;

                Dgame.ChoiceHistory.Add(choiceText2);
                LogChoice(choiceText2);
                Dgame.ChoiceHistory.Add(btnChoice2.Text);
                Dgame.index = Convert.ToInt32(btnChoice2.Tag);
                LoadDialogue();
                Display();
                ShowChoices();
            }
        }

        private void btnChoice3_Click(object sender, EventArgs e)
        {
            if (btnChoice2.Tag != null) // เช็ค Tag ว่าว่างรึเปล่า ถ้าไม่ว่างก็ทำงาน
            {
                string choiceText3 = btnChoice3.Text;

                Dgame.ChoiceHistory.Add(choiceText3);
                LogChoice(choiceText3);
                Dgame.ChoiceHistory.Add(btnChoice3.Text);
                Dgame.index = Convert.ToInt32(btnChoice3.Tag);
                LoadDialogue();
                Display();
                ShowChoices();
            }

        }
    }
}
