using System.Collections.Generic;

namespace TransitiveDependencyResolver.model
{
    public class DependencyTree<T> : IDependencyTree<T>
    {
        private readonly IDictionary<T, IEnumerable<T>> _dictionary;

        public DependencyTree()
        {
            _dictionary = new Dictionary<T, IEnumerable<T>>();
        }

        public void Add(T module, IEnumerable<T> dependencies)
        {
            _dictionary.Add(module, dependencies);
        }

        public IEnumerable<T> Get(T module)
        {
            return _dictionary[module];
        }
    }
}