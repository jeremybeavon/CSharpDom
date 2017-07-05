namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.OperatorOverloads
{
    public class ClassWithNestedAbstractPartialClassWithLeftShiftOperatorOverload
    {
        public abstract partial class Class
        {
            public static Class operator <<(Class parameter1, int parameter2)
            {
                return default(Class);
            }
        }
    }
}
