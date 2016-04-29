namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedInterfaces
{
    public class ClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public abstract class Class
        {
            public interface Interface<T>
                where T : BaseClass
            {
            }
        }
    }
}
