﻿namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.OperatorOverloads
{
    public partial struct PartialStructWithWithNestedAbstractClassWithUnaryMinusOperatorOverload
    {
        public abstract class Class
        {
            public static Class operator -(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}