using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnWeb.Models
{
    public class HistorySearch
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        public string ContentSearch {  get; set; }

        public DateTime Create_At { get; set; }
    }
}
