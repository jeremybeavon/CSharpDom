namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.OperatorOverloads
{
    public static partial class StaticPartialClassWithNestedClassWithPlusOperatorOverload
    {
        public class Class
        {
            public static Class operator +(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}
