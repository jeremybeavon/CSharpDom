namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.NestedClasses
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithNestedPartialClassWithGenericParameterInterfaceConstraint
    {
        public abstract partial class Class
        {
            public class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
