﻿#pragma checksum "..\..\..\MainPages\ReadArticlePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6DB5CFB9D99BE26A2858E573D47C4835"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
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
    /// ReadArticlePage
    /// </summary>
    public partial class ReadArticlePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\MainPages\ReadArticlePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox titleArticle;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\MainPages\ReadArticlePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox authorTextBox;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\MainPages\ReadArticlePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox dateTextBox;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\MainPages\ReadArticlePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox categoryTextBox;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\MainPages\ReadArticlePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox descriptionTextBox;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\MainPages\ReadArticlePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox contentsTextBox;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\..\MainPages\ReadArticlePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editButton;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\..\MainPages\ReadArticlePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image artimage;
        
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
            System.Uri resourceLocater = new System.Uri("/HMTDPTeamLibraryProject;component/mainpages/readarticlepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainPages\ReadArticlePage.xaml"
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
            
            #line 8 "..\..\..\MainPages\ReadArticlePage.xaml"
            ((HMTDPTeamLibraryProject.ReadArticlePage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.titleArticle = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.authorTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.dateTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.categoryTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.descriptionTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.contentsTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 93 "..\..\..\MainPages\ReadArticlePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddNewArticleClick);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 112 "..\..\..\MainPages\ReadArticlePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ViewArticlesClick);
            
            #line default
            #line hidden
            return;
            case 10:
            this.editButton = ((System.Windows.Controls.Button)(target));
            
            #line 131 "..\..\..\MainPages\ReadArticlePage.xaml"
            this.editButton.Click += new System.Windows.RoutedEventHandler(this.EditArticlesClick);
            
            #line default
            #line hidden
            return;
            case 11:
            this.artimage = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

