﻿namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.OperatorOverloads
{
    public partial class PartialClassWithNestedSealedClassWithPlusOperatorOverload
    {
        public sealed class Class
        {
            public static Class operator +(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}
