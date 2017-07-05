namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedClasses
{
    public class ClassWithNestedSealedPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed class Class<T>
            where T : class, new()
        {
        }
    }
}
