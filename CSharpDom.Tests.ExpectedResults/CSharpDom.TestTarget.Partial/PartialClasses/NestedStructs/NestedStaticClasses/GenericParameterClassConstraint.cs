﻿namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.NestedStaticClasses
{
    public partial class PartialClassWithNestedStructWithNestedStaticClassWithGenericParameterClassConstraint
    {
        public struct Struct
        {
            public static class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
