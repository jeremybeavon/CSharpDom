namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.OperatorOverloads
{
    public class ClassWithNestedAbstractPartialClassWithModuloOperatorOverload
    {
        public abstract partial class Class
        {
            public static Class operator %(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}
