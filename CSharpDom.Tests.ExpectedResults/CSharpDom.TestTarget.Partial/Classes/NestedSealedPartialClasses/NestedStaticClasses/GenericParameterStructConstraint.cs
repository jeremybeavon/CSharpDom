﻿namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.NestedStaticClasses
{
    public class ClassWithNestedSealedPartialClassWithNestedStaticPartialClassWithGenericParameterStructConstraint
    {
        public sealed partial class Class
        {
            public static class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
