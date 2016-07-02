namespace CSharpDom.TestTarget.Structs.OperatorOverloads
{
    public struct StructWithUnaryPlusOperator
    {
        public static StructWithUnaryPlusOperator operator +(StructWithUnaryPlusOperator parameter1)
        {
            return default(StructWithUnaryPlusOperator);
        }
    }
}
