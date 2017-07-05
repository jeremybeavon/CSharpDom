namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.OperatorOverloads
{
    public class ClassWithNestedAbstractPartialClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads
    {
        public abstract partial class Class
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
