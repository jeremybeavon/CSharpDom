namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.NestedInterfaces
{
    public static class StaticClassWithNestedStaticPartialClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public static partial class Class
        {
            public interface Interface<T>
                where T : BaseClass
            {
            }
        }
    }
}
