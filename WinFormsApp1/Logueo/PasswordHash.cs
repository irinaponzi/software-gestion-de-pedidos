using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace pedidos.Logueo
{
    internal class PasswordHash
    {
        public PasswordHash() { }

        // Pasa un string a un array de bytes, se genera el hash y luego el hash
        // se convierte en un string que muestra la representación hexadecimal del hash 
        public static string obtenerHashPassword(string passEntrada)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(passEntrada);
            byte[] passHash = SHA256.HashData(bytes);

            var passSalida = Convert.ToHexString(passHash);
            return passSalida;
        }

        // Pasa el string ingresado en el log in a un array de bytes y se genera el hash 
        // El password del usuario en la "BD" que está en su representación hexadecimal se
        // convierte a un array de bytes. Con estos valores se realiza su comparación
        public static bool compararHash(string passEntrada, string passSalidaUsuario)
        {
            byte[] bytesEntrada = Encoding.UTF8.GetBytes(passEntrada);
            byte[] passHashEntrada = SHA256.HashData(bytesEntrada);

            Console.WriteLine("Contraseña ingresada: " + Convert.ToHexString(passHashEntrada)); // Esto se saca
            Console.WriteLine("Contraseña usuario: " + passSalidaUsuario); // Esto se saca

            byte[] passHashUsuario = Convert.FromHexString(passSalidaUsuario);
            return passHashUsuario.SequenceEqual(passHashEntrada);
        }
    }
}
