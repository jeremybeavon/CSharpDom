﻿namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.NestedInterfaces
{
    public partial struct PartialStructWithNestedSealedClassWithNestedInterfaceWith2ImplementedInterfaces
    {
        public sealed class Class
        {
            public interface Interface : IInterface1, IInterface2
            {
            }
        }
    }
}
