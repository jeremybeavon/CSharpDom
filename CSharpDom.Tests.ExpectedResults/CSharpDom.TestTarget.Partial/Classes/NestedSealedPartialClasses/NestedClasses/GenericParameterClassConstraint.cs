﻿namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.NestedClasses
{
    public class ClassWithNestedSealedPartialClassWithNestedPartialClassWithGenericParameterClassConstraint
    {
        public sealed partial class Class
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
