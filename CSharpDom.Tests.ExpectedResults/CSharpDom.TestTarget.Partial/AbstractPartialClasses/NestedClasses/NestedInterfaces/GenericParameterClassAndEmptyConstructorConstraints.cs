namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.NestedInterfaces
{
    public abstract partial class AbstractPartialClassWithNestedClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class
        {
            public interface Interface<T>
                where T : class, new()
            {
            }
        }
    }
}
