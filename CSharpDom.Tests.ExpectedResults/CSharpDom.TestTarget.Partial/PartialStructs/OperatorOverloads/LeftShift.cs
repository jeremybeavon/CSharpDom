namespace CSharpDom.TestTarget.Partial.PartialStructs.OperatorOverloads
{
    public partial struct PartialStructWithLeftShiftOperatorOverload
    {
        public static PartialStructWithLeftShiftOperatorOverload operator <<(PartialStructWithLeftShiftOperatorOverload parameter1, int parameter2)
        {
            return default(PartialStructWithLeftShiftOperatorOverload);
        }
    }
}
