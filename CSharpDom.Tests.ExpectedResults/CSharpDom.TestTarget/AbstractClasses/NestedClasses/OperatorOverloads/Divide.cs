namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.OperatorOverloads
{
    public abstract class AbstractClassWithNestedClassWithDivideOperatorOverload
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
