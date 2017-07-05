namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.NestedInterfaces
{
    public static class StaticClassWithNestedSealedPartialClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public sealed partial class Class
        {
            public interface Interface<T>
                where T : new()
            {
            }
        }
    }
}
