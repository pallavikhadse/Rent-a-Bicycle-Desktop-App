﻿#pragma checksum "..\..\W_CustomerDetails.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "91F26A61890445C29A998869603A6EF5CDBB83363F4605BC00DD4E09BD2F1348"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Rent_a_Bicycle_App;
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


namespace Rent_a_Bicycle_App {
    
    
    /// <summary>
    /// W_CustomerDetails
    /// </summary>
    public partial class W_CustomerDetails : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\W_CustomerDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tbx_FilterId_Customer;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\W_CustomerDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Del;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\W_CustomerDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Add;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\W_CustomerDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox Lbx_Customers;
        
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
            System.Uri resourceLocater = new System.Uri("/Rent a Bicycle App;component/w_customerdetails.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\W_CustomerDetails.xaml"
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
            
            #line 9 "..\..\W_CustomerDetails.xaml"
            ((Rent_a_Bicycle_App.W_CustomerDetails)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 10 "..\..\W_CustomerDetails.xaml"
            ((Rent_a_Bicycle_App.W_CustomerDetails)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Tbx_FilterId_Customer = ((System.Windows.Controls.TextBox)(target));
            
            #line 40 "..\..\W_CustomerDetails.xaml"
            this.Tbx_FilterId_Customer.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Tbx_FilterId_Customer_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Btn_Del = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\W_CustomerDetails.xaml"
            this.Btn_Del.Click += new System.Windows.RoutedEventHandler(this.Btn_Del_Customer_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Btn_Add = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\W_CustomerDetails.xaml"
            this.Btn_Add.Click += new System.Windows.RoutedEventHandler(this.Btn_Add_Customer_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Lbx_Customers = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

