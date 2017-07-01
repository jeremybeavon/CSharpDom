using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractLoadedProject<TSolution, TProject, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection> :
        ILoadedProject<TSolution, TProject, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection>
        where TSolution : ISolution
        where TProject : IProject
        where TNamespace : INamespace
        where TClassCollection : IClassCollection
        where TDelegate : IDelegate
        where TEnum : IEnum
        where TInterface : IInterface
        where TStructCollection : IStructCollection
    {
        public abstract TClassCollection Classes { get; }

        public abstract IReadOnlyCollection<TDelegate> Delegates { get; }

        public abstract IReadOnlyCollection<TEnum> Enums { get; }

        public abstract IReadOnlyCollection<TInterface> Interfaces { get; }

        public abstract IReadOnlyCollection<TNamespace> Namespaces { get; }

        public abstract TProject Project { get; }

        public abstract TSolution Solution { get; }

        public abstract TStructCollection Structs { get; }
    }
}
