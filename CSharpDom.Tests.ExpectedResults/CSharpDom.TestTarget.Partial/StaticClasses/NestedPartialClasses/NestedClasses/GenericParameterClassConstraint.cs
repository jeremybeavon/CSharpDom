﻿namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.NestedClasses
{
    public static class StaticClassWithNestedPartialClassWithNestedPartialClassWithGenericParameterClassConstraint
    {
        public partial class Class
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
