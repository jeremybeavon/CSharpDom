﻿namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedClasses
{
    public struct StructWithNestedPartialClassWithNestedPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public partial class Class
        {
            public class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
