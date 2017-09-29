namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.OperatorOverloads
{
    public sealed partial class SealedPartialClassWithTrueAndFalseOperatorOverloads
    {
        public static bool operator true(SealedPartialClassWithTrueAndFalseOperatorOverloads parameter1)
        {
            return default(bool);
        }

        public static bool operator false(SealedPartialClassWithTrueAndFalseOperatorOverloads parameter1)
        {
            return default(bool);
        }
    }
}
