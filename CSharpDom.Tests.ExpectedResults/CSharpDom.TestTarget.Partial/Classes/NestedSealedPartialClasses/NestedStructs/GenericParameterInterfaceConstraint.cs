namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.NestedStructs
{
    public class ClassWithNestedSealedPartialClassWithNestedStructWithGenericParameterInterfaceConstraint
    {
        public sealed partial class Class
        {
            public struct NestedStruct<T>
                where T : IInterface
            {
            }
        }
    }
}
