﻿namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.NestedInterfaces
{
    public abstract partial class AbstractPartialClassWithNestedStructWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public interface Interface<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
