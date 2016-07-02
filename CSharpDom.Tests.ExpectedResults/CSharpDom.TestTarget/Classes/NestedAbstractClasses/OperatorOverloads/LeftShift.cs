namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.OperatorOverloads
{
    public class ClassWithNestedAbstractClassWithLeftShiftOperatorOverload
    {
        public abstract class Class
        {
            public static Class operator <<(Class parameter1, int parameter2)
            {
                return default(Class);
            }
        }
    }
}
