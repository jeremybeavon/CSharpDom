namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.OperatorOverloads
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloads
    {
        public abstract class Class
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
