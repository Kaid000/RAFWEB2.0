namespace RAFWEB2.Data.Models
{
    public class Holiday : BaseEntity
    {
        public DateTime PerformedDate { get; set; }
        public string OrganizationName { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
    }
}
