namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithGenericParameterClassConstraint
    {
        public sealed class Class<T>
            where T : class
        {
        }
    }
}
