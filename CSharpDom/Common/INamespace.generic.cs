using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface INamespace<TClass, TDelegate, TEnum, TInterface, TStruct> :
        INamespace,
        IHasName,
        IHasClasses<TClass>,
        IHasDelegates<TDelegate>,
        IHasEnums<TEnum>,
        IHasInterfaces<TInterface>,
        IHasStructs<TStruct>
        where TClass : IClass
        where TDelegate : IDelegate
        where TEnum : IEnum
        where TInterface : IInterface
        where TStruct : IStruct
    {
    }
}
