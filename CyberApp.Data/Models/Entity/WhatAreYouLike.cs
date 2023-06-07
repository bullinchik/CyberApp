using System.ComponentModel.DataAnnotations;

namespace CyberApp.Data.Models.Entity;

public class WhatAreYouLike
{
    [Key] public int WhatAreYouLikeId { get; set; }
    public string WhatAreYouLikeDescription { get; set; }
}