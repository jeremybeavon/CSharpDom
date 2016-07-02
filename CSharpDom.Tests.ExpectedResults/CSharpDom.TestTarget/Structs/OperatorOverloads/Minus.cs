namespace CSharpDom.TestTarget.Structs.OperatorOverloads
{
    public struct StructWithMinusOperator
    {
        public static StructWithMinusOperator operator -(StructWithMinusOperator parameter1, StructWithMinusOperator parameter2)
        {
            return default(StructWithMinusOperator);
        }
    }
}
