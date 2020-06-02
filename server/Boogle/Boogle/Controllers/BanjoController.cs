using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Boogle.Controllers
{
    [Produces("application/json")]
    public class BanjoController : Controller
    {
        public BanjoController()
        {
        }

        [HttpGet("/banjos")]
        public IEnumerable<Banjo> Get()
        {
            return DataStore.Instance.Data;
        }

// 3. todo
// Diese Methode soll das übergebene Banjo Objekt zu den vorhandenen Daten hinzufügen
// oder, falls der Name schon vorhanden ist das vorhandene Objekt aktualisieren.
        [HttpPut("/banjo")]
        public Banjo Add([FromBody] Banjo banjo)
        {
            return banjo;
        }
    }
}