﻿namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedStaticClasses
{
    public class ClassWithNestedPartialClassWithNestedStaticPartialClassWithGenericParameterStructConstraint
    {
        public partial class Class
        {
            public static class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
