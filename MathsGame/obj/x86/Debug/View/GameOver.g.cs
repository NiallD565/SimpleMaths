﻿#pragma checksum "C:\Users\niall\OneDrive\Documents\GitHub\SimpleMaths\MathsGame\View\GameOver.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DD0AC425C74E4E5E09F0138AA9AEF3F6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MathsGame.View
{
    partial class GameOver : 
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
                    this.btnTryAgain = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 32 "..\..\..\View\GameOver.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnTryAgain).Click += this.btnTryAgain_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.btnHome = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 34 "..\..\..\View\GameOver.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnHome).Click += this.btnHome_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.Score = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.txtTitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.NewScore = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

