namespace CSharpDom.TestTarget.Partial.PartialStructs.OperatorOverloads
{
    public partial struct PartialStructWithWithOrOperatorOverload
    {
        public static StructWithOrOperatorOverload operator |(StructWithOrOperatorOverload parameter1, StructWithOrOperatorOverload parameter2)
        {
            return default(StructWithOrOperatorOverload);
        }
    }
}
