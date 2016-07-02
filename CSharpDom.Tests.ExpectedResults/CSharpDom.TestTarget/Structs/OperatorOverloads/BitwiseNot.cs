namespace CSharpDom.TestTarget.Structs.OperatorOverloads
{
    public struct StructWithBitwiseNotOperator
    {
        public static StructWithBitwiseNotOperator operator ~(StructWithBitwiseNotOperator parameter1)
        {
            return default(StructWithBitwiseNotOperator);
        }
    }
}
