﻿namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedInterfaces
{
    public class ClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public interface Interface<T>
                where T : class, new()
            {
            }
        }
    }
}
