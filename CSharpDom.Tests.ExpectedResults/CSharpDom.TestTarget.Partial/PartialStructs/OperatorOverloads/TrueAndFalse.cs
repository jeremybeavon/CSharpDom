namespace CSharpDom.TestTarget.Partial.PartialStructs.OperatorOverloads
{
    public partial struct PartialStructWithWithTrueAndFalseOperatorOverloads
    {
        public static bool operator true(StructWithTrueAndFalseOperatorOverloads parameter1)
        {
            return default(bool);
        }

        public static bool operator false(StructWithTrueAndFalseOperatorOverloads parameter1)
        {
            return default(bool);
        }
    }
}
