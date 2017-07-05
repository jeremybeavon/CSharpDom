namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.NestedInterfaces
{
    public static class StaticClassWithNestedPartialClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public partial class Class
        {
            public interface Interface<T>
                where T : IInterface
            {
            }
        }
    }
}
