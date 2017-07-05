namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.OperatorOverloads
{
    public partial struct PartialStructWithWithNestedSealedClassWithUnaryPlusOperatorOverload
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
