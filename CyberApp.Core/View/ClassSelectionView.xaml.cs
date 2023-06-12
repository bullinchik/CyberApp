using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Windows.Input;
using Android.Content;
using Android.OS;
using Android.Util;
using Android.Widget;
using CyberApp.View_Model;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using Microsoft.Maui.Layouts;

namespace CyberApp.View;

public partial class ClassSelectionView : TabbedPage
{
    private Page previousPage;
    public ClassSelectionView(ClassSelectionViewModel classSelectionViewModel)
    {
        InitializeComponent();
        
        BindingContext = classSelectionViewModel;
        ItemsSource = classSelectionViewModel.ClassCollection;
        
        foreach (var page in Children)
        {
            Image image = (Image)page.FindByName("ImageView");

            TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += delegate(object sender, TappedEventArgs args) { OnImagePress(); };
            image.GestureRecognizers.Add(tapGestureRecognizer);
        }
        
        this.CurrentPageChanged += (object IntentSender, EventArgs e) =>
        {
            Image? classImage = (Image)previousPage.FindByName("ImageView");
            FlexLayout description = (FlexLayout)previousPage.FindByName("DescriptionView");
            if (classImage is not null && description is not null)
            {
                classImage.IsVisible = true;
                description.IsVisible = false;
            }
        };
    }

    private void OnImagePress()
    {
        Image classImage = CurrentPage.FindByName("ImageView") as Image;
        Grid Grid = CurrentPage.FindByName("DescriptionView") as Grid;
        DisplayAlert("Click", $"Click class Image {classImage is null} and Description {Grid is null}", "ok");
        classImage.IsVisible = false;
        Grid.IsVisible = true;
        previousPage = CurrentPage;
    }
}