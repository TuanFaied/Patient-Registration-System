﻿#pragma checksum "..\..\..\..\View\AdminSettingView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "EB99C0791471AA90E78883B82B846130C69D9775"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
using Patient_Registration_System.View;
using Patient_Registration_System.ViewModel;
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


namespace Patient_Registration_System.View {
    
    
    /// <summary>
    /// AdminSettingView
    /// </summary>
    public partial class AdminSettingView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\..\View\AdminSettingView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image changeimg;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\View\AdminSettingView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button changeimgBtn;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\View\AdminSettingView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox olduserNametxt;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\View\AdminSettingView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox newuserNametxt;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\View\AdminSettingView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox userOldpasswordxt;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\View\AdminSettingView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox userNewpasswordxt;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\View\AdminSettingView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saveChanegesbtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Patient_Registration_System;V1.0.0.0;component/view/adminsettingview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\AdminSettingView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.changeimg = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.changeimgBtn = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\..\View\AdminSettingView.xaml"
            this.changeimgBtn.Click += new System.Windows.RoutedEventHandler(this.changeimgBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.olduserNametxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.newuserNametxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.userOldpasswordxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.userNewpasswordxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.saveChanegesbtn = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\..\..\View\AdminSettingView.xaml"
            this.saveChanegesbtn.Click += new System.Windows.RoutedEventHandler(this.saveChanegesbtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

