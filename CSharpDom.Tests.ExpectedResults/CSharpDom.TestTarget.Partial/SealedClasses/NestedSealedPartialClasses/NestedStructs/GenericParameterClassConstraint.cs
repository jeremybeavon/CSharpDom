﻿namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.NestedStructs
{
    public sealed class SealedClassWithNestedSealedPartialClassWithNestedStructWithGenericParameterClassConstraint
    {
        public sealed partial class Class
        {
            public struct NestedStruct<T>
                where T : class
            {
            }
        }
    }
}
