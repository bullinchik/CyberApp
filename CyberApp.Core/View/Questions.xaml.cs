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