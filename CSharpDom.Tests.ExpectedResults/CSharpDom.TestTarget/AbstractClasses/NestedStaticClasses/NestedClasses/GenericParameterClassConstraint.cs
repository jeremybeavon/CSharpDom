﻿namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedStaticClassWithNestedClassWithGenericParameterClassConstraint
    {
        public static class Class
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
