using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ComunaADO
/// </summary>
public class ComunaADO
{
    private DB_PAAC3GN3ANDAURGOTSCHLICHVALENZUELAEntities context = new DB_PAAC3GN3ANDAURGOTSCHLICHVALENZUELAEntities();
    private String mensaje;
    public ComunaADO()
    {
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
    public Comuna agregarComuna(Comuna objComuna)
    {
        try
        {
            //Se añade una comuna
            context.Comuna.Add(objComuna);
            //Se guardan los cambios
            context.SaveChanges();
            mensaje = "Comuna agregada correctamente."; 
        }
        catch (Exception e)
        {
            mensaje = "Error al agregar comuna " + e;
        }
        return objComuna;
    }
    public Comuna buscarComunas(int id)
    {
        return context.Comuna.Find(id);
    }
    public List<Comuna> getComunas()
    {
        //muestra todos los datos en una lista
        mensaje = "";
        return context.Comuna.ToList();
    }
    public int eliminarComuna(int idComuna)
    {
        try
        {
            Comuna c = context.Comuna.Find(idComuna);
            context.Comuna.Remove(c);
            mensaje = "Comuna eliminada correctamente";
        }
        catch (Exception e)
        {
            mensaje = "Error al eliminar comuna "+e;
        }
        return context.SaveChanges();
    }
    public int modificarComuna(Comuna nueva)
    {
        //Se busca una persona y se cambia por otra
        Comuna c = context.Comuna.Find(nueva.idComuna);
        c = nueva;
        mensaje = "Comuna modificada correctamente";
        return context.SaveChanges();
    }
}