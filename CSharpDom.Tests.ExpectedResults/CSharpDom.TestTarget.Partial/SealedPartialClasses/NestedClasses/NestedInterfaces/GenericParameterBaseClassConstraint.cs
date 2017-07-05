namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.NestedInterfaces
{
    public sealed partial class SealedPartialClassWithNestedClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
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
