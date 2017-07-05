namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.NestedInterfaces
{
    public static partial class StaticPartialClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
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
