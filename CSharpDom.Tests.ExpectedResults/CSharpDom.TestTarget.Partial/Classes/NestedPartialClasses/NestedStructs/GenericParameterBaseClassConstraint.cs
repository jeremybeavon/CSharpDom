namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedStructs
{
    public class ClassWithNestedPartialClassWithNestedStructWithGenericParameterBaseClassConstraint
    {
        public partial class Class
        {
            public struct NestedStruct<T>
                where T : BaseClass
            {
            }
        }
    }
}
