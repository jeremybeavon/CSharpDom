namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.NestedDelegates
{
    public class ClassWithNestedSealedPartialClassWithNestedDelegateWithParametersWithAttributes
    {
        public sealed partial class Class
        {
            public delegate void DelegateWithParametersWithAttributes([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2);
        }
    }
}
