﻿namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.NestedInterfaces
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public abstract partial class Class
        {
            public interface Interface<T>
                where T : class
            {
            }
        }
    }
}
