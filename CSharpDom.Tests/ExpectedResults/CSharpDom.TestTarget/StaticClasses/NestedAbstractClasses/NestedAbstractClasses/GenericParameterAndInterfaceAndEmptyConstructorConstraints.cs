﻿namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public abstract class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
