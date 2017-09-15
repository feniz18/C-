using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model.dao
{
    interface Obligatorio<cualquierClase>
    {
        void create(cualquierClase obj);

        void update(cualquierClase obj);

        void delete(cualquierClase obj);

        bool find(cualquierClase obj);

        List<cualquierClase> findAll();
    }
}