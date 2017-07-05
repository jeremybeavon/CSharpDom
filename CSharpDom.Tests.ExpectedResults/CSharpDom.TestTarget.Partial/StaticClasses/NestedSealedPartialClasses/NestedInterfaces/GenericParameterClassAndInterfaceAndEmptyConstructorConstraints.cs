namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.NestedInterfaces
{
    public static class StaticClassWithNestedSealedPartialClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public sealed partial class Class
        {
            public interface Interface<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
