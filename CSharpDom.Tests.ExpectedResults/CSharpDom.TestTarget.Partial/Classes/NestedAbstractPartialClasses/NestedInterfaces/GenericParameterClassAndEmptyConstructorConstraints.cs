namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.NestedInterfaces
{
    public class ClassWithNestedAbstractPartialClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
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
