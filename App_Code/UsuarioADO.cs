using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de UsuarioADO
/// </summary>
public class UsuarioADO
{
    private DB_PAAC3GN3ANDAURGOTSCHLICHVALENZUELAEntities context = new DB_PAAC3GN3ANDAURGOTSCHLICHVALENZUELAEntities();
    private String mensaje;


    public UsuarioADO()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public string Mensaje
    {
        get
        {
            return mensaje;
        }

        set
        {
            mensaje = value;
        }
    }

    // Metodo para agregar usuarios
    public Usuario agregar(Usuario objUsuario)
    {
        try
        {
            context.Usuario.add(objUsuario); // se agrega el usuario
            context.SaveChanges(); // se guardan los cambios
        }
        catch (Exception ex)
        {
            mensaje = "Error al agregar Usuario " + ex;
        }

        return objUsuario;
    }


    // Metodo para buscar usuarios en la base de datos
    public Usuario buscar(int id)
    {
        return context.Usuario.Find(id);
    }

    // Metodo para obtener los usuarios
    public List<Usuario> getUsuarios()
    {
        mensaje = "";
        return context.Usuario.ToList(); // almacenar los datos en una lista
    }
    
    // Metodo para eliminar un usuario
    public int eliminar(int id)
    {
        try
        {
            Usuario usuario = context.Usuario.Find(id); // se busca al usuario con el id pasado como parametro
            context.Usuario.Remove(usuario); // se elimina el usuario encontrado
            mensaje = "Usuario eliminado"; // se setea el mensaje
        }
        catch (Exception ex)
        {

            mensaje = "Error al eliminar el usuario" + ex;
        }

        return context.SaveChanges();
    }

    // Metodo para modificar usuario
    public int modificarUsuario(Usuario nuevo)
    {
        Usuario usuario = context.Usuario.Find(nuevo.idUsuario);
        usuario = nuevo;
        mensaje = "Usuario modificado";
        return context.SaveChanges();
    }




} // fin class