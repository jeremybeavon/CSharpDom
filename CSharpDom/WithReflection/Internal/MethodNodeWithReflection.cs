using System;
using System.Reflection;
using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithReflection.Internal
{
    internal class MethodNodeWithReflection : MethodNodeWithSymbols, IMethodWithReflection
    {
        private MethodInfo methodInfo;

        public MethodNodeWithReflection(
            MethodDeclarationSyntax declaration,
            IBasicMemberContainer container,
            SemanticModel semanticModel)
            : base(declaration, container, semanticModel)
        {
        }

        public MethodInfo MethodInfo
        {
            get { return methodInfo ?? (methodInfo = ReflectionMemberHelper.FindMethod(this)); }
        }

        public IMethodWithSymbols Symbols
        {
            get { return this; }
        }

        IBasicTypeWithReflection IHasDeclaringType<IBasicTypeWithReflection>.DeclaringType
        {
            get { return (IBasicTypeWithReflection)DeclaringType; }
        }

        public void Accept(IReflectionVisitor visitor)
        {
            Accept(new ReflectionNodeVisitor(visitor));
        }
    }
}
