namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedInterfaces
{
    public static class StaticClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public sealed class Class
        {
            public interface Interface<T>
                where T : BaseClass
            {
            }
        }
    }
}
