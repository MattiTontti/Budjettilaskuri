﻿#pragma checksum "..\..\..\Vedenkulutus.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05F932A8EABE98660914F211AC9DD478A95EABAA"
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
    /// Vedenkulutus
    /// </summary>
    public partial class Vedenkulutus : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Vedenkulutus.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox VesiKKK;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Vedenkulutus.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EdellKKK;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Vedenkulutus.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock VesiKKL;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Vedenkulutus.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Vesikk;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Vedenkulutus.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EdellVesikk;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Vedenkulutus.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Kuukausittaisetkjm;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Vedenkulutus.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox KuukaudenKulutus;
        
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
            System.Uri resourceLocater = new System.Uri("/Budjettilaskuri;component/vedenkulutus.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Vedenkulutus.xaml"
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
            this.VesiKKK = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\..\Vedenkulutus.xaml"
            this.VesiKKK.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.VesiKKK_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.EdellKKK = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\..\Vedenkulutus.xaml"
            this.EdellKKK.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.EdellKKK_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.VesiKKL = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.Vesikk = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.EdellVesikk = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Kuukausittaisetkjm = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.KuukaudenKulutus = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

