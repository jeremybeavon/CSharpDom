namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.OperatorOverloads
{
    public struct StructWithNestedSealedClassWithLogicalNotOperatorOverload
    {
        public sealed class Class
        {
            public static bool operator !(Class parameter1)
            {
                return default(bool);
            }
        }
    }
}
