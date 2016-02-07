namespace CSharpDom.TestTarget.Structs.OperatorOverloads
{
    public struct StructWithRightShiftOperator
    {
        public static StructWithRightShiftOperator operator >>(StructWithRightShiftOperator parameter1, int parameter2)
        {
            return parameter1;
        }
    }
}
