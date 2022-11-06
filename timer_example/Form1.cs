using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer_example
{
    public partial class Form1 : Form
    {
        Timer timer;
        public Form1()
        {
            InitializeComponent();

            //タイマ作成
             timer = new Timer();

            //100ms
            //タイマー間隔を設定
            timer.Interval = 100;

            //イベントハンドラーを渡す
            timer.Tick += Timer_Tick;

            //タイマー開始
            timer.Start();

        }

        /// <summary>
        /// 時間を表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            //
            DateTime nowtime = DateTime.Now;

            label1.Text = nowtime.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }
    }
}
