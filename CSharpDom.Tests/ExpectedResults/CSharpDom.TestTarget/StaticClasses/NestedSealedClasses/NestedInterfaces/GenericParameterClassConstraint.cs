namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedInterfaces
{
    public static class StaticClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public sealed class Class
        {
            public interface Interface<T>
                where T : class
            {
            }
        }
    }
}
