﻿namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedClassWithNestedStaticClassWithGenericParameterClassConstraint
    {
        public class Class
        {
            public static class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
