﻿#pragma checksum "..\..\..\KuukausiWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D8DFD20EA309179A47C53F773BEBB3F818676101"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Budjettilaskuri;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Budjettilaskuri {
    
    
    /// <summary>
    /// KuukausiWindow
    /// </summary>
    public partial class KuukausiWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\KuukausiWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBox;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\KuukausiWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox menotBox;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\KuukausiWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBox2;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\KuukausiWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tulotBox;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\KuukausiWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button lisääMeno;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\KuukausiWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button lisääTulo;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\KuukausiWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox toistuvaCheck;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\KuukausiWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox toistuvaCheck2;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Budjettilaskuri;component/kuukausiwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\KuukausiWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.comboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 10 "..\..\..\KuukausiWindow.xaml"
            this.comboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.menotBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 11 "..\..\..\KuukausiWindow.xaml"
            this.menotBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.menotBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.comboBox2 = ((System.Windows.Controls.ComboBox)(target));
            
            #line 14 "..\..\..\KuukausiWindow.xaml"
            this.comboBox2.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboBox2_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tulotBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\..\KuukausiWindow.xaml"
            this.tulotBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tulotBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lisääMeno = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\KuukausiWindow.xaml"
            this.lisääMeno.Click += new System.Windows.RoutedEventHandler(this.lisääMeno_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lisääTulo = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\KuukausiWindow.xaml"
            this.lisääTulo.Click += new System.Windows.RoutedEventHandler(this.lisääTulo_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.toistuvaCheck = ((System.Windows.Controls.CheckBox)(target));
            
            #line 20 "..\..\..\KuukausiWindow.xaml"
            this.toistuvaCheck.Checked += new System.Windows.RoutedEventHandler(this.toistuvaCheck_Checked);
            
            #line default
            #line hidden
            
            #line 20 "..\..\..\KuukausiWindow.xaml"
            this.toistuvaCheck.Unchecked += new System.Windows.RoutedEventHandler(this.toistuvaCheck_Unchecked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.toistuvaCheck2 = ((System.Windows.Controls.CheckBox)(target));
            
            #line 21 "..\..\..\KuukausiWindow.xaml"
            this.toistuvaCheck2.Checked += new System.Windows.RoutedEventHandler(this.toistuvaCheck2_Checked);
            
            #line default
            #line hidden
            
            #line 21 "..\..\..\KuukausiWindow.xaml"
            this.toistuvaCheck2.Unchecked += new System.Windows.RoutedEventHandler(this.toistuvaCheck2_Unchecked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

