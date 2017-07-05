namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.NestedInterfaces
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public interface Interface<T>
                where T : class, new()
            {
            }
        }
    }
}
