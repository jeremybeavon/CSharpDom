﻿namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedAbstractClassWithNestedSealedClassWithGenericParameterStructConstraint
    {
        public abstract class Class
        {
            public sealed class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
