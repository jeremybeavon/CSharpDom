namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.NestedStructs
{
    public partial class PartialClassWithNestedClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class
        {
            public struct NestedStruct<T>
                where T : class, new()
            {
            }
        }
    }
}
