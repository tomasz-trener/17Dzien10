using P03AplikacjaZawodnicy.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace P03AplikacjaZawodnicy.Repositories
{
    public class TrenerzyRepository
    {
        public Trener PodajTrenera(int id)
        {
            ModelBazyDataContext db = new ModelBazyDataContext();
            var trenerDb= db.TrenerDB.FirstOrDefault(x => x.id_trenera == id);

            return new Trener()
            {
                Imie = trenerDb.imie_t,
                Nazwisko = trenerDb.nazwisko_t
            };
        }
    }
}