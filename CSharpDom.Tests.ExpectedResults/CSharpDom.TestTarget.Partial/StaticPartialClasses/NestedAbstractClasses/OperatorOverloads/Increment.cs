namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.OperatorOverloads
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithIncrementOperatorOverload
    {
        public abstract class Class
        {
            public static Class operator ++(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
