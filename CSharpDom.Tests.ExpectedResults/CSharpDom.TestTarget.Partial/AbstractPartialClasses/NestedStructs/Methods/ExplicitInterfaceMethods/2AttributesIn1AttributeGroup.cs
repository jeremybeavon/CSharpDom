﻿namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Methods.ExplicitInterfaceMethods
{
    public abstract partial class AbstractPartialClassWithNestedStructWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup
    {
        public struct Struct : IInterfaceWithMethod
        {
            [Attribute1, Attribute2]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
