﻿namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.NestedClasses
{
    public static class StaticClassWithNestedPartialClassWithNestedPartialClassWithGenericParameterInterfaceConstraint
    {
        public partial class Class
        {
            public class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
