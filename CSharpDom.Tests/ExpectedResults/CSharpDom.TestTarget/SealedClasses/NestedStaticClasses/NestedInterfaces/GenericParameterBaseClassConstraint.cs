namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedInterfaces
{
    public sealed class SealedClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public static class Class
        {
            public interface Interface<T>
                where T : BaseClass
            {
            }
        }
    }
}
