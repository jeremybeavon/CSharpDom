﻿namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.NestedClasses
{
    public partial struct PartialStructWithWithNestedAbstractClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
