namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.NestedInterfaces
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public abstract class Class
        {
            public interface Interface<T>
                where T : IInterface
            {
            }
        }
    }
}
