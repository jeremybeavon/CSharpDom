namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.OperatorOverloads
{
    public sealed class SealedClassWithNestedSealedClassWithIncrementOperatorOverload
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
