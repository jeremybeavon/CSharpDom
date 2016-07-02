namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedSealedClassWithGenericParameterInterfaceConstraint
    {
        public sealed class Class<T>
            where T : IInterface
        {
        }
    }
}
