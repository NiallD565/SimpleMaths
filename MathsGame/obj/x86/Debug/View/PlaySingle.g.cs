﻿#pragma checksum "C:\Users\niall\OneDrive\Documents\GitHub\SimpleMaths\MathsGame\View\PlaySingle.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8AA3640CC399604F082D0B3B4DC79CBC"
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
    partial class PlaySingle : 
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
                    this.btnTrue = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 37 "..\..\..\View\PlaySingle.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnTrue).Click += this.btnTrue_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.btnFalse = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 39 "..\..\..\View\PlaySingle.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnFalse).Click += this.btnFalse_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.txtMath = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.txtState = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.progressBar = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 6:
                {
                    this.txtScore = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.txtHighScore = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

