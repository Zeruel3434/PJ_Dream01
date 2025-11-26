using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PJ_DREAM
{
    public partial class Form1 : Form
    {    
        public Form1()
        {
            InitializeComponent();
            SwitchTo(new MainPage()); // เปิดหน้า MainPage
        }
        public void SwitchTo(UserControl page) // ฟังก์ชั่นสลับหน้า UI
        {
            panelMain.Controls.Clear();       // ลบ panelMain
            page.Dock = DockStyle.Fill;       //กำหนดขนาด panelMain ให้เต็ม
            panelMain.Controls.Add(page);     // เพิ่มหน้าใหม่เข้า panelMain
        }
        
    }
}
