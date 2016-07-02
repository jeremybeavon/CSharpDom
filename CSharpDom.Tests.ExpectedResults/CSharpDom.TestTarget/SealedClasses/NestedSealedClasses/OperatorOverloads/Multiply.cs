namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.OperatorOverloads
{
    public sealed class SealedClassWithNestedSealedClassWithMultiplyOperatorOverload
    {
        public sealed class Class
        {
            public static Class operator *(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}
