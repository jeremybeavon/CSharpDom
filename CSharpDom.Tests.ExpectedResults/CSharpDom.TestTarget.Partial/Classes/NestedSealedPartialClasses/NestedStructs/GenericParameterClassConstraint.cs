namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.NestedStructs
{
    public class ClassWithNestedSealedPartialClassWithNestedStructWithGenericParameterClassConstraint
    {
        public sealed partial class Class
        {
            public struct NestedStruct<T>
                where T : class
            {
            }
        }
    }
}
