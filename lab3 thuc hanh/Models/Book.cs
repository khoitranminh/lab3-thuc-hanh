namespace lab3_thuc_hanh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage ="ID không được để trống")]
        public int ID { get; set; }
        [Required(ErrorMessage = "Tiêu đề không được để trống")]
        [StringLength(100,ErrorMessage ="Tiêu đề không được quá 100 ký tự")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Nội dung không được để trống")]
        [StringLength(100, ErrorMessage = "Nội dung không được quá 100 ký tự")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Tác giả không được để trống")]
        [StringLength(30, ErrorMessage = "Tác giả không được quá 30 ký tự")]
        public string Author { get; set; }

        [StringLength(255)]
        public string Images { get; set; }
        [Required]
        [Range(1000,1000000,ErrorMessage ="Gía sách từ 1000 đến 1000000")]
        public int? Pice { get; set; }
    }
}
