namespace RAFWEB2.Data.Models
{
    public class Article : BaseEntity
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string Text { get; set; }
        public string OrganizationName { get; set; }
        public int HolidayId { get; set; }
    }
}
