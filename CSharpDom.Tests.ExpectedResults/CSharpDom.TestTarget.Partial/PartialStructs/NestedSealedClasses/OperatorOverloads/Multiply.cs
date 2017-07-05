namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.OperatorOverloads
{
    public partial struct PartialStructWithWithNestedSealedClassWithMultiplyOperatorOverload
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
