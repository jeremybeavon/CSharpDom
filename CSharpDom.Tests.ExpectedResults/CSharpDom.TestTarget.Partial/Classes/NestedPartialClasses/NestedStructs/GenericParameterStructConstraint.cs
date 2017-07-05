namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedStructs
{
    public class ClassWithNestedPartialClassWithNestedStructWithGenericParameterStructConstraint
    {
        public partial class Class
        {
            public struct NestedStruct<T>
                where T : struct
            {
            }
        }
    }
}
