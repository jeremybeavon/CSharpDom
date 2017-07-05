namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.OperatorOverloads
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithExclusiveOrOperatorOverload
    {
        public abstract class Class
        {
            public static Class operator ^(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}
