using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TicTacToeGame
{
    public partial class MainPage : ContentPage
    {

        public string namePlayer1;
        public string namePlayer2;
        public bool isItDark;
        public MainPage()
        {
            InitializeComponent();
            //if swirch toggel set the variable to true
            if (switchButton.IsToggled)
            {
                isItDark = true;
            }
            else
            {
                isItDark = false;

            }
            //create object to send to another page if UI dark oR Lite 
            infoPage info = new infoPage(switchButton.IsToggled);
        }

        



        //get text from entry
        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            namePlayer1 = Player1.Text;
            namePlayer2 = Player2.Text;



        }

        //to navigation to play page
        private void click_navigationToAnotherPage(object sender, EventArgs e)
        {
           
            if (switchButton.IsToggled)
            {
                isItDark = true;
                Navigation.PushAsync(new playPage(namePlayer1, namePlayer2,isItDark));
            }
            else
            {
                isItDark= false;
                Navigation.PushAsync(new playPage(namePlayer1, namePlayer2, isItDark));

            }

        }


        //this method if the switch is toggeld or not
        private void Switch_darkMode(object sender, ToggledEventArgs e)
        {
            

            if (switchButton.IsToggled)
            {

                //ui for dark
                isItDark = true;
                allPage.BackgroundColor = Color.Black;
                frame.BackgroundColor = Color.Black;
                frameText.TextColor = Color.White;
                namePlayer1Text.TextColor = Color.White;
                namePlayer2Text.TextColor = Color.White;
                Player1.PlaceholderColor = Color.Black;
                Player2.PlaceholderColor = Color.Black;
                Player1.BackgroundColor = Color.GhostWhite;
                Player2.BackgroundColor = Color.GhostWhite;

                btnPlay.TextColor = Color.White;
                btnPlay.BackgroundColor = Color.DarkGray;
                darkSwitch.TextColor = Color.White;
                imageButton.BackgroundColor = Color.Black;

            }
            else
            {
                //defualt
                isItDark = false;
                allPage.BackgroundColor = Color.White;
                frame.BackgroundColor = Color.White;
                frameText.TextColor = Color.Black;
                namePlayer1Text.TextColor = Color.Black;
                namePlayer2Text.TextColor = Color.Black;
                Player1.TextColor = Color.Black;
                Player2.TextColor = Color.Black;
                btnPlay.TextColor = Color.White;
                btnPlay.BackgroundColor = Color.DarkBlue;
                darkSwitch.TextColor= Color.Black;
                imageButton.BackgroundColor = Color.White;

            }

        }

        //here to navigation to information page
        private void ImageButton_ClickedForInfo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new infoPage(switchButton.IsToggled));
        }
    }
}
