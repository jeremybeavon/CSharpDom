namespace CSharpDom.TestTarget.Partial.PartialStructs.OperatorOverloads
{
    public partial struct PartialStructWithWithPlusOperatorOverload
    {
        public static StructWithPlusOperatorOverload operator +(StructWithPlusOperatorOverload parameter1, StructWithPlusOperatorOverload parameter2)
        {
            return default(StructWithPlusOperatorOverload);
        }
    }
}
