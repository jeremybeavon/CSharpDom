namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedInterfaces
{
    public class ClassWithNestedPartialClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public partial class Class
        {
            public interface Interface<T>
                where T : BaseClass
            {
            }
        }
    }
}
