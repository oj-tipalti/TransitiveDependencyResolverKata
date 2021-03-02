﻿using System.Collections.Generic;

namespace TransitiveDependencyResolver.model
{
    public interface IDependencyTree<T>
    {
        void Add(T module, IList<T> dependencies);

        IList<T> GetDependenciesOf(T module);

        IList<T> GetAllModules();
    }
}