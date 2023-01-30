using System.Data.SqlTypes;

namespace FullStackAPI.models
{
    public class empleado
    {
        public int id { get; set; }
        public string apellido { get; set; }
        public string name { get; set; }
        public long tel { get; set; }
        public string correo { get; set; }
        public string photo { get; set; }
        public string fecha { get; set; }
    }
}
