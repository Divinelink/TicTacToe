using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TicTacToe.Model;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;
using Caliburn.Micro;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TicTacToe
{
    public sealed partial class MainPage : Page
    {
        bool turn = true; // true = X turn; false = O turn;
        int turn_count = 0;


        string WinnerText = "";

        public MainPage()
        {
            this.InitializeComponent();
        }



        private void button_click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Content = "X";
            else
                b.Content = "O";
            turn = !turn;
            b.IsEnabled = false;
            turn_count++;
            checkForWinner();
        }



        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.IsEnabled)
            {
                b.Content = "";
            } //end if
        }



        private void checkForWinner()
        {
            bool there_is_a_winner = false;

            //horizontal checks

            if ((A1.Content == A2.Content) && (A2.Content == A3.Content) && (!A1.IsEnabled))
                there_is_a_winner = true;
            else if ((B1.Content == B2.Content) && (B2.Content == B3.Content) && (!B1.IsEnabled))
                there_is_a_winner = true;
            else if ((C1.Content == C2.Content) && (C2.Content == C3.Content) && (!C1.IsEnabled))
                there_is_a_winner = true;


            //vertical checks

            else if ((A1.Content == B1.Content) && (B1.Content == C1.Content) && (!A1.IsEnabled))
                there_is_a_winner = true;
            else if ((A2.Content == B2.Content) && (B2.Content == C2.Content) && (!A2.IsEnabled))
                there_is_a_winner = true;
            else if ((A3.Content == B3.Content) && (B3.Content == C3.Content) && (!A3.IsEnabled))
                there_is_a_winner = true;

            //diagonal checks

            else if ((A1.Content == B2.Content) && (B2.Content == C3.Content) && (!A1.IsEnabled))
                there_is_a_winner = true;
            else if ((A3.Content == B2.Content) && (B2.Content == C1.Content) && (!C1.IsEnabled))
                there_is_a_winner = true;


            if (there_is_a_winner)
            {
                disableButtons();
                string winner = "";
                if (turn)
                {
                    if (PlayerBName.Text == "Enter Name")
                        winner = "Player B";
                    else
                        winner = PlayerBName.Text;
                    TotalScoreB.Text = (Int32.Parse(TotalScoreB.Text) + 1).ToString();
                }
                else
                {
                    if (PlayerAName.Text == "Enter Name")
                        winner = "Player A";
                    else
                        winner = PlayerAName.Text;
                    TotalScoreA.Text = (Int32.Parse(TotalScoreA.Text) + 1).ToString();
                }

                WinnerText = winner + " is winner!";
                winText.Text = WinnerText;
                ShowAnimation();


            }//end if
            else
            {
                if (turn_count == 9)
                {
                    winText.Text = "It's a draw.";
                    ShowAnimation();
                }
            }

        }//end checkForWinner

        private void button_enter(object sender, DragEventArgs e)
        {
            Button b = (Button)sender;
            if (b.IsEnabled)
            {
                if (turn)
                    b.Content = "X";
                else
                    b.Content = "O";
            }
        }

        private void A1_DragOver(object sender, DragEventArgs e)
        {
            Button b = (Button)sender;
            if (b.IsEnabled)
            {
                if (turn)
                    b.Content = "X";
                else
                    b.Content = "O";
            }
        }

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;

            turn = true;
            turn_count = 0;

            A1.IsEnabled = true;
            A2.IsEnabled = true;
            A3.IsEnabled = true;
            B1.IsEnabled = true;
            B2.IsEnabled = true;
            B3.IsEnabled = true;
            C1.IsEnabled = true;
            C2.IsEnabled = true;
            C3.IsEnabled = true;


            A1.Content = "";
            A2.Content = "";
            A3.Content = "";
            B1.Content = "";
            B2.Content = "";
            B3.Content = "";
            C1.Content = "";
            C2.Content = "";
            C3.Content = "";

            if (b.Name == "NewGame2" || WinTextButton.Opacity > 0.1)
            {
                HideAnimation();
            }
        }




        private void ResetGame_Click(object sender, RoutedEventArgs e)
        {
            TotalScoreA.Text = "0";
            TotalScoreB.Text = "0";
        }

        private void disableButtons()
        {

            A1.IsEnabled = false;
            A2.IsEnabled = false;
            A3.IsEnabled = false;
            B1.IsEnabled = false;
            B2.IsEnabled = false;
            B3.IsEnabled = false;
            C1.IsEnabled = false;
            C2.IsEnabled = false;
            C3.IsEnabled = false;


        }

        private void ShowAnimation()
        {
            Canvas.SetZIndex(WinTextButton, 0);
            NewGame2.IsEnabled = true;
            WinTextShow.Begin();
        }

        private void HideAnimation()
        {
            WinTextHide.Begin();
            NewGame2.IsEnabled = false;
            Canvas.SetZIndex(WinTextButton, -1);
        }



    }
}
