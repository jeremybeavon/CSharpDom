using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableNamespace<TUsingDirective, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection> :
        IEditableNamespace,
        IHasEditableName,
        IHasEditableUsingDirectives<TUsingDirective>,
        IHasEditableNamespaces<TNamespace>,
        IHasEditableClassCollection<TClassCollection>,
        IHasEditableDelegates<TDelegate>,
        IHasEditableEnums<TEnum>,
        IHasEditableInterfaces<TInterface>,
        IHasEditableStructCollection<TStructCollection>,
        INamespace<TUsingDirective, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection>
        where TUsingDirective : IEditableUsingDirective
        where TNamespace : IEditableNamespace
        where TClassCollection : IEditableClassCollection
        where TDelegate : IEditableDelegate
        where TEnum : IEditableEnum
        where TInterface : IEditableInterface
        where TStructCollection : IEditableStructCollection
    {
    }
}