﻿
using CyberApp.View_Model;

namespace CyberApp.View;

public partial class CreateCharacter : ContentPage
{
    private readonly IServiceProvider _serviceProvider;
    public CreateCharacter(IServiceProvider serviceProvider)
    {
        InitializeComponent();

        _serviceProvider = serviceProvider;
    }
}