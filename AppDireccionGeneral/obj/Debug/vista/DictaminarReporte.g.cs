#pragma checksum "..\..\..\vista\DictaminarReporte.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "97A75F23329C21782C3F8705BB578FB1C0DAB7C7A131CA8FBF4AF4675ADA2AD7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AppDireccionGeneral.vista;
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


namespace AppDireccionGeneral.vista {
    
    
    /// <summary>
    /// DictaminarReporte
    /// </summary>
    public partial class DictaminarReporte : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\vista\DictaminarReporte.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancelar;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\vista\DictaminarReporte.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbFolio;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\vista\DictaminarReporte.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpFecha;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\vista\DictaminarReporte.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbDelegacion;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\vista\DictaminarReporte.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbDireccion;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\vista\DictaminarReporte.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbPerito;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\vista\DictaminarReporte.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbPerito;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\vista\DictaminarReporte.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbDescripcion;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\..\vista\DictaminarReporte.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDictaminar;
        
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
            System.Uri resourceLocater = new System.Uri("/AppDireccionGeneral;component/vista/dictaminarreporte.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\vista\DictaminarReporte.xaml"
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
            this.btnCancelar = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\vista\DictaminarReporte.xaml"
            this.btnCancelar.Click += new System.Windows.RoutedEventHandler(this.btnCancelar_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tbFolio = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.dpFecha = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.tbDelegacion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbDireccion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.lbPerito = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.cbPerito = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.tbDescripcion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.btnDictaminar = ((System.Windows.Controls.Button)(target));
            
            #line 141 "..\..\..\vista\DictaminarReporte.xaml"
            this.btnDictaminar.Click += new System.Windows.RoutedEventHandler(this.btnDictaminar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

