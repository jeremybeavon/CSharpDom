namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.OperatorOverloads
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithDivideOperatorOverload
    {
        public abstract class Class
        {
            public static Class operator /(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}
