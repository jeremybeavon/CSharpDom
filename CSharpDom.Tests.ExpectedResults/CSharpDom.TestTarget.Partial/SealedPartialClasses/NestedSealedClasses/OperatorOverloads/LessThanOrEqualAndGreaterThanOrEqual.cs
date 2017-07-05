namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.OperatorOverloads
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads
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
