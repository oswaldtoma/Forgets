﻿#pragma checksum "..\..\TimePicker.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6A8A03E3585AA661EA5FE1CDE0810B085F4E7A4060538A44318A3AD62DE7B48D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using Forgets;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace Forgets {
    
    
    /// <summary>
    /// TimePicker
    /// </summary>
    public partial class TimePicker : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\TimePicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HrTextBox;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\TimePicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MinTextBox;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\TimePicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SecTextBox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\TimePicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label SecLabel;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\TimePicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button IncButton;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\TimePicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DecButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Forgets;component/timepicker.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TimePicker.xaml"
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
            this.HrTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 9 "..\..\TimePicker.xaml"
            this.HrTextBox.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TextBox_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 9 "..\..\TimePicker.xaml"
            this.HrTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MinTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 10 "..\..\TimePicker.xaml"
            this.MinTextBox.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TextBox_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 10 "..\..\TimePicker.xaml"
            this.MinTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SecTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 11 "..\..\TimePicker.xaml"
            this.SecTextBox.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TextBox_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 11 "..\..\TimePicker.xaml"
            this.SecTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SecLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.IncButton = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\TimePicker.xaml"
            this.IncButton.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DecButton = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\TimePicker.xaml"
            this.DecButton.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

