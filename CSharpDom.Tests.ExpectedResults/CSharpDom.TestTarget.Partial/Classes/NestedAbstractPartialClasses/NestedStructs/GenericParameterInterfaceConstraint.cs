namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.NestedStructs
{
    public class ClassWithNestedAbstractPartialClassWithNestedStructWithGenericParameterInterfaceConstraint
    {
        public abstract partial class Class
        {
            public struct NestedStruct<T>
                where T : IInterface
            {
            }
        }
    }
}
