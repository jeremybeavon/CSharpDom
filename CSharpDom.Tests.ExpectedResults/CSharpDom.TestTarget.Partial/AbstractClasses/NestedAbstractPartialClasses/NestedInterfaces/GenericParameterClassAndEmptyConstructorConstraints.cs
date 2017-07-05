namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract partial class Class
        {
            public interface Interface<T>
                where T : class, new()
            {
            }
        }
    }
}
