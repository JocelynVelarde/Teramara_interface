using System.ComponentModel.DataAnnotations;

namespace LogIn
{
    public class User
    {
        public String Usuario { get; set; }
        public String Contraseña { get; set; }

        //ESTA LLAVE LE PROPORCIONA UNA KEY UNICA A CADA USUARIO POR SI HAY PROPIEDADES REPETIDAS
        [Key]
        public String Id { get; set; }
    }
}