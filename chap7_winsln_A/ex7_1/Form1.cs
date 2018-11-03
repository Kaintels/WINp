using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex7_1
{
    public partial class Form1 : Form
    { // 멤버 추가
        public Form1() // 생성자
        {
            InitializeComponent(); // 2-1 메소드 호출 
            startDateTime = DateTime.Now; // 구조체 변수 초기화
        }
        DateTime startDateTime; // 구조체 변수 선언
        public DateTime GetStartDateTime() // 일반 메소드
        {
            return startDateTime;
        }

        private void button1_Click(object sender, EventArgs e)
        { // 이벤트 처리기
            MessageBox.Show(GetStartDateTime().ToString());
        }
    }
}
