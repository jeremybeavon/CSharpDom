namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedInterfaces
{
    public sealed partial class SealedPartialClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public interface Interface<T>
            where T : new()
        {
        }
    }
}
