﻿namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.OperatorOverloads
{
    public partial struct PartialStructWithWithNestedAbstractClassWithAndOperatorOverload
    {
        public abstract class Class
        {
            public static Class operator &(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}