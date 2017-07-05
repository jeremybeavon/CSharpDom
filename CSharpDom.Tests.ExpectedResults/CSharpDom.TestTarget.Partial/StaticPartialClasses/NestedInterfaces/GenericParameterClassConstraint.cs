namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedInterfaces
{
    public static partial class StaticPartialClassWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public interface Interface<T>
            where T : class
        {
        }
    }
}
