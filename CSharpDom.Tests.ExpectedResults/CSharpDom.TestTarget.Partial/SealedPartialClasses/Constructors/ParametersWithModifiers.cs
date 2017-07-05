namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Constructors
{
    public sealed partial class SealedPartialClassWithConstructorWithParametersWithModifiers
    {
        public SealedClassWithConstructorWithParametersWithModifiers(ref string text, out int integer, params object[] objects)
        {
            integer = default(int);
        }
    }
}
