namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.NestedClasses
{
    public class ClassWithNestedSealedPartialClassWithNestedPartialClassWithGenericParameterStructConstraint
    {
        public sealed partial class Class
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
