namespace CSharpDom.TestTarget.Structs.OperatorOverloads
{
    public struct StructWithDecrementOperatorOverload
    {
        public static StructWithDecrementOperatorOverload operator --(StructWithDecrementOperatorOverload parameter1)
        {
            return default(StructWithDecrementOperatorOverload);
        }
    }
}
