namespace CSharpDom.TestTarget.Partial.PartialStructs.OperatorOverloads
{
    public partial struct PartialStructWithWithLeftShiftOperatorOverload
    {
        public static StructWithLeftShiftOperatorOverload operator <<(StructWithLeftShiftOperatorOverload parameter1, int parameter2)
        {
            return default(StructWithLeftShiftOperatorOverload);
        }
    }
}
