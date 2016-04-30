namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedInterfaces
{
    public sealed class SealedClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public static class Class
        {
            public interface Interface<T>
                where T : struct
            {
            }
        }
    }
}
