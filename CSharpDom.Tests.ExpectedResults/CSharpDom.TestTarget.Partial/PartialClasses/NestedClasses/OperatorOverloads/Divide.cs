namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.OperatorOverloads
{
    public partial class PartialClassWithNestedClassWithDivideOperatorOverload
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
