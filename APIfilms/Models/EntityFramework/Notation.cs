using System.ComponentModel.DataAnnotations.Schema;

namespace APIfilms.Models.EntityFramework
{

    public class Notation
    {
        public Notation()
        {
            
        }
        [Column("utl_id")]
        public int Utl_id { get; set; }

        [Column("flm_id")]
        public string Flm_id { get; set; }

        [Column("not_note")]
        public string Not_note { get; set; }

    }
}
