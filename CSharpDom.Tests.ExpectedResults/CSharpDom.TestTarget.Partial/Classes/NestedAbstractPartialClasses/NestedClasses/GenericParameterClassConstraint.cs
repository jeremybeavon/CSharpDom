namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.NestedClasses
{
    public class ClassWithNestedAbstractPartialClassWithNestedPartialClassWithGenericParameterClassConstraint
    {
        public abstract partial class Class
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
