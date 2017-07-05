namespace CSharpDom.TestTarget.Partial.PartialStructs.OperatorOverloads
{
    public partial struct PartialStructWithWithUnaryPlusOperatorOverload
    {
        public static StructWithUnaryPlusOperatorOverload operator +(StructWithUnaryPlusOperatorOverload parameter1)
        {
            return default(StructWithUnaryPlusOperatorOverload);
        }
    }
}
