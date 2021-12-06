using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rock_paper_sicssor
{
    public partial class Form1 : Form
    {
        private readonly string[] choices =
        {
            "rock",
            "paper",
            "scissor"
        };

        private int noOfRounds;
        private bool gameCompleted;
        private string playerChoice;
        private string cpuChoice;
        private int playerScore;
        private int cpuScore;


        public Form1()
        {
            InitializeComponent();
            this.initializeGame();
        }

        private void initializeGame()
        {
            this.noOfRounds = 0;
            this.gameCompleted = false;
            this.playerChoice = "none";
            this.cpuChoice = "none";
            this.playerScore = this.cpuScore = 0;
            this.roundLbl.Text = "Round: 0/3";

            this.playerScoreLbl.Text = "Player: " + this.playerScore;
            this.cpuScoreLabel.Text = "CPU: " + this.playerScore;
            this.winnerLbl.Text = "";
        }

        private void rockBtn_Click(object sender, EventArgs e)
        {
            this.playerPicture.Image = Properties.Resources.rock;
            this.playerChoice = this.choices[0];
            this.computerTurn();
        }

        private void paperBtn_Click(object sender, EventArgs e)
        {
            this.playerPicture.Image = Properties.Resources.paper;
            this.playerChoice = this.choices[1];
            this.computerTurn();
        }

        private void scissorBtn_Click(object sender, EventArgs e)
        {
            this.playerPicture.Image = Properties.Resources.scissors;
            this.playerChoice = this.choices[2];
            this.computerTurn();
        }

        private void computerTurn()
        {
            if (this.noOfRounds == 3)
            {
                return;
            }
            Random rnd = new Random();
            int randomNumber = rnd.Next(0, this.choices.Length);
            this.cpuChoice = this.choices[randomNumber];
            switch(this.cpuChoice)
            {
                case "rock":
                    this.cpuPicture.Image = Properties.Resources.rock;
                    break;
                case "paper":
                    this.cpuPicture.Image = Properties.Resources.paper;
                    break;
                case "scissor":
                    this.cpuPicture.Image = Properties.Resources.scissors;
                    break;
            }
            this.findGameResult();
            this.checkIfGameCompleted();
        }

        private void findGameResult()
        {
            if ((playerChoice == "rock" && cpuChoice == "paper")
                || (playerChoice == "scissor" && cpuChoice == "rock")
                || (playerChoice == "paper" && cpuChoice == "scissor"))
            {
                this.cpuScore++;
                this.noOfRounds++;

                this.cpuScoreLabel.Text = "CPU: " + this.cpuScore;
                this.winnerLbl.Text = "CPU Wins!";
            }
            else if ((playerChoice == "rock" && cpuChoice == "scissor")
                || (playerChoice == "scissor" && cpuChoice == "paper")
                || (playerChoice == "paper" && cpuChoice == "rock"))
            {
                this.playerScore++;
                this.noOfRounds++;

                this.playerScoreLbl.Text = "Player: " + this.playerScore;
                this.winnerLbl.Text = "Player Wins!";
            }
            else if (playerChoice == cpuChoice)
            {
                this.noOfRounds++;
                this.winnerLbl.Text = "Draw!";
            }
            this.roundLbl.Text = "Round: " + this.noOfRounds + "/3";
        }

        private void checkIfGameCompleted()
        {
            if (this.noOfRounds == 3)
            {
                this.gameCompleted = true;
                if (this.playerScore > this.cpuScore)
                {
                    this.winnerLbl.Text = "Player Wins! Player Score: " + this.playerScore + "; CPU Score: " + this.cpuScore;
                }
                else if (this.playerScore < this.cpuScore)
                {
                    this.winnerLbl.Text = "CPU Wins! CPU Score: " + this.cpuScore + "; Player Score: " + this.playerScore;
                }
                else
                {
                    this.winnerLbl.Text = "Game is a Draw!";
                }
            }
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            this.initializeGame();
        }

        private void closeApplicationBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
