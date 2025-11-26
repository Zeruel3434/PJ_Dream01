using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ_DREAM
{
    internal class DGame
    {
        private string Name = ""; //ชื่อตัวละคร
        private string Text = ""; //ข้อความ
        private string Background = ""; //ภาพพื้นหลัง
        private List<string> ChoiceText = new List<string>(); //เก็บข้อความของ  Choice
        private List<int> ChoicNextIndex = new List<int>(); //ใส่เลขของบทที่จะไปต่อ
        public List<string> ChoiceHistory = new List<string>();

        private int Index;  //บอกตำแหน่งบทปัจจุบัน
        private int MaxIndex; //จำนวนบททั้งหมด

        public string name 
        { get { return Name; } set { Name = value; } }

        public string dialogueText 
        { get { return Text; } set { Text = value; }}

        public string background 
        { get { return Background; } set { Background = value; } }

        public int index 
        {  get { return Index; } set { Index = value; } }

        public int maxIndex 
        { get { return MaxIndex; }set { MaxIndex = value; }  }

        public List<string> choiceText 
        { get { return ChoiceText; } set { ChoiceText = value; }}

        public List<int> choicnextIndex 
        { get { return ChoicNextIndex; } set { ChoicNextIndex = value; } }

        public List<string> choicehistory
        { get { return ChoiceHistory; } set { ChoiceHistory = value; } }

        public void AddChoice(string text, int nextIndex) // ฟังก์ชั่นเพิ่มตัวเลือก
        {
            ChoiceText.Add(text);
            ChoicNextIndex.Add(nextIndex);
        }

        public void ClearChoices() // ฟังก์ชั่นลบตัวเลือก
        {
            ChoiceText.Clear();
            ChoicNextIndex.Clear();
        }   

        public void Next() // ฟังก์ชั่นเปลี่ยนบท
        {
            if (index < maxIndex) 
                index++;
        }
    }
}
