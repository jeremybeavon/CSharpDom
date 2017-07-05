namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.NestedInterfaces
{
    public partial struct PartialStructWithWithNestedStaticClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class
        {
            public interface Interface<T>
                where T : new()
            {
            }
        }
    }
}
