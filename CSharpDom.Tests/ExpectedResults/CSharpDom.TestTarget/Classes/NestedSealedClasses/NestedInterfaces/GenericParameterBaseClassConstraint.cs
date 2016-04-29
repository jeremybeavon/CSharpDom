namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedInterfaces
{
    public class ClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public sealed class Class
        {
            public interface Interface<T>
                where T : BaseClass
            {
            }
        }
    }
}
