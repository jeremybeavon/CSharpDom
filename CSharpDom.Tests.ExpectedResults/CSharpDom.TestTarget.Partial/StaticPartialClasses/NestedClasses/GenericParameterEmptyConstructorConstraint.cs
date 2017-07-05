namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses
{
    public static partial class StaticPartialClassWithNestedClassWithGenericParameterEmptyConstructorConstraint
    {
        public class Class<T>
            where T : new()
        {
        }
    }
}
