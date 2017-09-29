namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.NestedInterfaces
{
    public partial struct PartialStructWithNestedStaticClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public static class Class
        {
            public interface Interface<T>
                where T : IInterface
            {
            }
        }
    }
}
