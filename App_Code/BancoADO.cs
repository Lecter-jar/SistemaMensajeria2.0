using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de BancoADO
/// </summary>
public class BancoADO
{

    private DB_PAAC3GN3ANDAURGOTSCHLICHVALENZUELAEntities context = new DB_PAAC3GN3ANDAURGOTSCHLICHVALENZUELAEntities();
    private String mensaje;

    public BancoADO()
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

    // Metodo para buscar bancos segun el id como parametro
    public Banco buscarBancos(int id)
    {
        return context.Banco.Find(id);
    }

    // Metodo para obtener los bancos
    public List<Banco> getBancos()
    {
        
        Mensaje = "";
        return context.Banco.ToList();
    }


} // fin class banco