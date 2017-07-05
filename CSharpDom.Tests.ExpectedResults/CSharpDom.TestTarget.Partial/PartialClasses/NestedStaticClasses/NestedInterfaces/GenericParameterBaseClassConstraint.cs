namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.NestedInterfaces
{
    public partial class PartialClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
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
