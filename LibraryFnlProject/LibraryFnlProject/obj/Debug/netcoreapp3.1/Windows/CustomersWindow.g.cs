﻿#pragma checksum "..\..\..\..\Windows\CustomersWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4DF2822451256E316D8A738639513F027AFF0AB0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LibraryFnlProject.Windows;
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


namespace LibraryFnlProject.Windows {
    
    
    /// <summary>
    /// CustomersWindow
    /// </summary>
    public partial class CustomersWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\Windows\CustomersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblFullname;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\Windows\CustomersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtFullname;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\Windows\CustomersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblFinCode;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\Windows\CustomersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtFinCode;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\Windows\CustomersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblPhone;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\Windows\CustomersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtPhone;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Windows\CustomersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddCustomer;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\Windows\CustomersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DgvCustomer;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Windows\CustomersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnUpdate;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Windows\CustomersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDelete;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LibraryFnlProject;component/windows/customerswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\CustomersWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.LblFullname = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.TxtFullname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.LblFinCode = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.TxtFinCode = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.LblPhone = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.TxtPhone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.BtnAddCustomer = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\..\Windows\CustomersWindow.xaml"
            this.BtnAddCustomer.Click += new System.Windows.RoutedEventHandler(this.BtnAddCustomer_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.DgvCustomer = ((System.Windows.Controls.DataGrid)(target));
            
            #line 17 "..\..\..\..\Windows\CustomersWindow.xaml"
            this.DgvCustomer.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DgvCustomer_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.BtnUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\Windows\CustomersWindow.xaml"
            this.BtnUpdate.Click += new System.Windows.RoutedEventHandler(this.BtnUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.BtnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\Windows\CustomersWindow.xaml"
            this.BtnDelete.Click += new System.Windows.RoutedEventHandler(this.BtnDelete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

