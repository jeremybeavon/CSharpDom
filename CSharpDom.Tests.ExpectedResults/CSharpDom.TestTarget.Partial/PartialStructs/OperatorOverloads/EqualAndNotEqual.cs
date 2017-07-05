namespace CSharpDom.TestTarget.Partial.PartialStructs.OperatorOverloads
{
    public partial struct PartialStructWithWithEqualAndNotEqualOperatorOverloads
    {
        public static bool operator ==(StructWithEqualAndNotEqualOperatorOverloads parameter1, StructWithEqualAndNotEqualOperatorOverloads parameter2)
        {
            return default(bool);
        }

        public static bool operator !=(StructWithEqualAndNotEqualOperatorOverloads parameter1, StructWithEqualAndNotEqualOperatorOverloads parameter2)
        {
            return default(bool);
        }
    }
}
