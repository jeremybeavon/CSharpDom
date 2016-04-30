namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedInterfaces
{
    public struct StructWithNestedStaticClassWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public static class Class
        {
            public interface Interface<T>
                where T : struct
            {
            }
        }
    }
}
