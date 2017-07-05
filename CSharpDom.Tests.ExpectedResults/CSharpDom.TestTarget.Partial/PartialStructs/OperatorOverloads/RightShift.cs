namespace CSharpDom.TestTarget.Partial.PartialStructs.OperatorOverloads
{
    public partial struct PartialStructWithWithRightShiftOperatorOverload
    {
        public static StructWithRightShiftOperatorOverload operator >>(StructWithRightShiftOperatorOverload parameter1, int parameter2)
        {
            return default(StructWithRightShiftOperatorOverload);
        }
    }
}
