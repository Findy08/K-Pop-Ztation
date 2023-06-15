using KpopZtation_GroupB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation_GroupB.Repository
{
    
    public class DatabaseSingleton
    {
        private static KpopDatabaseEntities db = null;
        private DatabaseSingleton()
        {

        }

        public static KpopDatabaseEntities GetInstance()
        {
            if(db == null)
            {
                db = new KpopDatabaseEntities();
            }
            return db;
        }
    }
}