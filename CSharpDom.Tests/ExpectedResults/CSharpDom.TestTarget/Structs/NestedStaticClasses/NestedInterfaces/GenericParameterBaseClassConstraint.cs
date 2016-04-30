namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedInterfaces
{
    public struct StructWithNestedStaticClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public static class Class
        {
            public interface Interface<T>
                where T : BaseClass
            {
            }
        }
    }
}
