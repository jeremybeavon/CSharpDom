namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.NestedInterfaces
{
    public partial class PartialClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public interface Interface<T>
                where T : class, new()
            {
            }
        }
    }
}
