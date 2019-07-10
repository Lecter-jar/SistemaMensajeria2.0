﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Linq;

public partial class DB_PAAC3GN3ANDAURGOTSCHLICHVALENZUELAEntities : DbContext
{
    public DB_PAAC3GN3ANDAURGOTSCHLICHVALENZUELAEntities()
        : base("name=DB_PAAC3GN3ANDAURGOTSCHLICHVALENZUELAEntities")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public virtual DbSet<Administrador> Administrador { get; set; }
    public virtual DbSet<Banco> Banco { get; set; }
    public virtual DbSet<Comuna> Comuna { get; set; }
    public virtual DbSet<Desvio> Desvio { get; set; }
    public virtual DbSet<Historial> Historial { get; set; }
    public virtual DbSet<Mensaje> Mensaje { get; set; }
    public virtual DbSet<Recarga> Recarga { get; set; }
    public virtual DbSet<Region> Region { get; set; }
    public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    public virtual DbSet<Tarifa> Tarifa { get; set; }
    public virtual DbSet<Telefono> Telefono { get; set; }
    public virtual DbSet<Transbank> Transbank { get; set; }
    public virtual DbSet<Usuario> Usuario { get; set; }

    public virtual int pa_eliminarComuna(Nullable<int> idComuna)
    {
        var idComunaParameter = idComuna.HasValue ?
            new ObjectParameter("idComuna", idComuna) :
            new ObjectParameter("idComuna", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_eliminarComuna", idComunaParameter);
    }

    public virtual int pa_ingresarComuna(string nombre)
    {
        var nombreParameter = nombre != null ?
            new ObjectParameter("Nombre", nombre) :
            new ObjectParameter("Nombre", typeof(string));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_ingresarComuna", nombreParameter);
    }

    public virtual ObjectResult<pa_listarComunas_Result> pa_listarComunas(string nombre)
    {
        var nombreParameter = nombre != null ?
            new ObjectParameter("Nombre", nombre) :
            new ObjectParameter("Nombre", typeof(string));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pa_listarComunas_Result>("pa_listarComunas", nombreParameter);
    }

    public virtual int pa_listarRecargas(Nullable<System.DateTime> fecha, Nullable<int> monto, Nullable<int> idUsuario, Nullable<int> idTelefono)
    {
        var fechaParameter = fecha.HasValue ?
            new ObjectParameter("Fecha", fecha) :
            new ObjectParameter("Fecha", typeof(System.DateTime));

        var montoParameter = monto.HasValue ?
            new ObjectParameter("Monto", monto) :
            new ObjectParameter("Monto", typeof(int));

        var idUsuarioParameter = idUsuario.HasValue ?
            new ObjectParameter("idUsuario", idUsuario) :
            new ObjectParameter("idUsuario", typeof(int));

        var idTelefonoParameter = idTelefono.HasValue ?
            new ObjectParameter("idTelefono", idTelefono) :
            new ObjectParameter("idTelefono", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_listarRecargas", fechaParameter, montoParameter, idUsuarioParameter, idTelefonoParameter);
    }

    public virtual int pa_modificarComuna(Nullable<int> idComuna, string nombre)
    {
        var idComunaParameter = idComuna.HasValue ?
            new ObjectParameter("idComuna", idComuna) :
            new ObjectParameter("idComuna", typeof(int));

        var nombreParameter = nombre != null ?
            new ObjectParameter("Nombre", nombre) :
            new ObjectParameter("Nombre", typeof(string));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_modificarComuna", idComunaParameter, nombreParameter);
    }

    public virtual int pa_realizarRecarga(Nullable<System.DateTime> fecha, Nullable<int> monto, string numero)
    {
        var fechaParameter = fecha.HasValue ?
            new ObjectParameter("Fecha", fecha) :
            new ObjectParameter("Fecha", typeof(System.DateTime));

        var montoParameter = monto.HasValue ?
            new ObjectParameter("Monto", monto) :
            new ObjectParameter("Monto", typeof(int));

        var numeroParameter = numero != null ?
            new ObjectParameter("Numero", numero) :
            new ObjectParameter("Numero", typeof(string));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_realizarRecarga", fechaParameter, montoParameter, numeroParameter);
    }

    public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
    {
        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));

        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));

        var versionParameter = version.HasValue ?
            new ObjectParameter("version", version) :
            new ObjectParameter("version", typeof(int));

        var definitionParameter = definition != null ?
            new ObjectParameter("definition", definition) :
            new ObjectParameter("definition", typeof(byte[]));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
    }

    public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
    {
        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));

        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));

        var versionParameter = version.HasValue ?
            new ObjectParameter("version", version) :
            new ObjectParameter("version", typeof(int));

        var definitionParameter = definition != null ?
            new ObjectParameter("definition", definition) :
            new ObjectParameter("definition", typeof(byte[]));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
    }

    public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
    {
        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));

        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
    }

    public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
    {
        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));

        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
    }

    public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
    {
        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));

        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
    }

    public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
    {
        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));

        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));

        var new_diagramnameParameter = new_diagramname != null ?
            new ObjectParameter("new_diagramname", new_diagramname) :
            new ObjectParameter("new_diagramname", typeof(string));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
    }

    public virtual int sp_upgraddiagrams()
    {
        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
    }
}