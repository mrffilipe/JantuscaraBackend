﻿namespace Jantuscara.Application.DTOs.Category
{
    public record UpdateCategoryDto
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
    }
}
