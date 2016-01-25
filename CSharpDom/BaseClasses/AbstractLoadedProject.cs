using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractLoadedProject<TSolution, TProject, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct> :
        ILoadedProject<TSolution, TProject, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct>
        where TSolution : ISolution
        where TProject : IProject
        where TNamespace : INamespace
        where TClass : IClass
        where TDelegate : IDelegate
        where TEnum : IEnum
        where TInterface : IInterface
        where TStruct : IStruct
    {
        public abstract IReadOnlyCollection<TClass> Classes { get; }

        public abstract IReadOnlyCollection<TDelegate> Delegates { get; }

        public abstract IReadOnlyCollection<TEnum> Enums { get; }

        public abstract IReadOnlyCollection<TInterface> Interfaces { get; }

        public abstract IReadOnlyCollection<TNamespace> Namespaces { get; }

        public abstract TProject Project { get; }

        public abstract TSolution Solution { get; }

        public abstract IReadOnlyCollection<TStruct> Structs { get; }
    }
}
