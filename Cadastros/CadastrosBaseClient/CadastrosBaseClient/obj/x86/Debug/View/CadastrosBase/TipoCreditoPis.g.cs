﻿#pragma checksum "..\..\..\..\..\View\CadastrosBase\TipoCreditoPis.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "20AE8626D1D40D2EC3DA84F3DB3808A9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CadastrosBaseClient.CadastrosBaseReference;
using Microsoft.Windows.Controls;
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


namespace CadastrosBaseClient.View.CadastrosBase {
    
    
    /// <summary>
    /// TipoCreditoPis
    /// </summary>
    public partial class TipoCreditoPis : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\..\View\CadastrosBase\TipoCreditoPis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btSalvar;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\..\View\CadastrosBase\TipoCreditoPis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btSair;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\View\CadastrosBase\TipoCreditoPis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox codigoTextBox;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\..\View\CadastrosBase\TipoCreditoPis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox descricaoTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/CadastrosBaseClient;component/view/cadastrosbase/tipocreditopis.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\CadastrosBase\TipoCreditoPis.xaml"
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
            this.btSalvar = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\..\..\View\CadastrosBase\TipoCreditoPis.xaml"
            this.btSalvar.Click += new System.Windows.RoutedEventHandler(this.btSalvar_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btSair = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\..\..\View\CadastrosBase\TipoCreditoPis.xaml"
            this.btSair.Click += new System.Windows.RoutedEventHandler(this.btSair_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.codigoTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.descricaoTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

