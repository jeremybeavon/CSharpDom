namespace CSharpDom.TestTarget.Structs.OperatorOverloads
{
    public struct StructWithDecrementOperator
    {
        public static StructWithDecrementOperator operator --(StructWithDecrementOperator parameter1)
        {
            return default(StructWithDecrementOperator);
        }
    }
}
