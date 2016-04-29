namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedAbstractClasses
{
    public class ClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassConstraint
    {
        public static class Class
        {
            public abstract class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
