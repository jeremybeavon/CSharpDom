namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses.NestedInterfaces
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public static class Class
        {
            public interface Interface<T>
                where T : class
            {
            }
        }
    }
}
