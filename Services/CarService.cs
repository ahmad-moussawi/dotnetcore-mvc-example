using SqlKata;
using SqlKata.Execution;

namespace MvcExample.Services
{
    public class CarService
    {
        private readonly QueryFactory db;

        public CarService(QueryFactory db)
        {
            this.db = db;
        }

        public Query AllCars()
        {
            return db.Query("cars");
        }

        public Query ActiveCars()
        {
            return AllCars().WhereTrue("is_active");
        }

    }
}