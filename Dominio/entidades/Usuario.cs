using System;

namespace Dominio.entidades
{
    public class Usuario
    {
        public int IdUsuario { get; private set; }
        public string Nombre { get; private set; }
        public Rol Rol { get; private set; }
        public bool Activo { get; private set; }

        public Usuario(int idUsuario, string nombre, Rol rol)
        {
            if (idUsuario <= 0)
                throw new ArgumentException("El ID debe ser mayor a 0.");
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre no puede estar vacío.");

            IdUsuario = idUsuario;
            Nombre = nombre;
            Rol = rol;
            Activo = true;
        }

        public void Desactivar() => Activo = false;
        public void Activar() => Activo = true;
    }

    public enum Rol
    {
        Mesero = 1,
        Cajero = 2,
        Administrador = 3
    }
}