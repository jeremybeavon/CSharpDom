namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.OperatorOverloads
{
    public static partial class StaticPartialClassWithNestedClassWithLeftShiftOperatorOverload
    {
        public class Class
        {
            public static Class operator <<(Class parameter1, int parameter2)
            {
                return default(Class);
            }
        }
    }
}
