namespace CSharpDom.TestTarget.Classes.NestedStaticClasses
{
    public class ClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static class Class<T>
            where T : class, new()
        {
        }
    }
}
