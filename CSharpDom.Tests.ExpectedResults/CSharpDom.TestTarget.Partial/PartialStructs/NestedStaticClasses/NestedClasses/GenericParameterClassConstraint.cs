﻿namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.NestedClasses
{
    public partial struct PartialStructWithWithNestedStaticClassWithNestedClassWithGenericParameterClassConstraint
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
