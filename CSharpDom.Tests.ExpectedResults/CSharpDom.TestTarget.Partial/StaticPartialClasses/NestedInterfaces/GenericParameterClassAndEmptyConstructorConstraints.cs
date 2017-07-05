namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedInterfaces
{
    public static partial class StaticPartialClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public interface Interface<T>
            where T : class, new()
        {
        }
    }
}
