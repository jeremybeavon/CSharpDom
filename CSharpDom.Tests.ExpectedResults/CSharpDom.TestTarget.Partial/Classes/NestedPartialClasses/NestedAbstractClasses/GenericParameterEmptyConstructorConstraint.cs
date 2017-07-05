namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedAbstractClasses
{
    public class ClassWithNestedPartialClassWithNestedAbstractPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public partial class Class
        {
            public abstract class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
