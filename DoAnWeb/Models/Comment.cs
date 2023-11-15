using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnWeb.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string UserId { get; set; }

        // Reference navigation property cho khóa ngoại đến User
        [ForeignKey("UserId")]
        public User User { get; set; }

        public int ProductId { get; set; }

        // Reference navigation property cho khóa ngoại đến Product
        [ForeignKey("ProductId")]
        public Product Product  { get; set; }

        public int? CommentId { get; set; }
        [ForeignKey("CommentId")]
        public Comment ParentComment { get; set; }



        public string contentComment { get; set; }


        public DateTime Create_At {  get; set; }


    }
}
