namespace food_recipes_api.Entities
{
    public class Recipe
    {
        public Guid Id { get; set; }

        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Instructions { get; set; } = string.Empty;
        public int Score { get; set; }
        public int HealthScore { get; set; }
        public string Image { get; set; } = string.Empty;
    }
}
