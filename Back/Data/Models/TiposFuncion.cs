﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Back.Data.Models;

public partial class TiposFuncion
{
    public int IdTipoFuncion { get; set; }

    public string Tipo { get; set; }

    public virtual ICollection<Funcione> Funciones { get; set; } = new List<Funcione>();
}