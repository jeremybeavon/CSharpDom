﻿namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNestedStructWithGenericParameterClassConstraint
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
