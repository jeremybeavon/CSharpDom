namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.NestedInterfaces
{
    public partial class PartialClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class
        {
            public interface Interface<T>
                where T : new()
            {
            }
        }
    }
}
