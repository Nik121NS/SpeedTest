using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SpeedTest
{
    public partial class SpeedTest : Form
    {
        Random rnd = new Random();
        private string textFromBD, textFromUser;
        private string nickName;
        private int record;

        public SpeedTest(string nickName)
        {
            InitializeComponent();
            var label = new Label();
            this.Controls.Add(label);
            Countdown(label);
            this.nickName = nickName;
        }


        private void acceptButton_Click(object sender, EventArgs e)
        {
            textFromUser = textBox1.Text;
            
            record += CheckMistakes.Result(textFromUser, textFromBD);
            textBox1.Text = null;

            int random = rnd.Next(1, 7);
            textFromBD = DBContext.getText("SELECT* FROM Texts WHERE Id=" + random.ToString());
            gameTextLabel.Text = textFromBD;
        }

        private void SpeedTest_Load(object sender, EventArgs e)
        {
            int random = rnd.Next(1, 7);
            record = 0;

            textFromBD = DBContext.getText("SELECT* FROM Texts WHERE Id=" + random.ToString());
            gameTextLabel.Text = textFromBD;

        }
        private async void Countdown(Label lbl)
        {
            var start = DateTime.UtcNow;
            var end = start.AddSeconds(60);
            var diff = TimeSpan.FromSeconds(60);

            while ((DateTime.UtcNow - start) < diff)
            {
                lbl.Text = (diff - (DateTime.UtcNow - start)).ToString();
                await Task.Delay(1000);
            }
            DBContext.setRecord(nickName,record);
            Close();
        }

        private void gameTextLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
