using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TicTacToeGame
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class infoPage : ContentPage
    {
        
        public infoPage(bool isItDarkModeInfo)
        {
         

            InitializeComponent();
            //here if the condition true it's meam switch to dark mode
            if (isItDarkModeInfo)
            {

                //change UI
                allPageFrame.BackgroundColor = Color.Black;
                Header1.TextColor = Color.White;
                label1Info.TextColor = Color.White;
                fHr1.BackgroundColor = Color.White;

                Header2.TextColor = Color.White;
                Header3.TextColor = Color.White;
                label2Info.TextColor = Color.White;
                fHr2.BackgroundColor = Color.White;

                member1info.TextColor = Color.Black;
                detel1info.TextColor = Color.Black;
                member2info.TextColor = Color.Black;
                detel2info.TextColor = Color.Black;
                member3info.TextColor = Color.Black;
                detel3info.TextColor = Color.Black;
                member4info.TextColor = Color.Black;
                detel4info.TextColor = Color.Black;



            }

            //default
            else
            {
                //default UI
                allPageFrame.BackgroundColor = Color.White;
                Header1.TextColor = Color.Black;
                label1Info.TextColor = Color.Black;
                fHr1.BackgroundColor = Color.Black;

                Header2.TextColor = Color.Black;
                label2Info.TextColor = Color.Black;
                fHr2.BackgroundColor = Color.Black;


                member1info.TextColor = Color.Black;
                detel1info.TextColor = Color.Black;
                member2info.TextColor = Color.Black;
                detel2info.TextColor = Color.Black;
                member3info.TextColor = Color.Black;
                detel3info.TextColor = Color.Black;
                member4info.TextColor = Color.Black;
                detel4info.TextColor = Color.Black;



            }



        }

       












    }
}