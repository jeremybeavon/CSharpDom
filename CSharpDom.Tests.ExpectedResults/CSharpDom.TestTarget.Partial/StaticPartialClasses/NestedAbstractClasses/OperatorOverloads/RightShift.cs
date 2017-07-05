namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.OperatorOverloads
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithRightShiftOperatorOverload
    {
        public abstract class Class
        {
            public static Class operator >>(Class parameter1, int parameter2)
            {
                return default(Class);
            }
        }
    }
}
