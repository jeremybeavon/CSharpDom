namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.NestedInterfaces
{
    public partial class PartialClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
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
