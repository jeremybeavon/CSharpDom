namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.OperatorOverloads
{
    public class ClassWithNestedSealedPartialClassWithMultiplyOperatorOverload
    {
        public sealed partial class Class
        {
            public static Class operator *(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}
