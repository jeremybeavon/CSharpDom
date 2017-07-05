namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.OperatorOverloads
{
    public partial class PartialClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads
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
