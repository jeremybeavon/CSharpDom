using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class TypeNameNode : ITypeName
    {
        public TypeNameNode(TypeDeclarationSyntax declaration)
        {
            Name = declaration.Identifier.ToString();
            GenericParameterCount = declaration.Arity;
        }

        public string Name { get; private set; }

        public int GenericParameterCount { get; private set; }

        public string NameWithGenericParameterCount
        {
            get { return GenericParameterCount == 0 ? Name : string.Format("{0}`{1}", Name, GenericParameterCount); }
        }
    }
}
