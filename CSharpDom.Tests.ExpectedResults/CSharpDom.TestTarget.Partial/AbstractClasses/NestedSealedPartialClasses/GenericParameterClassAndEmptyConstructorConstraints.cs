namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed class Class<T>
            where T : class, new()
        {
        }
    }
}
