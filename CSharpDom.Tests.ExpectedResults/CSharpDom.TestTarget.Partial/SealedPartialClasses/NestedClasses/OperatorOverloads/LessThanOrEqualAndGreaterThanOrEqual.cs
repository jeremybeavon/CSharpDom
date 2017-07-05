namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.OperatorOverloads
{
    public sealed partial class SealedPartialClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads
    {
        public class Class
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
