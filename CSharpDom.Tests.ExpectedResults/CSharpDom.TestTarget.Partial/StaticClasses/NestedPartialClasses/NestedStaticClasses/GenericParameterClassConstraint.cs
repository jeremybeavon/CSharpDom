﻿namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedPartialClassWithNestedStaticPartialClassWithGenericParameterClassConstraint
    {
        public partial class Class
        {
            public static class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
