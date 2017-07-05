namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedAbstractClasses
{
    public class ClassWithNestedPartialClassWithNestedAbstractPartialClassWithGenericParameterStructConstraint
    {
        public partial class Class
        {
            public abstract class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
