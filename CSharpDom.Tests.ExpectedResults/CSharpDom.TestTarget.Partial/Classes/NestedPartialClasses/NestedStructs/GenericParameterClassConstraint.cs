namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedStructs
{
    public class ClassWithNestedPartialClassWithNestedStructWithGenericParameterClassConstraint
    {
        public partial class Class
        {
            public struct NestedStruct<T>
                where T : class
            {
            }
        }
    }
}
