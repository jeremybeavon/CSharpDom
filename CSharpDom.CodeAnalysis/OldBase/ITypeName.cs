namespace CSharpDom.CodeAnalysis
{
    internal interface ITypeName
    {
        string Name { get; }

        int GenericParameterCount { get; }

        string NameWithGenericParameterCount { get; }
    }
}
