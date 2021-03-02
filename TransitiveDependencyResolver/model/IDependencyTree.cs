using System.Collections.Generic;

namespace TransitiveDependencyResolver.model
{
    public interface IDependencyTree<T>
    {
        void Add(T module, IEnumerable<T> dependencies);

        IEnumerable<T> GetDependenciesOf(T module);

        IEnumerable<T> GetAllModules();
    }
}