namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.OperatorOverloads
{
    public class ClassWithNestedAbstractClassWithAndOperatorOverload
    {
        public abstract class Class
        {
            public static Class operator &(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}
