using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.Content;
using CyberApp.View_Model;

namespace CyberApp.View;

public partial class ClassSelection : TabbedPage
{
    public ClassSelection()
    {
        InitializeComponent();

        ClassSelectionViewModel classSelectionViewModel = new ClassSelectionViewModel();
        BindingContext = classSelectionViewModel;
        ItemsSource = classSelectionViewModel.ClassCollection;
    }
}