﻿namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.NestedInterfaces
{
    public sealed partial class SealedPartialClassWithNestedStructWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public interface Interface<T>
                where T : class, new()
            {
            }
        }
    }
}
