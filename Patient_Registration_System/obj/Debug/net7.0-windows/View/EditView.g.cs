﻿#pragma checksum "..\..\..\..\View\EditView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "695C858C6A79C08E4CC10D03C1C1E84810616F43"
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
    /// EditView
    /// </summary>
    public partial class EditView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\..\..\View\EditView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Eidtxt;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\View\EditView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker Edatetxt;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\View\EditView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Emedicinetxt;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\View\EditView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Ediscribtiontxt;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\View\EditView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Eamounttxt;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\View\EditView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Updatebtn;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\View\EditView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/Patient_Registration_System;V1.0.0.0;component/view/editview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\EditView.xaml"
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
            
            #line 10 "..\..\..\..\View\EditView.xaml"
            ((Patient_Registration_System.View.EditView)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Eidtxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Edatetxt = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.Emedicinetxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Ediscribtiontxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Eamounttxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.Updatebtn = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\..\View\EditView.xaml"
            this.Updatebtn.Click += new System.Windows.RoutedEventHandler(this.Updatebtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BackBtn = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\..\..\View\EditView.xaml"
            this.BackBtn.Click += new System.Windows.RoutedEventHandler(this.BackBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

