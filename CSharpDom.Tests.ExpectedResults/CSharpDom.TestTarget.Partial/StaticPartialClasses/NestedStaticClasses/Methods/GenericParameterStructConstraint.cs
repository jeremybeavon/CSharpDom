﻿namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses.Methods
{
    public static partial class StaticPartialClassWithNestedStaticClassWithMethodWithGenericParameterStructConstraint
    {
        public static class Class
        {
            public static T Method<T>()
                where T : struct
            {
                return default(T);
            }
        }
    }
}
