namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses.NestedInterfaces
{
    public static partial class StaticPartialClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
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
