using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using solid_spork;
using solid_spork.Models;
namespace solid_spork.DL
{
    public class QueryDl
    {
        private Entities db = new Entities();

        internal bool CreateNewQuery(Query Obj)
        {
            bool flag = false;

            try
            {
                db.Queries.Add(Obj);
                db.SaveChanges();
                flag = true;
            }
            catch
            {

            }
            return flag;
        }
    }
}