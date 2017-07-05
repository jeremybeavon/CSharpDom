namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.NestedInterfaces
{
    public static class StaticClassWithNestedPartialClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public partial class Class
        {
            public interface Interface<T>
                where T : BaseClass
            {
            }
        }
    }
}
