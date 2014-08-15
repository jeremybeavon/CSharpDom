using System;
using System.Reflection;
using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithReflection.Internal
{
    internal class DestructorNodeWithReflection : DestructorNodeWithSymbols, IDestructorWithReflection,
        INestedDestructorWithReflection
    {
        private const string MethodName = "Finalize";
        private const BindingFlags Flags = BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly;
        private MethodInfo methodInfo;

        public DestructorNodeWithReflection(
            DestructorDeclarationSyntax declaration,
            ClassDeclarationNode container,
            SemanticModel semanticModel)
            : base(declaration, container, semanticModel)
        {
        }

        public MethodInfo MethodInfo
        {
            get { return methodInfo ?? (methodInfo = ((IHasType)DeclaringType).Type.GetMethod(MethodName, Flags)); }
        }

        public IDestructorWithSymbols Symbols
        {
            get { return this; }
        }

        IClassDeclarationWithReflection IHasDeclaringType<IClassDeclarationWithReflection>.DeclaringType
        {
            get { return (IClassDeclarationWithReflection)DeclaringType; }
        }

        INestedClassDeclarationWithReflection IHasDeclaringType<INestedClassDeclarationWithReflection>.DeclaringType
        {
            get { return (INestedClassDeclarationWithReflection)DeclaringType; }
        }

        INestedDestructorWithSymbols IHasSymbols<INestedDestructorWithSymbols>.Symbols
        {
            get { return this; }
        }

        public void Accept(IReflectionVisitor visitor)
        {
            Accept(new ReflectionNodeVisitor(visitor));
        }
    }
}
