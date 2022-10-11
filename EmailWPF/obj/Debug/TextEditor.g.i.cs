﻿#pragma checksum "..\..\TextEditor.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "09FBF76D1278A5970F872690949FDF5280522665E18F815FF7F893E1C74BD9D1"
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
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace EmailWPF {
    
    
    /// <summary>
    /// TextEditor
    /// </summary>
    public partial class TextEditor : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\TextEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FontSize;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\TextEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FontFam;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\TextEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.ColorPicker ColorTable;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\TextEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox rtfbox;
        
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
            System.Uri resourceLocater = new System.Uri("/EmailWPF;component/texteditor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TextEditor.xaml"
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
            
            #line 23 "..\..\TextEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Bold);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 24 "..\..\TextEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Italic);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 25 "..\..\TextEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Underline);
            
            #line default
            #line hidden
            return;
            case 4:
            this.FontSize = ((System.Windows.Controls.ComboBox)(target));
            
            #line 32 "..\..\TextEditor.xaml"
            this.FontSize.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FontSize_Selected);
            
            #line default
            #line hidden
            
            #line 32 "..\..\TextEditor.xaml"
            this.FontSize.DropDownClosed += new System.EventHandler(this.FontSize_DropDownClosed);
            
            #line default
            #line hidden
            return;
            case 5:
            this.FontFam = ((System.Windows.Controls.ComboBox)(target));
            
            #line 42 "..\..\TextEditor.xaml"
            this.FontFam.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FontFam_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 48 "..\..\TextEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Testing);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ColorTable = ((Xceed.Wpf.Toolkit.ColorPicker)(target));
            
            #line 49 "..\..\TextEditor.xaml"
            this.ColorTable.SelectedColorChanged += new System.Windows.RoutedPropertyChangedEventHandler<System.Nullable<System.Windows.Media.Color>>(this.ColorTable_SelectedColorChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.rtfbox = ((System.Windows.Controls.RichTextBox)(target));
            
            #line 61 "..\..\TextEditor.xaml"
            this.rtfbox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.rtfbox_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
