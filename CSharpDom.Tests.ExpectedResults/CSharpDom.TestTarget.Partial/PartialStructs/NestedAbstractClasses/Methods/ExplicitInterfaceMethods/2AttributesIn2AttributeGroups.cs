﻿namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Methods.ExplicitInterfaceMethods
{
    public partial struct PartialStructWithWithNestedAbstractClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups
    {
        public abstract class Class : IInterfaceWithMethod
        {
            [Attribute1]
            [Attribute2]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
