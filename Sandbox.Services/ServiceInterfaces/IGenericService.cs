using System;
using System.Collections.Generic;
using System.Text;

namespace Sandbox.Services.ServiceInterfaces
{
    public interface IGenericService<TEntity, in TKey> where TEntity : class
    {
        TEntity Get(TKey id);

        IEnumerable<TEntity> GetAll();
    }
}
