using System;
using System.Reflection;
using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithReflection.Internal
{
    internal class ConversionOperatorNodeWithReflection : ConversionOperatorNodeWithSymbols,
        IConversionOperatorWithReflection
    {
        private MethodInfo methodInfo;

        public ConversionOperatorNodeWithReflection(
            ConversionOperatorDeclarationSyntax declaration,
            IMemberContainer container,
            SemanticModel semanticModel)
            : base(declaration, container, semanticModel)
        {
        }

        public MethodInfo MethodInfo
        {
            get { return methodInfo ?? (methodInfo = ReflectionMemberHelper.FindStaticMethod(this)); }
        }

        public IConversionOperatorWithSymbols Symbols
        {
            get { return this; }
        }

        ITypeWithReflection IHasDeclaringType<ITypeWithReflection>.DeclaringType
        {
            get { return (ITypeWithReflection)DeclaringType; }
        }

        public void Accept(IReflectionVisitor visitor)
        {
            Accept(new ReflectionNodeVisitor(visitor));
        }
    }
}
