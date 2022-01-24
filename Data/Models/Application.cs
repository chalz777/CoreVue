using System.Collections.Generic;

namespace SSRNMFSSN.Data.Models
{
    public partial class Application
    {
        public Application()
        {
            Viewed = new HashSet<Viewed>();
        }

        public int ApplicationId { get; set; }
        public string Application1 { get; set; }

        public virtual ICollection<Viewed> Viewed { get; set; }
    }
}
