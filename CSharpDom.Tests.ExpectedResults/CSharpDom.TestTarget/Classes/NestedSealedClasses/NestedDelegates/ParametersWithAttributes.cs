namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedDelegates
{
    public class ClassWithNestedSealedClassWithNestedClassWithNestedDelegateWithParametersWithAttributes
    {
        public sealed class Class
        {
            public delegate void DelegateWithParametersWithAttributes([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2);
        }
    }
}
