namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.OperatorOverloads
{
    public sealed class SealedClassWithNestedSealedPartialClassWithLessThanAndGreaterThanOperatorOverloads
    {
        public sealed partial class Class
        {
            public static bool operator <(Class parameter1, Class parameter2)
            {
                return default(bool);
            }

            public static bool operator >(Class parameter1, Class parameter2)
            {
                return default(bool);
            }
        }
    }
}
