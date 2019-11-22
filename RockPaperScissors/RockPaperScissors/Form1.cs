using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        int wins = 1;
        int losses = 1;
        int count = 1;
        string playerName="Player";
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add(playerName,typeof(string));
            dt.Columns.Add("Computer", typeof(string));
            dt.Columns.Add("Winner", typeof(string));
            dataGridView1.DataSource = dt;
            playerrock.Visible = false;
            playerpaper.Visible = false;
            playerscissor.Visible = false;
            computerpaper.Visible = false;
            computerrock.Visible = false;
            computerscissor.Visible = false;
            PopupNotifier msg = new PopupNotifier();
            msg.TitleText = "Notifier";
            msg.ContentText = "Please enter your name and Press 'Enter'\nReset the game if you want to start a fresh game!";
            msg.Popup();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void closeb_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddARow(DataTable table,string p,string c,string w)
        {
            table.Rows.Add(p,c,w);    
        }
        private void rockb_Click(object sender, EventArgs e)
        { 
            playerrock.Visible = true;
            playerpaper.Visible = false;
            playerscissor.Visible = false;
            computerpaper.Visible = false;
            computerrock.Visible = false;
            computerscissor.Visible = false;   
            Random r = new Random();
            int cs = r.Next(3) + 1;

            if (cs == 1)
            {
                computerrock.Visible = true;
                matchResultl.Text = "Tie"; matchResultl.Visible = true;
                AddARow(dt, "Rock", "Rock", "Tie");
            }
            else if (cs == 2)
            {
                count++;
                computerpaper.Visible = true;
                matchResultl.Text = "Computer Wins"; matchResultl.Visible = true;
                AddARow(dt, "Rock", "Paper", "Computer");
                textBox2.Text = losses++.ToString();
            }
            else if (cs == 3)
            {
                count++;
                computerscissor.Visible = true;
                matchResultl.Text = playerName+" Wins"; matchResultl.Visible = true;
                AddARow(dt, "Rock", "Scissor", playerName);
                textBox1.Text = wins++.ToString();
            }
            if (count >= 5)
            {
                if (wins > losses)
                {
                    MessageBox.Show("Congratulations! You Won\n"+playerName+"'s Score:" + textBox1.Text.ToString() + "\nComputer Score:" + textBox2.Text.ToString(), "Result", MessageBoxButtons.OK);
                    this.Close();
                }
                else if (losses > wins)
                {
                    MessageBox.Show("Computer Won\n"+playerName+ "'s Score:" + textBox1.Text.ToString() + "\nComputer Score:" + textBox2.Text.ToString(), "Result", MessageBoxButtons.OK);
                    this.Close();
                }
            }
        }

        private void paperb_Click(object sender, EventArgs e)
        {
            
            playerpaper.Visible = true;
            playerrock.Visible = false;
            playerscissor.Visible = false;
            computerpaper.Visible = false;
            computerrock.Visible = false;
            computerscissor.Visible = false;

            Random r = new Random();
            int cs = r.Next(3) + 1;

            if (cs == 1)
            {
                computerpaper.Visible = true;
                matchResultl.Text = "Tie"; matchResultl.Visible = true;
                AddARow(dt, "Paper", "Paper", "Tie");
            }
            else if (cs == 2)
            {
                count++;
                computerrock.Visible = true;
                matchResultl.Text = playerName+" Wins"; matchResultl.Visible = true;
                AddARow(dt, "Paper", "Rock", playerName);
                textBox1.Text = wins++.ToString();
            }
            else if (cs == 3)
            {
                count++;
                computerscissor.Visible = true;
                matchResultl.Text = "Computer Wins";matchResultl.Visible=true;
                AddARow(dt, "Paper", "Scissor", "Computer");
                textBox2.Text = losses++.ToString();
            }
            if (count >= 5)
            {
                if (wins > losses)
                {
                    MessageBox.Show("Congratulations! You Won\n"+playerName+"'s Score:" + textBox1.Text.ToString() + "\nComputer Score:" + textBox2.Text.ToString(), "Result", MessageBoxButtons.OK);
                    this.Close();
                }
                else if (losses > wins)
                {
                    MessageBox.Show("Computer Won\n"+playerName+"'s Score:" + textBox1.Text.ToString() + "\nComputer Score:" + textBox2.Text.ToString(), "Result", MessageBoxButtons.OK);
                    this.Close();
                }
            }
        }

        private void scissorb_Click(object sender, EventArgs e)
        {
            
            playerscissor.Visible = true;
            playerpaper.Visible = false;
            playerrock.Visible = false;
            computerpaper.Visible = false;
            computerrock.Visible = false;
            computerscissor.Visible = false;

            Random r = new Random();
            int cs = r.Next(3) + 1;

            if (cs == 1)
            {
                computerscissor.Visible = true;
                matchResultl.Text = "Tie"; matchResultl.Visible = true;
                AddARow(dt, "Scissor", "Scissor", "Tie");

            }
            else if (cs == 2)
            {
                count++;
                computerrock.Visible = true;
                matchResultl.Text = "Computer Wins"; matchResultl.Visible = true;
                AddARow(dt, "Scissor", "Rock", "Computer");
                textBox2.Text = losses++.ToString();

            }
            else if (cs == 3)
            {
                count++;
                computerpaper.Visible = true;
                matchResultl.Text = playerName+" Wins"; matchResultl.Visible = true;
                AddARow(dt, "Scissor", "Paper", playerName);
                textBox1.Text = wins++.ToString();
            }
            if (count >= 5)
            {
                if (wins > losses)
                {
                    MessageBox.Show("Congratulations! You Won\n"+playerName+"'s Score:"+textBox1.Text.ToString()+"\nComputer Score:"+ textBox2.Text.ToString(), "Result", MessageBoxButtons.OK);
                    this.Close();
                }
                else if (losses > wins)
                {
                    MessageBox.Show("Computer Wins\n"+playerName+"'s Score:" + textBox1.Text.ToString() + "\nComputer Score:" + textBox2.Text.ToString(), "Result", MessageBoxButtons.OK);
                    this.Close();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void matchResultl_Click(object sender, EventArgs e)
        {

        }

        private void resetb_Click(object sender, EventArgs e)
        {
            wins = 1;
            losses = 1;
            count = 1;
            matchResultl.Visible = false;
            textBox1.Text = "0";
            textBox2.Text = "0";
            matchResultl.Text = "Match Reseted!\nEnter Your name again\nand start playing.";matchResultl.Visible = true;
            dt.Rows.Clear();
            playerName = "Player";
            playerl.Text = playerName;
            playerscorel.Text = playerName;

            playerrock.Visible = false;
            playerpaper.Visible = false;
            playerscissor.Visible = false;
            computerrock.Visible = false;
            computerpaper.Visible = false;
            computerscissor.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void playerscorel_Click(object sender, EventArgs e)
        {

        }

        private void playerl_Click(object sender, EventArgs e)
        {

        }

        private void playerpaper_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                playerName = textBox3.Text.ToString();
                MessageBox.Show("Player Name set to: "+playerName,"Player name set up",MessageBoxButtons.OK);
                playerl.Text = playerName;
                playerscorel.Text = playerName;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
