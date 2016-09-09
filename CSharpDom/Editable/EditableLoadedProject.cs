using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable
{
    public abstract class EditableLoadedProject<TSolution, TProject, TNamespace, TClassCollection, TDelegate, TEnum, TInterfaceCollection, TStructCollection> :
        ILoadedProject<TSolution, TProject, TNamespace, TClassCollection, TDelegate, TEnum, TInterfaceCollection, TStructCollection>
        where TSolution : ISolution
        where TProject : IProject
        where TNamespace : INamespace
        where TClassCollection : IClassCollection
        where TDelegate : IDelegate
        where TEnum : IEnum
        where TInterfaceCollection : IInterfaceCollection
        where TStructCollection : IStructCollection
    {
        public abstract TClassCollection Classes { get; set; }

        public abstract ICollection<TDelegate> Delegates { get; set; }

        public abstract ICollection<TEnum> Enums { get; set; }

        public abstract TInterfaceCollection Interfaces { get; set; }

        public abstract ICollection<TNamespace> Namespaces { get; set; }

        public abstract TProject Project { get; set; }

        public abstract TSolution Solution { get; set; }

        public abstract TStructCollection Structs { get; set; }

        IReadOnlyCollection<TDelegate> IHasDelegates<TDelegate>.Delegates
        {
            get { return new ReadOnlyCollectionWrapper<TDelegate>(Delegates); }
        }

        IReadOnlyCollection<TEnum> IHasEnums<TEnum>.Enums
        {
            get { return new ReadOnlyCollectionWrapper<TEnum>(Enums); }
        }

        IReadOnlyCollection<TNamespace> IHasNamespaces<TNamespace>.Namespaces
        {
            get { return new ReadOnlyCollectionWrapper<TNamespace>(Namespaces); }
        }
    }
}
