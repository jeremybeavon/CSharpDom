namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.NestedInterfaces
{
    public class ClassWithNestedSealedPartialClassWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public sealed partial class Class
        {
            public interface Interface<T>
                where T : class
            {
            }
        }
    }
}
