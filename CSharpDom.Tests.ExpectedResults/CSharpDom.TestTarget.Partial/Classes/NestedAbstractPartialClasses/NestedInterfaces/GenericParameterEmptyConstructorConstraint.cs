namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.NestedInterfaces
{
    public class ClassWithNestedAbstractPartialClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public abstract partial class Class
        {
            public interface Interface<T>
                where T : new()
            {
            }
        }
    }
}
