using System;
using System.Collections.Generic;
using System.Text;
using CarnetDepenses.Models;

namespace CarnetDepenses.Services;
public interface IDepenseRepository
{
    Task<List<Depense>> ListerAsync();
    Task AjouterAsync( Depense d);
    Task SupprimerAsync( Depense d);

}

internal class IDepenseRepository_cs
{
}
