namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedInterfaces
{
    public static partial class StaticPartialClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public interface Interface<T>
            where T : new()
        {
        }
    }
}
