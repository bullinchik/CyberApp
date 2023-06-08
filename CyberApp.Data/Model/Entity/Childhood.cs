﻿using System.ComponentModel.DataAnnotations;

namespace CyberApp.Data.Model.Entity;

public class Childhood
{
    [Key]
    public int Id { get; set; }

    public string Description { get; set; }
}