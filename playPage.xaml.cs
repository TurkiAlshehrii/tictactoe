using System;
/*
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
*/
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace TicTacToeGame
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class playPage : ContentPage
    {



        //name players
        public string namePlayer1;
        public string namePlayer2;


        //array score players

        public int[] array = new int[2];



        //score playerd
        public int scorePlayer1 = 0;
        public int scorePlayer2 = 0;


        //cuurent PLayer
        public bool curnetPlayer = true;


        //dec , inti the 9 choice
        public bool Squarechoice1 = false;
        public bool Squarechoice2 = false;
        public bool Squarechoice3 = false;
        public bool Squarechoice4 = false;
        public bool Squarechoice5 = false;
        public bool Squarechoice6 = false;
        public bool Squarechoice7 = false;
        public bool Squarechoice8 = false;
        public bool Squarechoice9 = false;

        //round
        public int round = 1;


        public playPage(string name1, string name2, bool darkOrNO)
        {
            InitializeComponent();
           

          //to switch if it true to dark mode
            if (darkOrNO == true)
            {
                allPage.BackgroundColor = Color.Black;
                player1Label.TextColor = Color.White;
                player2Label.TextColor = Color.White;
                showNamePlayer1.TextColor = Color.White;
                showNamePlayer2.TextColor = Color.White;
               
                roundLabel.TextColor = Color.White;
                showRound.TextColor = Color.White;
                scoreTitle.TextColor = Color.White;
                namePlayer1ForScore.TextColor = Color.White;
                scorePlayer1InPlay.TextColor = Color.White;
                namePlayer2ForScore.TextColor = Color.White;
                scorePlayer2InPlay.TextColor = Color.White;


            }
            //back to default
            else
            {
                allPage.BackgroundColor = Color.White;
                player1Label.TextColor = Color.Black;
                player2Label.TextColor = Color.Black;
                showNamePlayer1.TextColor = Color.Black;
                showNamePlayer2.TextColor = Color.Black;
              
                roundLabel.TextColor = Color.Black;
                showRound.TextColor = Color.Black;

                namePlayer1ForScore.TextColor = Color.Black;
                scorePlayer1InPlay.TextColor = Color.Black;
                namePlayer2ForScore.TextColor = Color.Black;
                scorePlayer2InPlay.TextColor = Color.Black;

            }
            this.namePlayer1 = name1;
            this.namePlayer2 = name2;
            showNamePlayer1.Text = this.namePlayer1;
            showNamePlayer2.Text = this.namePlayer2;
        }

        //from here check if any button clicked
        private void choice1_Clicked(object sender, EventArgs e)
        {
            if (curnetPlayer == true)
            {
                
                choice1.Text = "X";
                curnetPlayer = false;
                choice1.IsEnabled = false;
                //this method to check if it's equal
                ifItEqual();
                //this method to check if it win
                checkWin();


                Squarechoice1 = true;

            }
            else
            {
                choice1.Text = "O";
                curnetPlayer = true;
                choice1.IsEnabled = false;
                ifItEqual();

                checkWin();

                Squarechoice1 = true;

            }

        }

        private void choice2_Clicked(object sender, EventArgs e)
        {

            if (curnetPlayer == true)
            {
                choice2.Text = "X";
                curnetPlayer = false;
                choice2.IsEnabled = false;
                ifItEqual();

                checkWin();

                Squarechoice2 = true;

            }
            else
            {
                choice2.Text = "O";
                curnetPlayer = true;
                choice2.IsEnabled = false;
                ifItEqual();

                checkWin();

                Squarechoice2 = true;

            }


        }

        private void choice3_Clicked(object sender, EventArgs e)
        {

            if (curnetPlayer == true)
            {
                choice3.Text = "X";
                curnetPlayer = false;
                choice3.IsEnabled = false;
                ifItEqual();

                checkWin();

                Squarechoice3 = true;


            }
            else
            {
                choice3.Text = "O";
                curnetPlayer = true;
                choice3.IsEnabled = false;
                ifItEqual();

                checkWin();

                Squarechoice3 = true;


            }

        }

        private void choice4_Clicked(object sender, EventArgs e)
        {

            if (curnetPlayer == true)
            {
                choice4.Text = "X";
                curnetPlayer = false;
                choice4.IsEnabled = false;
                ifItEqual();

                checkWin();

                Squarechoice4 = true;


            }
            else
            {
                choice4.Text = "O";
                curnetPlayer = true;
                choice4.IsEnabled = false;
                ifItEqual();

                checkWin();

                Squarechoice4 = true;


            }

        }

        private void choice5_Clicked(object sender, EventArgs e)
        {

            if (curnetPlayer == true)
            {
                choice5.Text = "X";
                curnetPlayer = false;
                choice5.IsEnabled = false;
                ifItEqual();

                checkWin();

                Squarechoice5 = true;


            }
            else
            {
                choice5.Text = "O";
                curnetPlayer = true;
                choice5.IsEnabled = false;
                ifItEqual();

                checkWin();

                Squarechoice5 = true;

            }

        }

        private void choice6_Clicked(object sender, EventArgs e)
        {

            if (curnetPlayer == true)
            {
                choice6.Text = "X";
                curnetPlayer = false;
                choice6.IsEnabled = false;
                ifItEqual();

                checkWin();

                Squarechoice6 = true;


            }
            else
            {
                choice6.Text = "O";
                curnetPlayer = true;
                choice6.IsEnabled = false;
                ifItEqual();

                checkWin();

                Squarechoice6 = true;


            }

        }

        private void choice7_Clicked(object sender, EventArgs e)
        {

            if (curnetPlayer == true)
            {
                choice7.Text = "X";
                curnetPlayer = false;
                choice7.IsEnabled = false;

                ifItEqual();

                checkWin();

                Squarechoice7 = true;

            }
            else
            {
                choice7.Text = "O";
                curnetPlayer = true;
                choice7.IsEnabled = false;
                ifItEqual();

                checkWin();

                Squarechoice7 = true;


            }

        }

        private void choice8_Clicked(object sender, EventArgs e)
        {

            if (curnetPlayer == true)
            {
                choice8.Text = "X";
                curnetPlayer = false;
                choice8.IsEnabled = false;
                ifItEqual();

                checkWin();

                Squarechoice8 = true;


            }
            else
            {
                choice8.Text = "O";
                curnetPlayer = true;
                choice8.IsEnabled = false;
                ifItEqual();

                checkWin();


                Squarechoice8 = true;

            }

        }



        private void choice9_Clicked(object sender, EventArgs e)
        {

            if (curnetPlayer == true)
            {
                choice9.Text = "X";
                curnetPlayer = false;
                choice9.IsEnabled = false;
                ifItEqual();

                checkWin();

                Squarechoice9 = true;



            }
            else
            {
                choice9.Text = "O";
                curnetPlayer = true;
                choice9.IsEnabled = false;
                ifItEqual();

                checkWin();

                Squarechoice9 = true;



            }

        }




        // this method to check ane player is win

        public void checkWin()
        {


            //conditions for player 1 (X)
            if (Squarechoice1 == true && Squarechoice5 == true && Squarechoice9 == true && choice1.Text == "X" && choice5.Text == "X" && choice9.Text == "X")
            {

                // if it true it's desplay this message and enabled each button
                DisplayAlert("congratulations 👏 " + namePlayer1, " you winnn!! 🎉 ", "ok");
                choice1.IsEnabled = false;
                choice2.IsEnabled = false;
                choice3.IsEnabled = false;
                choice4.IsEnabled = false;
                choice5.IsEnabled = false;
                choice6.IsEnabled = false;
                choice7.IsEnabled = false;
                choice8.IsEnabled = false;
                choice9.IsEnabled = false;
                frame1.BackgroundColor = Color.Black;
                frame5.BackgroundColor = Color.Black;
                frame9.BackgroundColor = Color.Black;
                frame1.Padding = 1;
                frame5.Padding = 1;
                frame9.Padding = 1;


                //increase score
                scorePlayer1++;
                // if it true refrech the game and increase the round
                refreshGame();



            }


            else if (Squarechoice1 == true && Squarechoice2 == true && Squarechoice3 == true && choice1.Text == "X" && choice2.Text == "X" && choice3.Text == "X")
            {
                // if it true it's desplay this message and enabled each button

                DisplayAlert("congratulations 👏 " + namePlayer1, " you winnn!! 🎉 ", "ok");
                choice1.IsEnabled = false;
                choice2.IsEnabled = false;
                choice3.IsEnabled = false;
                choice4.IsEnabled = false;
                choice5.IsEnabled = false;
                choice6.IsEnabled = false;
                choice7.IsEnabled = false;
                choice8.IsEnabled = false;
                choice9.IsEnabled = false;



                frame1.BackgroundColor = Color.Black;
                frame2.BackgroundColor = Color.Black;
                frame3.BackgroundColor = Color.Black;
                frame1.Padding = 1;
                frame2.Padding = 1;
                frame3.Padding = 1;


                scorePlayer1++;

                // if it true refrech the game and increase the round

                refreshGame();



            }


            else if (Squarechoice4 == true && Squarechoice5 == true && Squarechoice6 == true && choice4.Text == "X" && choice5.Text == "X" && choice6.Text == "X")
            {               
                // if it true it's desplay this message and enabled each button

                DisplayAlert("congratulations 👏 " + namePlayer1, " you winnn!! 🎉 ", "ok");
                choice1.IsEnabled = false;
                choice2.IsEnabled = false;
                choice3.IsEnabled = false;
                choice4.IsEnabled = false;
                choice5.IsEnabled = false;
                choice6.IsEnabled = false;
                choice7.IsEnabled = false;
                choice8.IsEnabled = false;
                choice9.IsEnabled = false;



                frame4.BackgroundColor = Color.Black;
                frame5.BackgroundColor = Color.Black;
                frame6.BackgroundColor = Color.Black;
                frame4.Padding = 1;
                frame5.Padding = 1;
                frame6.Padding = 1;

                scorePlayer1++;

                // if it true refrech the game and increase the round

                refreshGame();

            }


            else if (Squarechoice7 == true && Squarechoice8 == true && Squarechoice9 == true && choice7.Text == "X" && choice8.Text == "X" && choice9.Text == "X")
            {

                // if it true it's desplay this message and enabled each button

                DisplayAlert("congratulations 👏 " + namePlayer1, " you winnn!! 🎉 ", "ok");
                choice1.IsEnabled = false;
                choice2.IsEnabled = false;
                choice3.IsEnabled = false;
                choice4.IsEnabled = false;
                choice5.IsEnabled = false;
                choice6.IsEnabled = false;
                choice7.IsEnabled = false;
                choice8.IsEnabled = false;
                choice9.IsEnabled = false;




                frame7.BackgroundColor = Color.Black;
                frame8.BackgroundColor = Color.Black;
                frame9.BackgroundColor = Color.Black;
                frame7.Padding = 1;
                frame8.Padding = 1;
                frame9.Padding = 1;
                scorePlayer1++;


                // if it true refrech the game and increase the round

                refreshGame();


            }


            else if (Squarechoice1 == true && Squarechoice4 == true && Squarechoice7 == true && choice1.Text == "X" && choice4.Text == "X" && choice7.Text == "X")
            {

                // if it true it's desplay this message and enabled each button

                DisplayAlert("congratulations 👏 " + namePlayer1, " you winnn!! 🎉 ", "ok");
                choice1.IsEnabled = false;
                choice2.IsEnabled = false;
                choice3.IsEnabled = false;
                choice4.IsEnabled = false;
                choice5.IsEnabled = false;
                choice6.IsEnabled = false;
                choice7.IsEnabled = false;
                choice8.IsEnabled = false;
                choice9.IsEnabled = false;



                frame1.BackgroundColor = Color.Black;
                frame4.BackgroundColor = Color.Black;
                frame7.BackgroundColor = Color.Black;
                frame1.Padding = 1;
                frame4.Padding = 1;
                frame7.Padding = 1;

                scorePlayer1++;

                // if it true refrech the game and increase the round

                refreshGame();


            }


            else if (Squarechoice2 == true && Squarechoice5 == true && Squarechoice8 == true && choice2.Text == "X" && choice5.Text == "X" && choice8.Text == "X")
            {

                // if it true it's desplay this message and enabled each button

                DisplayAlert("congratulations 👏 " + namePlayer1, " you winnn!! 🎉 ", "ok");
                choice1.IsEnabled = false;
                choice2.IsEnabled = false;
                choice3.IsEnabled = false;
                choice4.IsEnabled = false;
                choice5.IsEnabled = false;
                choice6.IsEnabled = false;
                choice7.IsEnabled = false;
                choice8.IsEnabled = false;
                choice9.IsEnabled = false;



                frame2.BackgroundColor = Color.Black;
                frame5.BackgroundColor = Color.Black;
                frame8.BackgroundColor = Color.Black;
                frame2.Padding = 1;
                frame5.Padding = 1;
                frame8.Padding = 1;

                scorePlayer1++;

                // if it true refrech the game and increase the round

                refreshGame();


            }


            else if (Squarechoice3 == true && Squarechoice6 == true && Squarechoice9 == true && choice3.Text == "X" && choice6.Text == "X" && choice9.Text == "X")
            {

                // if it true it's desplay this message and enabled each button

                DisplayAlert("congratulations 👏 " + namePlayer1, " you winnn!! 🎉 ", "ok");
                choice1.IsEnabled = false;
                choice2.IsEnabled = false;
                choice3.IsEnabled = false;
                choice4.IsEnabled = false;
                choice5.IsEnabled = false;
                choice6.IsEnabled = false;
                choice7.IsEnabled = false;
                choice8.IsEnabled = false;
                choice9.IsEnabled = false;



                frame3.BackgroundColor = Color.Black;
                frame6.BackgroundColor = Color.Black;
                frame9.BackgroundColor = Color.Black;
                frame3.Padding = 1;
                frame6.Padding = 1;
                frame9.Padding = 1;

                scorePlayer1++;

                // if it true refrech the game and increase the round

                refreshGame();

            }


            else if (Squarechoice3 == true && Squarechoice5 == true && Squarechoice7 == true && choice3.Text == "X" && choice5.Text == "X" && choice7.Text == "X")
            {

                // if it true it's desplay this message and enabled each button

                DisplayAlert("congratulations 👏 " + namePlayer1, " you winnn!! 🎉 ", "ok");
                choice1.IsEnabled = false;
                choice2.IsEnabled = false;
                choice3.IsEnabled = false;
                choice4.IsEnabled = false;
                choice5.IsEnabled = false;
                choice6.IsEnabled = false;
                choice7.IsEnabled = false;
                choice8.IsEnabled = false;
                choice9.IsEnabled = false;




                frame3.BackgroundColor = Color.Black;
                frame5.BackgroundColor = Color.Black;
                frame7.BackgroundColor = Color.Black;
                frame3.Padding = 1;
                frame5.Padding = 1;
                frame7.Padding = 1;

                scorePlayer1++;

                // if it true refrech the game and increase the round

                refreshGame();

            }













            //conditions for player 2 (o)

            if (Squarechoice1 == true && Squarechoice5 == true && Squarechoice9 == true && choice1.Text == "O" && choice5.Text == "O" && choice9.Text == "O")
            {

                // if it true it's desplay this message and enabled each button

                DisplayAlert("congratulations 👏 " + namePlayer2, " you winnn!! 🎉 ", "ok");
                choice1.IsEnabled = false;
                choice2.IsEnabled = false;
                choice3.IsEnabled = false;
                choice4.IsEnabled = false;
                choice5.IsEnabled = false;
                choice6.IsEnabled = false;
                choice7.IsEnabled = false;
                choice8.IsEnabled = false;
                choice9.IsEnabled = false;




                frame1.BackgroundColor = Color.Black;
                frame5.BackgroundColor = Color.Black;
                frame9.BackgroundColor = Color.Black;
                frame1.Padding = 1;
                frame5.Padding = 1;
                frame9.Padding = 1;
                scorePlayer2++;

                // if it true refrech the game and increase the round

                refreshGame();


            }


            else if (Squarechoice1 == true && Squarechoice2 == true && Squarechoice3 == true && choice1.Text == "O" && choice2.Text == "O" && choice3.Text == "O")
            {

                // if it true it's desplay this message and enabled each button

                DisplayAlert("congratulations 👏 " + namePlayer2, " you winnn!! 🎉 ", "ok");
                choice1.IsEnabled = false;
                choice2.IsEnabled = false;
                choice3.IsEnabled = false;
                choice4.IsEnabled = false;
                choice5.IsEnabled = false;
                choice6.IsEnabled = false;
                choice7.IsEnabled = false;
                choice8.IsEnabled = false;
                choice9.IsEnabled = false;


                frame1.BackgroundColor = Color.Black;
                frame2.BackgroundColor = Color.Black;
                frame3.BackgroundColor = Color.Black;
                frame1.Padding = 1;
                frame2.Padding = 1;
                frame3.Padding = 1;
                scorePlayer2++;

                // if it true refrech the game and increase the round

                refreshGame();

            }


            else if (Squarechoice4 == true && Squarechoice5 == true && Squarechoice6 == true && choice4.Text == "O" && choice5.Text == "O" && choice6.Text == "O")
            {

                // if it true it's desplay this message and enabled each button

                DisplayAlert("congratulations 👏 " + namePlayer2, " you winnn!! 🎉 ", "ok");
                choice1.IsEnabled = false;
                choice2.IsEnabled = false;
                choice3.IsEnabled = false;
                choice4.IsEnabled = false;
                choice5.IsEnabled = false;
                choice6.IsEnabled = false;
                choice7.IsEnabled = false;
                choice8.IsEnabled = false;
                choice9.IsEnabled = false;


                frame4.BackgroundColor = Color.Black;
                frame5.BackgroundColor = Color.Black;
                frame6.BackgroundColor = Color.Black;
                frame4.Padding = 1;
                frame5.Padding = 1;
                frame6.Padding = 1;
                scorePlayer2++;

                // if it true refrech the game and increase the round

                refreshGame();

            }


            else if (Squarechoice7 == true && Squarechoice8 == true && Squarechoice9 == true && choice7.Text == "O" && choice8.Text == "O" && choice9.Text == "O")
            {
                // if it true it's desplay this message and enabled each button

                DisplayAlert("congratulations 👏 " + namePlayer2, " you winnn!! 🎉 ", "ok");
                choice1.IsEnabled = false;
                choice2.IsEnabled = false;
                choice3.IsEnabled = false;
                choice4.IsEnabled = false;
                choice5.IsEnabled = false;
                choice6.IsEnabled = false;
                choice7.IsEnabled = false;
                choice8.IsEnabled = false;
                choice9.IsEnabled = false;


                frame7.BackgroundColor = Color.Black;
                frame8.BackgroundColor = Color.Black;
                frame9.BackgroundColor = Color.Black;
                frame7.Padding = 1;
                frame8.Padding = 1;
                frame9.Padding = 1;
                scorePlayer2++;

                // if it true refrech the game and increase the round

                refreshGame();

            }


            else if (Squarechoice1 == true && Squarechoice4 == true && Squarechoice7 == true && choice1.Text == "O" && choice4.Text == "O" && choice7.Text == "O")
            {
                // if it true it's desplay this message and enabled each button

                DisplayAlert("congratulations 👏 " + namePlayer2, " you winnn!! 🎉 ", "ok");
                choice1.IsEnabled = false;
                choice2.IsEnabled = false;
                choice3.IsEnabled = false;
                choice4.IsEnabled = false;
                choice5.IsEnabled = false;
                choice6.IsEnabled = false;
                choice7.IsEnabled = false;
                choice8.IsEnabled = false;
                choice9.IsEnabled = false;


                frame1.BackgroundColor = Color.Black;
                frame4.BackgroundColor = Color.Black;
                frame7.BackgroundColor = Color.Black;
                frame1.Padding = 1;
                frame4.Padding = 1;
                frame7.Padding = 1;
                scorePlayer2++;

                // if it true refrech the game and increase the round

                refreshGame();

            }


            else if (Squarechoice2 == true && Squarechoice5 == true && Squarechoice8 == true && choice2.Text == "O" && choice5.Text == "O" && choice8.Text == "O")
            {

                // if it true it's desplay this message and enabled each button

                DisplayAlert("congratulations 👏 " + namePlayer2, " you winnn!! 🎉 ", "ok");
                choice1.IsEnabled = false;
                choice2.IsEnabled = false;
                choice3.IsEnabled = false;
                choice4.IsEnabled = false;
                choice5.IsEnabled = false;
                choice6.IsEnabled = false;
                choice7.IsEnabled = false;
                choice8.IsEnabled = false;
                choice9.IsEnabled = false;


                frame2.BackgroundColor = Color.Black;
                frame5.BackgroundColor = Color.Black;
                frame8.BackgroundColor = Color.Black;
                frame2.Padding = 1;
                frame5.Padding = 1;
                frame8.Padding = 1;
                scorePlayer2++;

                // if it true refrech the game and increase the round

                refreshGame();

            }


            else if (Squarechoice3 == true && Squarechoice6 == true && Squarechoice9 == true && choice3.Text == "O" && choice6.Text == "O" && choice9.Text == "O")
            {

                // if it true it's desplay this message and enabled each button

                DisplayAlert("congratulations 👏 " + namePlayer2, " you winnn!! 🎉 ", "ok");
                choice1.IsEnabled = false;
                choice2.IsEnabled = false;
                choice3.IsEnabled = false;
                choice4.IsEnabled = false;
                choice5.IsEnabled = false;
                choice6.IsEnabled = false;
                choice7.IsEnabled = false;
                choice8.IsEnabled = false;
                choice9.IsEnabled = false;


                frame3.BackgroundColor = Color.Black;
                frame6.BackgroundColor = Color.Black;
                frame9.BackgroundColor = Color.Black;
                frame3.Padding = 1;
                frame6.Padding = 1;
                frame9.Padding = 1;
                scorePlayer2++;

                // if it true refrech the game and increase the round

                refreshGame();

            }


            else if (Squarechoice3 == true && Squarechoice5 == true && Squarechoice7 == true && choice3.Text == "O" && choice5.Text == "O" && choice7.Text == "O")
            {

                // if it true it's desplay this message and enabled each button

                DisplayAlert("congratulations 👏 " + namePlayer2, " you winnn!! 🎉 ", "ok");
                choice1.IsEnabled = false;
                choice2.IsEnabled = false;
                choice3.IsEnabled = false;
                choice4.IsEnabled = false;
                choice5.IsEnabled = false;
                choice6.IsEnabled = false;
                choice7.IsEnabled = false;
                choice8.IsEnabled = false;
                choice9.IsEnabled = false;


                frame3.BackgroundColor = Color.Black;
                frame5.BackgroundColor = Color.Black;
                frame7.BackgroundColor = Color.Black;
                frame3.Padding = 1;
                frame5.Padding = 1;
                frame7.Padding = 1;

                scorePlayer2++;

                // if it true refrech the game and increase the round

                refreshGame();

            }










        }





        //this method to check if any player win or equal if the condition true it desplay message and refrech the game 

        public bool ifItEqual()
        {


            if (choice1.IsEnabled == false && choice2.IsEnabled == false && choice3.IsEnabled == false && choice4.IsEnabled == false && choice5.IsEnabled == false &&
                                choice6.IsEnabled == false && choice7.IsEnabled == false && choice8.IsEnabled == false && choice9.IsEnabled == false)
            {
                DisplayAlert("Noo😕", "it's Equal", "ok");
                refreshGame();
                return true;
            }
            else
            {
                return false;
            }

        }








        //this method to refrech the all game and back like the defualt
        public void refreshGame()
        {
            round++;
            showRound.Text = round.ToString();



            choice1.IsEnabled = true;
            choice2.IsEnabled = true;
            choice3.IsEnabled = true;
            choice4.IsEnabled = true;
            choice5.IsEnabled = true;
            choice6.IsEnabled = true;
            choice7.IsEnabled = true;
            choice8.IsEnabled = true;
            choice9.IsEnabled = true;


            choice1.Text = "";
            choice2.Text = "";
            choice3.Text = "";
            choice4.Text = "";
            choice5.Text = "";
            choice6.Text = "";
            choice7.Text = "";
            choice8.Text = "";
            choice9.Text = "";
            frame1.Padding = 15;
            frame2.Padding = 15;
            frame3.Padding = 15;
            frame4.Padding = 15;
            frame5.Padding = 15;
            frame6.Padding = 15;
            frame7.Padding = 15;
            frame8.Padding = 15;
            frame9.Padding = 15;


            frame1.BackgroundColor = Color.White;
            frame2.BackgroundColor = Color.White;
            frame3.BackgroundColor = Color.White;
            frame4.BackgroundColor = Color.White;
            frame5.BackgroundColor = Color.White;
            frame6.BackgroundColor = Color.White;
            frame7.BackgroundColor = Color.White;
            frame8.BackgroundColor = Color.White;
            frame9.BackgroundColor = Color.White;


            // get Score from Array
            getScore();
            scorePlayer1InPlay.Text = Convert.ToString(array[0]);
            scorePlayer2InPlay.Text = Convert.ToString(array[1]);


        }

        //to get score from players and declare to array scores
        public void getScore()
        {

            array[0] = scorePlayer1;
            array[1] = scorePlayer2;


        }




       



        


       
    }
}