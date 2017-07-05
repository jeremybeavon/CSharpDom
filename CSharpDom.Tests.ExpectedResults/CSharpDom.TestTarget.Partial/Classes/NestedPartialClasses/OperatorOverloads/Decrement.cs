namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.OperatorOverloads
{
    public class ClassWithNestedPartialClassWithDecrementOperatorOverload
    {
        public partial class Class
        {
            public static Class operator --(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
