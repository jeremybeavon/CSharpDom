namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.OperatorOverloads
{
    public class ClassWithNestedPartialClassWithBitwiseNotOperatorOverload
    {
        public partial class Class
        {
            public static Class operator ~(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
