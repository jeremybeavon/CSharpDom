﻿namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.NestedInterfaces
{
    public struct StructWithNestedAbstractPartialClassWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public abstract partial class Class
        {
            public interface Interface<T>
                where T : struct
            {
            }
        }
    }
}
