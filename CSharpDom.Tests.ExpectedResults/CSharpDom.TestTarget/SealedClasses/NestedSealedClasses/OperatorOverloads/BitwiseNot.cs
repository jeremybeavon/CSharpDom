namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.OperatorOverloads
{
    public sealed class SealedClassWithNestedSealedClassWithBitwiseNotOperatorOverload
    {
        public sealed class Class
        {
            public static Class operator ~(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
