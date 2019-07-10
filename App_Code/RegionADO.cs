using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de RegionADO
/// </summary>
public class RegionADO
{

    private DB_PAAC3GN3ANDAURGOTSCHLICHVALENZUELAEntities context = new DB_PAAC3GN3ANDAURGOTSCHLICHVALENZUELAEntities();
    private String mensaje;

    public RegionADO()
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


    // Metodo para buscar region segun el id como parametro
    public Region buscarRegiones(int id)
    {
        return context.Region.Find(id);
    }

    // Metodo para obtener los bancos
    public List<Region> getRegiones()
    {

        Mensaje = "";
        return context.Region.ToList();
    }



} // fin class region