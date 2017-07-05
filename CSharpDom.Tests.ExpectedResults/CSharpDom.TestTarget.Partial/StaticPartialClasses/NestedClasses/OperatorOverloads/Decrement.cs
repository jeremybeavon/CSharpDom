namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.OperatorOverloads
{
    public static partial class StaticPartialClassWithNestedClassWithDecrementOperatorOverload
    {
        public class Class
        {
            public static Class operator --(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
