namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.NestedInterfaces
{
    public static class StaticClassWithNestedPartialClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public partial class Class
        {
            public interface Interface<T>
                where T : new()
            {
            }
        }
    }
}
