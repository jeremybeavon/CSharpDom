﻿namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedAbstractClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
