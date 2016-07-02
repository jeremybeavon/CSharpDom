namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedInterfaces
{
    public struct StructWithNestedStaticClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
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
