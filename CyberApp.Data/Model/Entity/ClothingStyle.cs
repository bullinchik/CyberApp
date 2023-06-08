﻿using System.ComponentModel.DataAnnotations;

namespace CyberApp.Data.Models.Entity;

public class ClothingStyle
{
    [Key] 
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}