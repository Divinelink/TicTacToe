﻿#pragma checksum "C:\Users\Haris\documents\visual studio 2015\Projects\TicTacToe\TicTacToe\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "100D003578C82C901C2DA1BBA194F657"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TicTacToe
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.WinTextShow = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                }
                break;
            case 2:
                {
                    this.WinTextHide = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                }
                break;
            case 3:
                {
                    this.grid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4:
                {
                    this.NewGame = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 147 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.NewGame).Click += this.NewGame_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.ResetGame = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 148 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ResetGame).Click += this.ResetGame_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.PlayerA = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.PlayerAName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8:
                {
                    this.PlayerB = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9:
                {
                    this.PlayerBName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 10:
                {
                    this.ScoreA = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11:
                {
                    this.TotalScoreA = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12:
                {
                    this.ScoreB = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13:
                {
                    this.TotalScoreB = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14:
                {
                    this.A1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 174 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.A1).Click += this.button_click;
                    #line default
                }
                break;
            case 15:
                {
                    this.A2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 175 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.A2).Click += this.button_click;
                    #line default
                }
                break;
            case 16:
                {
                    this.A3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 176 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.A3).Click += this.button_click;
                    #line default
                }
                break;
            case 17:
                {
                    this.B1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 177 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.B1).Click += this.button_click;
                    #line default
                }
                break;
            case 18:
                {
                    this.B2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 178 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.B2).Click += this.button_click;
                    #line default
                }
                break;
            case 19:
                {
                    this.B3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 179 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.B3).Click += this.button_click;
                    #line default
                }
                break;
            case 20:
                {
                    this.C1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 180 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.C1).Click += this.button_click;
                    #line default
                }
                break;
            case 21:
                {
                    this.C2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 181 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.C2).Click += this.button_click;
                    #line default
                }
                break;
            case 22:
                {
                    this.C3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 182 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.C3).Click += this.button_click;
                    #line default
                }
                break;
            case 23:
                {
                    this.WinTextButton = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 24:
                {
                    this.winText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 25:
                {
                    this.NewGame2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 188 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.NewGame2).Click += this.NewGame_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

