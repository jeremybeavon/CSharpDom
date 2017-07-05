namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.NestedInterfaces
{
    public class ClassWithNestedSealedPartialClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public sealed partial class Class
        {
            public interface Interface<T>
                where T : BaseClass
            {
            }
        }
    }
}
