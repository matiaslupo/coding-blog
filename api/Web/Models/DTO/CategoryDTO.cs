﻿namespace Web.Models.DTO;

public class CategoryDTO
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? UrlHandle { get; set; }
}
