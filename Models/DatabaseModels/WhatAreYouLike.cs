using System.ComponentModel.DataAnnotations;

namespace CyberApp.Models.DatabaseModels;

public class WhatAreYouLike
{
    [Key] public int WhatAreYouLikeId { get; set; }
    public string WhatAreYouLikeDescription { get; set; }
}