namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedInterfaces
{
    public static partial class StaticPartialClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public interface Interface<T>
            where T : IInterface
        {
        }
    }
}
