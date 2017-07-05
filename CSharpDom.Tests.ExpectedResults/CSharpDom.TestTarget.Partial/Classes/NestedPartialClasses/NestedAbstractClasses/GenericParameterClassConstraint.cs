namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedAbstractClasses
{
    public class ClassWithNestedPartialClassWithNestedAbstractPartialClassWithGenericParameterClassConstraint
    {
        public partial class Class
        {
            public abstract class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
