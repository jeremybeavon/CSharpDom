﻿namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public partial struct PartialStructWithNestedClassWithExplicitInterfaceMethodWith1Attribute
    {
        public class Class : IInterfaceWithMethod
        {
            [Attribute1]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
