﻿namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedInterfaces
{
    public class ClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public sealed class Class
        {
            public interface Interface<T>
                where T : class
            {
            }
        }
    }
}
