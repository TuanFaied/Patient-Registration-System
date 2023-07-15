﻿#pragma checksum "..\..\..\..\View\UserView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CFED070E536622A95C58C063C005F70BB8C35E56"
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
    /// UserView
    /// </summary>
    public partial class UserView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 67 "..\..\..\..\View\UserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button powerbtn;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\..\View\UserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel pnlControlBar;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\..\View\UserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button closeBtn;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\..\View\UserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button maximizeBtn;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\..\View\UserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button minimizeBtn;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\..\View\UserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button logOut;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\..\..\View\UserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock UserNameTextBlock;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\..\View\UserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ImageBrush MyImageControl;
        
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
            System.Uri resourceLocater = new System.Uri("/Patient_Registration_System;V1.0.0.0;component/view/userview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\UserView.xaml"
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
            this.powerbtn = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\..\View\UserView.xaml"
            this.powerbtn.Click += new System.Windows.RoutedEventHandler(this.powerbtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.pnlControlBar = ((System.Windows.Controls.StackPanel)(target));
            
            #line 85 "..\..\..\..\View\UserView.xaml"
            this.pnlControlBar.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.pnlControlBar_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.closeBtn = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\..\..\View\UserView.xaml"
            this.closeBtn.Click += new System.Windows.RoutedEventHandler(this.closeBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.maximizeBtn = ((System.Windows.Controls.Button)(target));
            
            #line 90 "..\..\..\..\View\UserView.xaml"
            this.maximizeBtn.Click += new System.Windows.RoutedEventHandler(this.maximizeBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.minimizeBtn = ((System.Windows.Controls.Button)(target));
            
            #line 93 "..\..\..\..\View\UserView.xaml"
            this.minimizeBtn.Click += new System.Windows.RoutedEventHandler(this.minimizeBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.logOut = ((System.Windows.Controls.Button)(target));
            
            #line 121 "..\..\..\..\View\UserView.xaml"
            this.logOut.Click += new System.Windows.RoutedEventHandler(this.logOut_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.UserNameTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.MyImageControl = ((System.Windows.Media.ImageBrush)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

