﻿#pragma checksum "E:\vsproject\ClockApp\ClockApp\CountdownPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "955CCAA1D4D37F96F40F2D3B254439B94205723F1FA0606F33790F8D898D0B7B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClockApp
{
    partial class CountdownPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // CountdownPage.xaml line 1
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    ((global::Windows.UI.Xaml.Controls.Page)element1).Loaded += this.Page_Loaded;
                }
                break;
            case 78: // CountdownPage.xaml line 540
                {
                    this.timeDisplayStackPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 79: // CountdownPage.xaml line 569
                {
                    this.countdownProgress = (global::Microsoft.UI.Xaml.Controls.ProgressBar)(target);
                    ((global::Microsoft.UI.Xaml.Controls.ProgressBar)this.countdownProgress).ValueChanged += this.CountdownProgress_ValueChanged;
                }
                break;
            case 80: // CountdownPage.xaml line 580
                {
                    this.info = (global::Microsoft.UI.Xaml.Controls.InfoBar)(target);
                }
                break;
            case 81: // CountdownPage.xaml line 584
                {
                    this.infoBarOpen = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                }
                break;
            case 82: // CountdownPage.xaml line 576
                {
                    this.startOrPauseCountdownButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.startOrPauseCountdownButton).Click += this.StartOrPauseCountdownButton_Click;
                }
                break;
            case 83: // CountdownPage.xaml line 541
                {
                    this.hourNumSetBox = (global::Microsoft.UI.Xaml.Controls.NumberBox)(target);
                    ((global::Microsoft.UI.Xaml.Controls.NumberBox)this.hourNumSetBox).ValueChanged += this.HourNumSetBox_ValueChanged;
                }
                break;
            case 84: // CountdownPage.xaml line 547
                {
                    this.hourNumTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 85: // CountdownPage.xaml line 551
                {
                    this.minuteNumSetBox = (global::Microsoft.UI.Xaml.Controls.NumberBox)(target);
                    ((global::Microsoft.UI.Xaml.Controls.NumberBox)this.minuteNumSetBox).ValueChanged += this.MinuteNumSetBox_ValueChanged;
                }
                break;
            case 86: // CountdownPage.xaml line 557
                {
                    this.minuteNumTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 87: // CountdownPage.xaml line 561
                {
                    this.secondNumSetBox = (global::Microsoft.UI.Xaml.Controls.NumberBox)(target);
                    ((global::Microsoft.UI.Xaml.Controls.NumberBox)this.secondNumSetBox).ValueChanged += this.SecondNumSetBox_ValueChanged;
                }
                break;
            case 88: // CountdownPage.xaml line 567
                {
                    this.secondNumTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

