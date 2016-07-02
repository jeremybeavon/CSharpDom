namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedSealedClassWithGenericParameterClassConstraint
    {
        public sealed class Class<T>
            where T : class
        {
        }
    }
}
