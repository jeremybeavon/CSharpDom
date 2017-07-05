namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.OperatorOverloads
{
    public partial struct PartialStructWithWithNestedSealedClassWithRightShiftOperatorOverload
    {
        public sealed class Class
        {
            public static Class operator >>(Class parameter1, int parameter2)
            {
                return default(Class);
            }
        }
    }
}
