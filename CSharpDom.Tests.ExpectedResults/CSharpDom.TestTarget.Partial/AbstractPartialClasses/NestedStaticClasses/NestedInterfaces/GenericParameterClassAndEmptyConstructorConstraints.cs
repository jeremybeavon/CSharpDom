﻿namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStaticClasses.NestedInterfaces
{
    public abstract partial class AbstractPartialClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public interface Interface<T>
                where T : class, new()
            {
            }
        }
    }
}
