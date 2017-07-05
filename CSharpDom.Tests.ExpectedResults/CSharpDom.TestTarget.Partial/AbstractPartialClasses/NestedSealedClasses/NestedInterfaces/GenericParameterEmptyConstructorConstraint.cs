namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.NestedInterfaces
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class
        {
            public interface Interface<T>
                where T : new()
            {
            }
        }
    }
}
