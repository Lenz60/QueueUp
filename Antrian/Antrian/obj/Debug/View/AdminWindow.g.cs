﻿#pragma checksum "..\..\..\View\AdminWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2485784CFF552931B8E395D75EFA4D05DFAA71AB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Antrian.View;
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


namespace Antrian.View {
    
    
    /// <summary>
    /// AdminWindow
    /// </summary>
    public partial class AdminWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\View\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LbAdmin;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\View\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtUsername;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\View\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image LogoAdmin;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\View\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LbUsername;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\View\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LbPassword;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\View\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image BtnLogin;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\View\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PBPassword;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\View\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image BtnBack;
        
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
            System.Uri resourceLocater = new System.Uri("/Antrian;component/view/adminwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\AdminWindow.xaml"
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
            this.LbAdmin = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.TxtUsername = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\..\View\AdminWindow.xaml"
            this.TxtUsername.KeyDown += new System.Windows.Input.KeyEventHandler(this.TxtUsername_KeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LogoAdmin = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.LbUsername = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.LbPassword = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.BtnLogin = ((System.Windows.Controls.Image)(target));
            
            #line 17 "..\..\..\View\AdminWindow.xaml"
            this.BtnLogin.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.BtnLogin_MouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.PBPassword = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 18 "..\..\..\View\AdminWindow.xaml"
            this.PBPassword.KeyDown += new System.Windows.Input.KeyEventHandler(this.PBPassword_KeyDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtnBack = ((System.Windows.Controls.Image)(target));
            
            #line 19 "..\..\..\View\AdminWindow.xaml"
            this.BtnBack.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.BtnBack_MouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
