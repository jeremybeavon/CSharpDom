﻿namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.NestedDelegates
{
    public partial struct PartialStructWithWithNestedStaticClassWithNestedDelegateWithGenericParameterClassConstraint
    {
        public static class Class
        {
            public delegate void DelegateWithGenericParameterClassConstraint<T>()
                where T : class;
        }
    }
}
