using System;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class BasicTypeWithCodeAnalysis :
        EditableBasicType<
            EventWithCodeAnalysis,
            PropertyWithCodeAnalysis,
            IndexerWithCodeAnalysis,
            MethodWithCodeAnalysis>,
        IHasSyntax<InterfaceDeclarationSyntax>
    {
        private readonly Node<BasicTypeWithCodeAnalysis, InterfaceDeclarationSyntax> node;



        public InterfaceDeclarationSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }
    }
}
