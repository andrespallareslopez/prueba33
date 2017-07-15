namespace prueba33.repositories
{
    using System;
    using System.Collections.Generic;
    using prueba33.Models;
    using repositories;
 
    
        public interface IGrupoRepository  : IGenericRepository<gesGrupo>,IDisposable
        {
               
        }
    
}