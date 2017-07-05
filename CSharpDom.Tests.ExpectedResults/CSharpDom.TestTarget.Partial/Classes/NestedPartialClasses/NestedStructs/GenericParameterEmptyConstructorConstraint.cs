namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedStructs
{
    public class ClassWithNestedPartialClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public partial class Class
        {
            public struct NestedStruct<T>
                where T : new()
            {
            }
        }
    }
}
