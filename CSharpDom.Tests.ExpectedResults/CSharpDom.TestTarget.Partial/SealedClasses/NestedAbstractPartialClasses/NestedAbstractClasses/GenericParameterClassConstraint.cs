﻿namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithNestedAbstractPartialClassWithGenericParameterClassConstraint
    {
        public abstract partial class Class
        {
            public abstract class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
