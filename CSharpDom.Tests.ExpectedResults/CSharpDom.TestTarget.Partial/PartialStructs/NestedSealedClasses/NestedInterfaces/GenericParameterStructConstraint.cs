﻿namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.NestedInterfaces
{
    public partial struct PartialStructWithNestedSealedClassWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public sealed class Class
        {
            public interface Interface<T>
                where T : struct
            {
            }
        }
    }
}
