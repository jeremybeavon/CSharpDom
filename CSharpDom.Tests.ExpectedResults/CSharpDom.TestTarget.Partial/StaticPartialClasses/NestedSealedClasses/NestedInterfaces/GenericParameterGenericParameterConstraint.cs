﻿namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.NestedInterfaces
{
    public static partial class StaticPartialClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
    {
        public sealed class Class
        {
            public interface Interface<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
