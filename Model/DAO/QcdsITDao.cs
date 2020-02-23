using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.DAO
{
    public class QcdsITDao
    {
        QcdsDbContext db = null;
        public QcdsITDao()
        {
            db = new QcdsDbContext();
        }
        public long Insert( QcdsIT entity)
        {
            db.QcdsITs.Add(entity);
            db.SaveChanges();

            return entity.ID;
        }
    }
}
