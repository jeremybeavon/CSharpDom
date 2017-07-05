namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.NestedInterfaces
{
    public partial class PartialClassWithNestedClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public class Class
        {
            public interface Interface<T>
                where T : BaseClass
            {
            }
        }
    }
}
