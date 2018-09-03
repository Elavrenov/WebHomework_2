using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebHomework_2.Models;

namespace WebHomework_2.DAL
{
    public class GalleryContext:DbContext
    {
        public DbSet<Photo> Photos { get; set; }
    }
    public class GalleryDbInitializer :DropCreateDatabaseIfModelChanges<GalleryContext>
    {
        protected override void Seed(GalleryContext db)
        {
            db.Photos.Add(new Photo() { Description = "1", ImagePath = "/images/1.jpg", ThumbPath = "/images/1.jpg", CreatedOn = DateTime.Now.Date });
            db.Photos.Add(new Photo() { Description = "2", ImagePath = "/images/2.jpg", ThumbPath = "/images/2.jpg", CreatedOn = DateTime.Now.Date });
            db.Photos.Add(new Photo() { Description = "3", ImagePath = "/images/3.jpg", ThumbPath = "/images/3.jpg", CreatedOn = DateTime.Now.Date });
            db.Photos.Add(new Photo() { Description = "4", ImagePath = "/images/4.jpg", ThumbPath = "/images/4.jpg", CreatedOn = DateTime.Now.Date });
            db.Photos.Add(new Photo() { Description = "5", ImagePath = "/images/5.jpg", ThumbPath = "/images/5.jpg", CreatedOn = DateTime.Now.Date });
            db.Photos.Add(new Photo() { Description = "6", ImagePath = "/images/6.jpg", ThumbPath = "/images/6.jpg", CreatedOn = DateTime.Now.Date });

            base.Seed(db);
        }
    }
}