using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJ_DREAM
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();      
        } 
    
        private void btnStart_Click(object sender, EventArgs e) //กด Start เริ่มเกม
        {  
            if (this.FindForm() is Form1 game) // ใช้งานฟังก์ชั่นของ Form1
            {
                game.SwitchTo(new PageGame());  // เปิดหน้า PageGame
            }

        }

        public void btnExit_Click(object sender, EventArgs e) //กดออกเกม
        {
            DialogResult Exit = MessageBox.Show(  //สร้างข้อความเพื
            "ต้องการออกจากเกมไหม",
            "Exit",
            MessageBoxButtons.YesNo
            );

            if (Exit == DialogResult.Yes) //กด Yes ออกเกม
            {
                Application.Exit();
            }
        }
    }
}
