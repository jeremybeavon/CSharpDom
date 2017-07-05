namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.OperatorOverloads
{
    public class ClassWithNestedAbstractPartialClassWithDecrementOperatorOverload
    {
        public abstract partial class Class
        {
            public static Class operator --(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
