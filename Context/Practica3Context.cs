using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Practica3.Models;

namespace Practica3.Context;

    public partial class Practica3Context : DbContext
{

    public Practica3Context() { }

    public Practica3Context(DbContextOptions<Practica3Context> options) : base(options)
    { }
    public DbSet<Editorial> tEditorial { get; set; }
    public DbSet<Inventario> tInventario { get; set; }
    public DbSet<Libro> tLibro { get; set; }
    public DbSet<Sucursal> tSucursal { get; set; }


} 
