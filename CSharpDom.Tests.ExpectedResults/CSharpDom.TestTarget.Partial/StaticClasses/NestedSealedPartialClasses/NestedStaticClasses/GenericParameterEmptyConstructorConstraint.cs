﻿namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedSealedPartialClassWithNestedStaticPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public sealed partial class Class
        {
            public static class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
