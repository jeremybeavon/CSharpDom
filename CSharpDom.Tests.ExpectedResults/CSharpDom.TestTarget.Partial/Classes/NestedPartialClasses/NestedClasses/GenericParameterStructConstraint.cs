namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedClasses
{
    public class ClassWithNestedPartialClassWithNestedPartialClassWithGenericParameterStructConstraint
    {
        public partial class Class
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
