﻿namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.NestedClasses
{
    public partial struct PartialStructWithWithNestedSealedClassWithNestedClassWithGenericParameterClassConstraint
    {
        public sealed class Class
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
