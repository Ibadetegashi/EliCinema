
//using Microsoft.AspNetCore.Http;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Linq;
//using System.Threading.Tasks;

//namespace CinemaApplication.Models
//{
//    public class TvShow
//    {
//        [Key]
//        public int Id { get; set; }
//        public string Title { get; set; }
//        public DateTime ReleaseDate { get; set; }
//        public string Description { get; set; }
//        public int GenreId { get; set; }
//        public decimal Price { get; set; }
//        public string Image { get; set; }
//        [ForeignKey("GenreId")]
//        public virtual Genre Genre { get; set; }
//        public int Season { get; set; }
//        public int Episode { get; set; }
//        public double Rate { get; set; }
//        [FileExtensions]
//        public IFormFile ImageUpload { get; set; }
//    }
//}