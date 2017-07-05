namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.NestedInterfaces
{
    public partial struct PartialStructWithWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public static class Class
        {
            public interface Interface<T>
                where T : class
            {
            }
        }
    }
}
