namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.NestedStructs
{
    public partial class PartialClassWithNestedClassWithNestedStructWithGenericParameterInterfaceConstraint
    {
        public class Class
        {
            public struct NestedStruct<T>
                where T : IInterface
            {
            }
        }
    }
}
