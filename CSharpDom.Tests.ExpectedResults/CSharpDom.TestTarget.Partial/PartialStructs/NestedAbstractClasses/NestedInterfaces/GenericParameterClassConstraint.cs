﻿namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.NestedInterfaces
{
    public partial struct PartialStructWithNestedAbstractClassWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public abstract class Class
        {
            public interface Interface<T>
                where T : class
            {
            }
        }
    }
}
