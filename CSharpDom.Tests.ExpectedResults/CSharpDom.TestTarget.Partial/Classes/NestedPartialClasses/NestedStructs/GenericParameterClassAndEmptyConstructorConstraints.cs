namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedStructs
{
    public class ClassWithNestedPartialClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public partial class Class
        {
            public struct NestedStruct<T>
                where T : class, new()
            {
            }
        }
    }
}
