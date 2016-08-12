namespace CSharpDom.TestTarget.Structs.OperatorOverloads
{
    public struct StructWithRightShiftOperatorOverload
    {
        public static StructWithRightShiftOperatorOverload operator >>(StructWithRightShiftOperatorOverload parameter1, int parameter2)
        {
            return default(StructWithRightShiftOperatorOverload);
        }
    }
}
