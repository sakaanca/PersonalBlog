using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Shared.Entities.Abstract
{
    public abstract class EntityBase
    {
        public virtual int Id { get; set; }
        public virtual DateTime CreatedTime { get; set; } = DateTime.Now;//Oluşturulduğu zamanı alır.
        public virtual DateTime ModifiedTime { get; set; }=DateTime.Now;
        public virtual bool IsActive { get; set; }= false;//İlk oluşturulduğu zaman aktif değildir. bu yüzden false
        public virtual bool IsDelete { get; set; }=false;// İlk  oluşturulduğunda silinmemiştir sonradan silinir.
        public virtual string CreatedByName { get; set; } = "Admin";// İlk oluşturma admin tarafından gerçekleştirilir.

        public virtual string ModifiedByName { get; set; } = "Admin"; // Düzenleyende ilk başta admin olabilir.

    }
    //Abstrac sınıflar sınıf hiyerarşisinde genellikle base class tanımlamak için kullanılır  ve soyutlama yeteneği kullanılır .Genellikle kalıtım yapılırken kullanılır . New ile nesneleri oluşturulamaz. Çoklu kalıtımı desteklemez.
    // virtual olması sanal olduğunu gösterir.
}
