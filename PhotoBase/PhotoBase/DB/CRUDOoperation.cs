using SQLite;
using System;
using System.Collections.Generic;
using PhotoBase.Models;
using System.Text;

namespace PhotoBase.DB
{
    public class CRUDOperation
    {
        SQLiteConnection db;
        public CRUDOperation(string databasePath)
        {
            db = new SQLiteConnection(databasePath);
            db.CreateTable<ProjectPhoto>();
        }
        public IEnumerable<ProjectPhoto> GetProjects()
        {
            return db.Table<ProjectPhoto>();
        }
        public int DeleteItem(int id)
        {
            return db.Delete<ProjectPhoto>(id);
        }
        public int SaveItem(ProjectPhoto projectphoto)
        {
            if (projectphoto.Id != 0)
            {
                db.Update(projectphoto);
                return projectphoto.Id;
            }
            else
            {
                return db.Insert(projectphoto);
            }
        }

    }
}
