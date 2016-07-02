namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.OperatorOverloads
{
    public struct StructWithNestedSealedClassWithUnaryMinusOperatorOverload
    {
        public sealed class Class
        {
            public static Class operator -(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
