﻿#pragma checksum "..\..\ShopOrdering.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B4F4C17B2FF8A0D8F60BCBDC7EFAB222D145E7E2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using KURSACH_22;
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
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace KURSACH_22 {
    
    
    /// <summary>
    /// ShopOrdering
    /// </summary>
    public partial class ShopOrdering : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 67 "..\..\ShopOrdering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.IntegerUpDown newCost;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\ShopOrdering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.IntegerUpDown goodChAim;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\ShopOrdering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addG;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\ShopOrdering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button chngC;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\ShopOrdering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clearG;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\ShopOrdering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ord;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\ShopOrdering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox goods_id;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\ShopOrdering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox goods_lb;
        
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
            System.Uri resourceLocater = new System.Uri("/KURSACH_22;component/shopordering.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ShopOrdering.xaml"
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
            this.newCost = ((Xceed.Wpf.Toolkit.IntegerUpDown)(target));
            return;
            case 2:
            this.goodChAim = ((Xceed.Wpf.Toolkit.IntegerUpDown)(target));
            return;
            case 3:
            this.addG = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\ShopOrdering.xaml"
            this.addG.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.chngC = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\ShopOrdering.xaml"
            this.chngC.Click += new System.Windows.RoutedEventHandler(this.Button_Click3);
            
            #line default
            #line hidden
            return;
            case 5:
            this.clearG = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\ShopOrdering.xaml"
            this.clearG.Click += new System.Windows.RoutedEventHandler(this.Button_Click2);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ord = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\ShopOrdering.xaml"
            this.ord.Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 7:
            this.goods_id = ((System.Windows.Controls.ListBox)(target));
            return;
            case 8:
            this.goods_lb = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

