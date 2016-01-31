using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface INamespace<TUsingDirective, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct> :
        INamespace,
        IHasName,
        IHasUsingDirectives<TUsingDirective>,
        IHasNamespaces<TNamespace>,
        IHasClasses<TClass>,
        IHasDelegates<TDelegate>,
        IHasEnums<TEnum>,
        IHasInterfaces<TInterface>,
        IHasStructs<TStruct>
        where TUsingDirective : IUsingDirective
        where TNamespace : INamespace
        where TClass : IClass
        where TDelegate : IDelegate
        where TEnum : IEnum
        where TInterface : IInterface
        where TStruct : IStruct
    {
    }
}
