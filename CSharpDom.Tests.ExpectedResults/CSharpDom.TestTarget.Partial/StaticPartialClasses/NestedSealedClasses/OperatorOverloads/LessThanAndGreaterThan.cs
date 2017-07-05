namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.OperatorOverloads
{
    public static partial class StaticPartialClassWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloads
    {
        public sealed class Class
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
