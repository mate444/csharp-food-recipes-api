namespace food_recipes_api.Entities
{
    public class Recipe
    {
        public Guid Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Instructions { get; set; }
        public int Score { get; set; }
        public int HealthScore { get; set; }
    }
}
