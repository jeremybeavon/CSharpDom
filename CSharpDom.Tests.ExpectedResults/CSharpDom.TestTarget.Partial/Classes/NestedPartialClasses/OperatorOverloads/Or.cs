namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.OperatorOverloads
{
    public class ClassWithNestedPartialClassWithOrOperatorOverload
    {
        public partial class Class
        {
            public static Class operator |(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}
