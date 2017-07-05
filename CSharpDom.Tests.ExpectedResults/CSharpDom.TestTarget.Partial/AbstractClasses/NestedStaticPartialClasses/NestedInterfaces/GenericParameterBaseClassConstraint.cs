namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
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
