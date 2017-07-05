namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.OperatorOverloads
{
    public abstract partial class AbstractPartialClassWithNestedClassWithEqualAndNotEqualOperatorOverloads
    {
        public class Class
        {
            public static bool operator ==(Class parameter1, Class parameter2)
            {
                return default(bool);
            }

            public static bool operator !=(Class parameter1, Class parameter2)
            {
                return default(bool);
            }
        }
    }
}
