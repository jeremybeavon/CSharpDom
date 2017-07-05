namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public static partial class Class
        {
            public interface Interface<T>
                where T : IInterface
            {
            }
        }
    }
}
