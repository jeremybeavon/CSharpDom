namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.NestedStructs
{
    public partial class PartialClassWithNestedSealedClassWithNestedStructWithGenericParameterClassConstraint
    {
        public sealed class Class
        {
            public struct NestedStruct<T>
                where T : class
            {
            }
        }
    }
}
