﻿namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint
    {
        public static class Class
        {
            public abstract class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
