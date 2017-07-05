namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.OperatorOverloads
{
    public abstract partial class AbstractPartialClassWithNestedClassWithDivideOperatorOverload
    {
        public class Class
        {
            public static Class operator /(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}
