﻿#pragma checksum "..\..\..\Vista\GestionAltaAvituallamientos.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6C62D600704E06685E0BB5CCAD9F3867A29BDF04"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
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


namespace GestionAvituallamientos.Vista {
    
    
    /// <summary>
    /// GestionAltaAvituallamientos
    /// </summary>
    public partial class GestionAltaAvituallamientos : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\..\Vista\GestionAltaAvituallamientos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lNombreCarrera;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\..\Vista\GestionAltaAvituallamientos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbNombreCarrera;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\Vista\GestionAltaAvituallamientos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btAltaCarrera;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\Vista\GestionAltaAvituallamientos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bttBorrarCarrera;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Vista\GestionAltaAvituallamientos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgCarrerasExistentes;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Vista\GestionAltaAvituallamientos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgAvituallamientosCarrera;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Vista\GestionAltaAvituallamientos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btAddAvituallamiento;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Vista\GestionAltaAvituallamientos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonModificarAvituallamiento;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Vista\GestionAltaAvituallamientos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonBorrarAvituallamiento;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Vista\GestionAltaAvituallamientos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelError;
        
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
            System.Uri resourceLocater = new System.Uri("/GestionAvituallamientos;component/vista/gestionaltaavituallamientos.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Vista\GestionAltaAvituallamientos.xaml"
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
            this.lNombreCarrera = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.tbNombreCarrera = ((System.Windows.Controls.TextBox)(target));
            
            #line 7 "..\..\..\Vista\GestionAltaAvituallamientos.xaml"
            this.tbNombreCarrera.AddHandler(System.Windows.Controls.Validation.ErrorEvent, new System.EventHandler<System.Windows.Controls.ValidationErrorEventArgs>(this.Validation_Error));
            
            #line default
            #line hidden
            return;
            case 3:
            this.btAltaCarrera = ((System.Windows.Controls.Button)(target));
            
            #line 8 "..\..\..\Vista\GestionAltaAvituallamientos.xaml"
            this.btAltaCarrera.Click += new System.Windows.RoutedEventHandler(this.btAltaCarrera_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.bttBorrarCarrera = ((System.Windows.Controls.Button)(target));
            
            #line 9 "..\..\..\Vista\GestionAltaAvituallamientos.xaml"
            this.bttBorrarCarrera.Click += new System.Windows.RoutedEventHandler(this.bttBorrarCarrera_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dgCarrerasExistentes = ((System.Windows.Controls.DataGrid)(target));
            
            #line 11 "..\..\..\Vista\GestionAltaAvituallamientos.xaml"
            this.dgCarrerasExistentes.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgCarrerasExistentes_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.dgAvituallamientosCarrera = ((System.Windows.Controls.DataGrid)(target));
            
            #line 17 "..\..\..\Vista\GestionAltaAvituallamientos.xaml"
            this.dgAvituallamientosCarrera.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgAvituallamientosCarrera_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btAddAvituallamiento = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Vista\GestionAltaAvituallamientos.xaml"
            this.btAddAvituallamiento.Click += new System.Windows.RoutedEventHandler(this.btAddAvituallamiento_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.buttonModificarAvituallamiento = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Vista\GestionAltaAvituallamientos.xaml"
            this.buttonModificarAvituallamiento.Click += new System.Windows.RoutedEventHandler(this.buttonModificarAvituallamiento_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.buttonBorrarAvituallamiento = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Vista\GestionAltaAvituallamientos.xaml"
            this.buttonBorrarAvituallamiento.Click += new System.Windows.RoutedEventHandler(this.buttonBorrarAvituallamiento_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.labelError = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

