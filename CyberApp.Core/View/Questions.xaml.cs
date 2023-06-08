using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyberApp.Services.Contracts;

namespace CyberApp.View;

public partial class Questions : ContentPage
{
    private readonly IQuestionsService _questionsService;
    
    public Questions(IQuestionsService questionsService)
    {
        InitializeComponent();

        _questionsService = questionsService;
    }
}