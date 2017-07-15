namespace prueba33.repositories
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Data;
    using prueba33.Models;
    using repositories;

    public class GrupoRepository :GenericRepositoryAsync<Empresarios20,gesGrupo>,IGrupoRepository,IDisposable
        {
        public virtual void Dispose()
        {
            base.Dispose(true);
        }
    }
    
}