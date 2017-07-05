namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Constructors
{
    public sealed class SealedClassWithNestedPartialClassWithConstructorWithParametersWithModifiers
    {
        public partial class Class
        {
            public Class(ref string text, out int integer, params object[] objects)
            {
                integer = default(int);
            }
        }
    }
}
