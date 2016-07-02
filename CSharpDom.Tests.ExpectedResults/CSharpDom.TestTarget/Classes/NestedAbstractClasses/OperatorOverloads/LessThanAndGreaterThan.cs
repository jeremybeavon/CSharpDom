namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.OperatorOverloads
{
    public class ClassWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloads
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
