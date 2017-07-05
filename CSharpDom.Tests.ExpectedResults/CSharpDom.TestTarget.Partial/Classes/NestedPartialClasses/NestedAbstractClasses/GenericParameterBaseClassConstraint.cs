namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedAbstractClasses
{
    public class ClassWithNestedPartialClassWithNestedAbstractPartialClassWithGenericParameterBaseClassConstraint
    {
        public partial class Class
        {
            public abstract class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
