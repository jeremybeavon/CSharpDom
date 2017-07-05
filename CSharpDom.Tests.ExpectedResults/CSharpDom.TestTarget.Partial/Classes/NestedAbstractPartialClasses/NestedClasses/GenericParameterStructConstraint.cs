namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.NestedClasses
{
    public class ClassWithNestedAbstractPartialClassWithNestedPartialClassWithGenericParameterStructConstraint
    {
        public abstract partial class Class
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
