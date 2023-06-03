﻿using System.ComponentModel.DataAnnotations;

namespace CyberApp.Models.DatabaseModels;

public class Language
{
    [Key] public int LanguageId { get; set; }
    public string LanguageName { get; set; }
}