﻿#pragma checksum "..\..\..\MainPages\AddNewArticlePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E7476C920224031EEA1D7A87F903FF30"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HMTDPTeamLibraryProject.ViewModels;
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


namespace HMTDPTeamLibraryProject {
    
    
    /// <summary>
    /// AddNewArticlePage
    /// </summary>
    public partial class AddNewArticlePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 60 "..\..\..\MainPages\AddNewArticlePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox yearbox;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\MainPages\AddNewArticlePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox monthbox;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\MainPages\AddNewArticlePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox daybox;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\MainPages\AddNewArticlePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker helpDatePicker;
        
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
            System.Uri resourceLocater = new System.Uri("/HMTDPTeamLibraryProject;component/mainpages/addnewarticlepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainPages\AddNewArticlePage.xaml"
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
            this.yearbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.monthbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.daybox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.helpDatePicker = ((System.Windows.Controls.DatePicker)(target));
            
            #line 67 "..\..\..\MainPages\AddNewArticlePage.xaml"
            this.helpDatePicker.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.SelectedDateClick);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 96 "..\..\..\MainPages\AddNewArticlePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnAddClick);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 102 "..\..\..\MainPages\AddNewArticlePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnArticlesClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

