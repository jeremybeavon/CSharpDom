﻿namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses.NestedStaticClasses
{
    public static partial class StaticPartialClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterBaseClassConstraint
    {
        public static class Class
        {
            public static class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
