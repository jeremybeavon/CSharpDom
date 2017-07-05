namespace CSharpDom.TestTarget.Partial.PartialStructs.OperatorOverloads
{
    public partial struct PartialStructWithWithMinusOperatorOverload
    {
        public static StructWithMinusOperatorOverload operator -(StructWithMinusOperatorOverload parameter1, StructWithMinusOperatorOverload parameter2)
        {
            return default(StructWithMinusOperatorOverload);
        }
    }
}
