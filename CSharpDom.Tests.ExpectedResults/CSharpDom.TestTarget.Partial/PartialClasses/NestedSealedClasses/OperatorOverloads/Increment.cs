﻿namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.OperatorOverloads
{
    public partial class PartialClassWithNestedSealedClassWithIncrementOperatorOverload
    {
        public sealed class Class
        {
            public static Class operator ++(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
