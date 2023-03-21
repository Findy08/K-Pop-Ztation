using KpopZtation_GroupB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation_GroupB.Repository
{
    
    public class DatabaseSingleton
    {
        private static KpopZtationDatabaseEntities db = null;
        private DatabaseSingleton()
        {

        }

        public static KpopZtationDatabaseEntities GetInstance()
        {
            if(db == null)
            {
                db = new KpopZtationDatabaseEntities();
            }
            return db;
        }
    }
}