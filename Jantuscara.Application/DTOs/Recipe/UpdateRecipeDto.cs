namespace Jantuscara.Application.DTOs.Recipe
{
    public record UpdateRecipeDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateOnly CreationDate { get; set; }
    }
}
