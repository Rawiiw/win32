﻿#pragma checksum "..\..\NetworkInfo.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7F438DBC6E3A59230245A96A1C31DE866B85DD99275D0E356DE46DEA3EE8B632"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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


namespace Win32 {
    
    
    /// <summary>
    /// NetworkInfo
    /// </summary>
    public partial class NetworkInfo : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\NetworkInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas MCanvas;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\NetworkInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox Navigation;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\NetworkInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonBack;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\NetworkInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonNext;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\NetworkInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox NetList;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\NetworkInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ToolBar User;
        
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
            System.Uri resourceLocater = new System.Uri("/Win32;component/networkinfo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\NetworkInfo.xaml"
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
            this.MCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 2:
            this.Navigation = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.ButtonBack = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.ButtonNext = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.NetList = ((System.Windows.Controls.ListBox)(target));
            
            #line 33 "..\..\NetworkInfo.xaml"
            this.NetList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.NetList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.User = ((System.Windows.Controls.ToolBar)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
