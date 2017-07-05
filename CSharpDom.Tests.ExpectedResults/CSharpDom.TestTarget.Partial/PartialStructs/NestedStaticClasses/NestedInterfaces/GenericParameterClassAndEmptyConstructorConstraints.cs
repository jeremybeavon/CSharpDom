namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.NestedInterfaces
{
    public partial struct PartialStructWithWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
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
