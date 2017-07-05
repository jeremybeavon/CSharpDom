namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticClasses
{
    public class ClassWithNestedStaticPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class<T>
            where T : new()
        {
        }
    }
}
