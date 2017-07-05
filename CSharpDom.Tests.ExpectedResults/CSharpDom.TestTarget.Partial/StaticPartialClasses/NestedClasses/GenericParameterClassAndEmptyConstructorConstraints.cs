namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses
{
    public static partial class StaticPartialClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class<T>
            where T : class, new()
        {
        }
    }
}
