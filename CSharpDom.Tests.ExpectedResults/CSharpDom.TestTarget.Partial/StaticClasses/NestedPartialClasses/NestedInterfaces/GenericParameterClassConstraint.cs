namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.NestedInterfaces
{
    public static class StaticClassWithNestedPartialClassWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public partial class Class
        {
            public interface Interface<T>
                where T : class
            {
            }
        }
    }
}
