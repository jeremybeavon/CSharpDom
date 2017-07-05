namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedInterfaces
{
    public sealed partial class SealedPartialClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public interface Interface<T>
            where T : class, new()
        {
        }
    }
}
