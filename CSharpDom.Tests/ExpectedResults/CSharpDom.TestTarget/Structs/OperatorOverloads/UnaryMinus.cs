namespace CSharpDom.TestTarget.Structs.OperatorOverloads
{
    public struct StructWithUnaryMinusOperator
    {
        public static StructWithUnaryMinusOperator operator -(StructWithUnaryMinusOperator parameter1)
        {
            return default(StructWithUnaryMinusOperator);
        }
    }
}
