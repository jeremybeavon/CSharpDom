﻿namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.NestedClasses
{
    public sealed class SealedClassWithNestedStaticPartialClassWithNestedPartialClassWithGenericParameterStructConstraint
    {
        public static partial class Class
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
