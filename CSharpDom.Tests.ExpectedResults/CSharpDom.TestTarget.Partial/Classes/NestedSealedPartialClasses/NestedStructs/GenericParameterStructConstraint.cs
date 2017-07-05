namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.NestedStructs
{
    public class ClassWithNestedSealedPartialClassWithNestedStructWithGenericParameterStructConstraint
    {
        public sealed partial class Class
        {
            public struct NestedStruct<T>
                where T : struct
            {
            }
        }
    }
}
