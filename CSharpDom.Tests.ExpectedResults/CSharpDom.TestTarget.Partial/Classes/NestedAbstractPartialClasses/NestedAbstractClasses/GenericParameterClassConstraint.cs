﻿namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.NestedAbstractClasses
{
    public class ClassWithNestedAbstractPartialClassWithNestedAbstractPartialClassWithGenericParameterClassConstraint
    {
        public abstract partial class Class
        {
            public abstract class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
