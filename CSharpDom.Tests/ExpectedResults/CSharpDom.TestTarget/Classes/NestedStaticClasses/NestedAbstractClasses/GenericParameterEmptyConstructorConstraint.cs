namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedAbstractClasses
{
    public class ClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class
        {
            public abstract class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
