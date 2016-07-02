namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.OperatorOverloads
{
    public sealed class SealedClassWithNestedSealedClassWithUnaryPlusOperatorOverload
    {
        public sealed class Class
        {
            public static Class operator +(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
