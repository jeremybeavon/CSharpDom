namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.NestedInterfaces
{
    public class ClassWithNestedAbstractPartialClassWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public abstract partial class Class
        {
            public interface Interface<T>
                where T : class
            {
            }
        }
    }
}
