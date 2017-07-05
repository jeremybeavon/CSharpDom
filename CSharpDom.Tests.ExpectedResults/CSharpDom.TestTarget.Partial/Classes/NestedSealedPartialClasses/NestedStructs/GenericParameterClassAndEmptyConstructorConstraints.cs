namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.NestedStructs
{
    public class ClassWithNestedSealedPartialClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed partial class Class
        {
            public struct NestedStruct<T>
                where T : class, new()
            {
            }
        }
    }
}
