﻿namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedSealedClasses
{
    public class ClassWithNestedPartialClassWithNestedSealedPartialClassWithGenericParameterClassConstraint
    {
        public partial class Class
        {
            public sealed class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
