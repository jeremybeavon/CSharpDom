namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.OperatorOverloads
{
    public class ClassWithNestedSealedPartialClassWithIncrementOperatorOverload
    {
        public sealed partial class Class
        {
            public static Class operator ++(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
