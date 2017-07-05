namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedInterfaces
{
    public class ClassWithNestedPartialClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public partial class Class
        {
            public interface Interface<T>
                where T : new()
            {
            }
        }
    }
}
