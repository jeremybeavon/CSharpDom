namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedInterfaces
{
    public static partial class StaticPartialClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public interface Interface<T>
            where T : class, IInterface, new()
        {
        }
    }
}
