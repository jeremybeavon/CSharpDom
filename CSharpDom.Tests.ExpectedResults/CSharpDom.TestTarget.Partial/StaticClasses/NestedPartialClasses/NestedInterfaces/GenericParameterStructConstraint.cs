namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.NestedInterfaces
{
    public static class StaticClassWithNestedPartialClassWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public partial class Class
        {
            public interface Interface<T>
                where T : struct
            {
            }
        }
    }
}
