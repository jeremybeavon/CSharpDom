namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.NestedInterfaces
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public interface Interface<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
