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
    internal class OperatorOverloadNodeWithReflection : OperatorOverloadNodeWithSymbols, IOperatorOverloadWithReflection
    {
        private MethodInfo methodInfo;

        public OperatorOverloadNodeWithReflection(
            OperatorDeclarationSyntax declaration,
            IMemberContainer container,
            SemanticModel semanticModel)
            : base(declaration, container, semanticModel)
        {
        }

        public MethodInfo MethodInfo
        {
            get { return methodInfo ?? (methodInfo = ReflectionMemberHelper.FindStaticMethod(this)); }
        }

        public IOperatorOverloadWithSymbols Symbols
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
