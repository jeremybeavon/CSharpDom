﻿namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.NestedAbstractClasses
{
    public struct StructWithNestedAbstractPartialClassWithNestedAbstractPartialClassWithGenericParameterStructConstraint
    {
        public abstract partial class Class
        {
            public abstract class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
