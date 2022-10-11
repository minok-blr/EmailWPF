﻿#pragma checksum "..\..\DialogWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4F557BBA65DF81362A472523F104DB1408F253D49CAE01914128145A5DDCE5BC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using EmailWPF;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace EmailWPF {
    
    
    /// <summary>
    /// DialogWindow
    /// </summary>
    public partial class DialogWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\DialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox mailboxBox;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\DialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem sender1;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\DialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem sender2;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\DialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Content;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\DialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Subject;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\DialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CopyRec;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\DialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RecipientBox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\DialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox AttachNames;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\DialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SendButton;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\DialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AttachButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/EmailWPF;component/dialogwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DialogWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.mailboxBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.sender1 = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 3:
            this.sender2 = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 4:
            this.Content = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Subject = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.CopyRec = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.RecipientBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.AttachNames = ((System.Windows.Controls.ListBox)(target));
            return;
            case 9:
            this.SendButton = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\DialogWindow.xaml"
            this.SendButton.Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 10:
            this.AttachButton = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\DialogWindow.xaml"
            this.AttachButton.Click += new System.Windows.RoutedEventHandler(this.Button_Click_2Attach);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

