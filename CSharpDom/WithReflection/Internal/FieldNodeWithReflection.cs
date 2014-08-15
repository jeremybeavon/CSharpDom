using System;
using System.Reflection;
using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithReflection.Internal
{
    internal class FieldNodeWithReflection : FieldNodeWithSymbols, IFieldWithReflection
    {
        private const BindingFlags Flags = ReflectionMemberHelper.Flags;
        private FieldInfo fieldInfo;

        public FieldNodeWithReflection(
            FieldDeclarationSyntax declaration,
            IMemberContainer container,
            SemanticModel semanticModel)
            : base(declaration, container, semanticModel)
        {
        }

        public FieldInfo FieldInfo
        {
            get { return fieldInfo ?? (fieldInfo = ((IHasType)DeclaringType).Type.GetField(Name, Flags)); }
        }

        public IFieldWithSymbols Symbols
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
