﻿#pragma checksum "..\..\Shop.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8B2ED64813C21CBE7DD6025AA9A539A763B5C70F3311880A688AEECDF8846A9F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using finalproject;


namespace finalproject {
    
    
    /// <summary>
    /// Shop
    /// </summary>
    public partial class Shop : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\Shop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label shoplabel;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Shop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button homebtn;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Shop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button shopbtn;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Shop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image itemimagebox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Shop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label pricetxt;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Shop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label conditiontxt;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Shop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ogvaluetxt;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Shop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label sizetxt;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Shop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label itemnametxt;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Shop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid datagrid;
        
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
            System.Uri resourceLocater = new System.Uri("/finalproject;component/shop.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Shop.xaml"
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
            
            #line 8 "..\..\Shop.xaml"
            ((finalproject.Shop)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.shoplabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.homebtn = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Shop.xaml"
            this.homebtn.Click += new System.Windows.RoutedEventHandler(this.homebtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.shopbtn = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\Shop.xaml"
            this.shopbtn.Click += new System.Windows.RoutedEventHandler(this.shopbtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.itemimagebox = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.pricetxt = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.conditiontxt = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.ogvaluetxt = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.sizetxt = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            
            #line 30 "..\..\Shop.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddToCart);
            
            #line default
            #line hidden
            return;
            case 11:
            this.itemnametxt = ((System.Windows.Controls.Label)(target));
            return;
            case 12:
            this.datagrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 40 "..\..\Shop.xaml"
            this.datagrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SelectionChanges);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 41 "..\..\Shop.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

