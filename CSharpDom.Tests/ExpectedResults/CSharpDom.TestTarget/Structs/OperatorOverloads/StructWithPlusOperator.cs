namespace CSharpDom.TestTarget.Structs.OperatorOverloads
{
    public struct StructWithPlusOperator
    {
        public static StructWithPlusOperator operator +(StructWithPlusOperator parameter1, StructWithPlusOperator parameter2)
        {
            return default(StructWithPlusOperator);
        }
    }
}
