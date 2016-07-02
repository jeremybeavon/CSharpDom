namespace CSharpDom.TestTarget.Classes.NestedStaticClasses
{
    public class ClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class<T>
            where T : new()
        {
        }
    }
}
