namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public static partial class Class
        {
            public interface Interface<T>
                where T : class
            {
            }
        }
    }
}
