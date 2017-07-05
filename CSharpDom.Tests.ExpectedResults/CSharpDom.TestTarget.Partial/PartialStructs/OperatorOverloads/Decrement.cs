namespace CSharpDom.TestTarget.Partial.PartialStructs.OperatorOverloads
{
    public partial struct PartialStructWithWithDecrementOperatorOverload
    {
        public static StructWithDecrementOperatorOverload operator --(StructWithDecrementOperatorOverload parameter1)
        {
            return default(StructWithDecrementOperatorOverload);
        }
    }
}
