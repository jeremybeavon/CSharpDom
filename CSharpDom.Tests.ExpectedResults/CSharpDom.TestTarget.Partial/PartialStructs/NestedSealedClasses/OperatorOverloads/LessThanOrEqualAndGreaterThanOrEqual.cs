namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.OperatorOverloads
{
    public partial struct PartialStructWithWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads
    {
        public sealed class Class
        {
            public static bool operator <=(Class parameter1, Class parameter2)
            {
                return default(bool);
            }

            public static bool operator >=(Class parameter1, Class parameter2)
            {
                return default(bool);
            }
        }
    }
}
