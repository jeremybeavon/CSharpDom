namespace CSharpDom.TestTarget.Structs.OperatorOverloads
{
    public struct StructWithMultiplyOperator
    {
        public static StructWithMultiplyOperator operator *(StructWithMultiplyOperator parameter1, StructWithMultiplyOperator parameter2)
        {
            return default(StructWithMultiplyOperator);
        }
    }
}
