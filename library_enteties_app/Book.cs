//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace library_enteties_app
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int IdAuthor { get; set; }
        public Nullable<int> Pages { get; set; }
        public Nullable<int> Price { get; set; }
        public int IdPublisher { get; set; }

        [NotMapped]
        public virtual Author Author { get; set; }

        [NotMapped]
        public virtual Publisher Publisher { get; set; }
    }
}
