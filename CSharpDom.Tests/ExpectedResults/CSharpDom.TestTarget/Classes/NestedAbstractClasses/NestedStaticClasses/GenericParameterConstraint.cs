namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedStaticClasses
{
    public class ClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterClassConstraint
    {
        public abstract class Class
        {
            public static class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
