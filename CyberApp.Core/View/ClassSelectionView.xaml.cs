using System;
using System.Collections.Generic;
using System.Linq;
using CyberApp.View_Model;

namespace CyberApp.View;

public partial class ClassSelection : TabbedPage
{
    public ClassSelection(ClassSelectionViewModel classSelectionViewModel)
    {
        InitializeComponent();
        
        BindingContext = classSelectionViewModel;
        ItemsSource = classSelectionViewModel.ClassCollection;
    }
}