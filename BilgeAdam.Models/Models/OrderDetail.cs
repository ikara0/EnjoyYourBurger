using BilgeAdam.Models.Enums;

namespace BilgeAdam.Models.Models
{
    public class OrderDetail
    {
        public Bread Bread { get; set; }
        public Meat Meat { get; set; }
        public HashSet<Extra> Extras { get; set; }
        public HashSet<FreeExtra> FreeExtras { get; set; }
    }
}
