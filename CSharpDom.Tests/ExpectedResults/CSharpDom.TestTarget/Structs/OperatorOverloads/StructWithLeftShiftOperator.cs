namespace CSharpDom.TestTarget.Structs.OperatorOverloads
{
    public struct StructWithLeftShiftOperator
    {
        public static StructWithLeftShiftOperator operator <<(StructWithLeftShiftOperator parameter1, int parameter2)
        {
            return parameter1;
        }
    }
}
