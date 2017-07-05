namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.NestedInterfaces
{
    public partial struct PartialStructWithWithNestedStaticClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
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
