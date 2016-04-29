namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedStaticClasses
{
    public class ClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class
        {
            public static class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
