namespace CSharpDom.TestTarget.Structs.OperatorOverloads
{
    public struct StructWithIncrementOperator
    {
        public static StructWithIncrementOperator operator ++(StructWithIncrementOperator parameter1)
        {
            return default(StructWithIncrementOperator);
        }
    }
}
