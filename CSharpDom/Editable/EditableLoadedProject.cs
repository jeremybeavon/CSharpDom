using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableLoadedProject<TSolution, TProject, TNamespace, TClassCollection, TDelegate, TEnum, TInterfaceCollection, TStructCollection> :
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
        public virtual TClassCollection Classes { get; set; }

        public virtual IReadOnlyCollection<TDelegate> Delegates { get; set; }

        public virtual IReadOnlyCollection<TEnum> Enums { get; set; }

        public virtual TInterfaceCollection Interfaces { get; set; }

        public virtual IReadOnlyCollection<TNamespace> Namespaces { get; set; }

        public virtual TProject Project { get; set; }

        public virtual TSolution Solution { get; set; }

        public virtual TStructCollection Structs { get; set; }
    }
}
