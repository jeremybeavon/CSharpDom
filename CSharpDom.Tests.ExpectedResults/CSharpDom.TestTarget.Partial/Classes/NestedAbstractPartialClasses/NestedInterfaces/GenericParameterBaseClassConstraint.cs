﻿namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.NestedInterfaces
{
    public class ClassWithNestedAbstractPartialClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public abstract partial class Class
        {
            public interface Interface<T>
                where T : BaseClass
            {
            }
        }
    }
}
