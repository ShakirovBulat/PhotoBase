using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoBase.DB
{
    public interface ISqlite
    {
        string GetDatabasePath(string filename);
    }
}
