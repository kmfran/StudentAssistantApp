// Updated by XamlIntelliSenseFileGenerator 10/24/2020 2:45:22 PM
#pragma checksum "..\..\..\..\Views\MainWindowView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5EADFE23398A5B5E30D4668CF18BDAA5F820C4B9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using StudentAssistantApp.Views;
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


namespace StudentAssistantApp.Views
{


    /// <summary>
    /// MainWindowView
    /// </summary>
    public partial class MainWindowView : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 27 "..\..\..\..\Views\MainWindowView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListViewMenu;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/StudentAssistantApp;component/views/mainwindowview.xaml", System.UriKind.Relative);

#line 1 "..\..\..\..\Views\MainWindowView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.ListViewMenu = ((System.Windows.Controls.ListView)(target));
                    return;
                case 2:
                    this.ItemHome = ((System.Windows.Controls.ListViewItem)(target));
                    return;
                case 3:
                    this.ItemHome2 = ((System.Windows.Controls.ListViewItem)(target));
                    return;
                case 4:
                    this.ItemHome3 = ((System.Windows.Controls.ListViewItem)(target));
                    return;
                case 5:
                    this.ItemHome4 = ((System.Windows.Controls.ListViewItem)(target));
                    return;
                case 6:
                    this.ItemHome5 = ((System.Windows.Controls.ListViewItem)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.ListViewItem ItemNotes;
        internal System.Windows.Controls.ListViewItem ItemGrades;
        internal System.Windows.Controls.ListViewItem ItemTasks;
        internal System.Windows.Controls.ListViewItem ItemСalendar;
        internal System.Windows.Controls.ListViewItem ItemOptions;
    }
}

