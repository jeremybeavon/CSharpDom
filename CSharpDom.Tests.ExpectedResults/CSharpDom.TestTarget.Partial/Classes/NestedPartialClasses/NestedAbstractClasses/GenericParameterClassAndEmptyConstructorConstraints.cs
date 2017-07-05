namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedAbstractClasses
{
    public class ClassWithNestedPartialClassWithNestedAbstractPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public partial class Class
        {
            public abstract class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
