namespace InsureYouAI.Entity.Entities
{
    public class PricingPlan
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public bool IsFeature {  get; set; }
    }
}
