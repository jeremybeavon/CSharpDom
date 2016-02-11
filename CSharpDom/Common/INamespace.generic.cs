using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface INamespace<
        TUsingDirective,
        TNamespace,
        TClassCollection,
        TDelegate,
        TEnum,
        TInterfaceCollection,
        TStructCollection> :
        INamespace,
        IHasName,
        IHasUsingDirectives<TUsingDirective>,
        IHasNamespaces<TNamespace>,
        IHasClassCollection<TClassCollection>,
        IHasDelegates<TDelegate>,
        IHasEnums<TEnum>,
        IHasInterfaceCollection<TInterfaceCollection>,
        IHasStructCollection<TStructCollection>
        where TUsingDirective : IUsingDirective
        where TNamespace : INamespace
        where TClassCollection : IClassCollection
        where TDelegate : IDelegate
        where TEnum : IEnum
        where TInterfaceCollection : IInterfaceCollection
        where TStructCollection : IStructCollection
    {
    }
}
