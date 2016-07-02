namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.OperatorOverloads
{
    public struct StructWithNestedSealedClassWithLeftShiftOperatorOverload
    {
        public sealed class Class
        {
            public static Class operator <<(Class parameter1, int parameter2)
            {
                return default(Class);
            }
        }
    }
}
