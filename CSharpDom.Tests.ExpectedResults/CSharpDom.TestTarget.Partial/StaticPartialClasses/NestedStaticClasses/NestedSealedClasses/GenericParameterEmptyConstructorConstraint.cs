﻿namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses.NestedSealedClasses
{
    public static partial class StaticPartialClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class
        {
            public sealed class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
