﻿namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedPartialClassWithNestedStructWithGenericParameterStructConstraint
    {
        public partial class Class
        {
            public struct NestedStruct<T>
                where T : struct
            {
            }
        }
    }
}
