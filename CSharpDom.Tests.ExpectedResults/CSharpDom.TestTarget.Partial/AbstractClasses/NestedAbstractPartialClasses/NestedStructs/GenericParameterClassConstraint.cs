﻿namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithNestedStructWithGenericParameterClassConstraint
    {
        public abstract partial class Class
        {
            public struct NestedStruct<T>
                where T : class
            {
            }
        }
    }
}
