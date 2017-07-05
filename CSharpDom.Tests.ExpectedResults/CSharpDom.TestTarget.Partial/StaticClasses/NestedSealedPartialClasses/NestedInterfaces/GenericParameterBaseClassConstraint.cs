namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.NestedInterfaces
{
    public static class StaticClassWithNestedSealedPartialClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public sealed partial class Class
        {
            public interface Interface<T>
                where T : BaseClass
            {
            }
        }
    }
}
