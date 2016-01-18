using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface INamespace<TClass, TDelegate, TEnum, TInterface, TStruct> :
        IHasName,
        IHasClasses<TClass>,
        IHasDelegates<TDelegate>,
        IHasEnums<TEnum>,
        IHasInterfaces<TInterface>,
        IHasStructs<TStruct>
    {
    }
}
