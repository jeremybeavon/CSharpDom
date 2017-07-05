namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedDelegates
{
    public class ClassWithNestedPartialClassWithNestedPartialClassWithNestedDelegateWithParametersWithAttributes
    {
        public partial class Class
        {
            public delegate void DelegateWithParametersWithAttributes([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2);
        }
    }
}
