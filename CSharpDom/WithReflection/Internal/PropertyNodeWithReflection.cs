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
    internal class PropertyNodeWithReflection : PropertyNodeWithSymbols, IPropertyWithReflection
    {
        private const BindingFlags Flags = ReflectionMemberHelper.Flags;
        private PropertyInfo propertyInfo;

        public PropertyNodeWithReflection(
            PropertyDeclarationSyntax declaration,
            IBasicMemberContainer container,
            SemanticModel semanticModel)
            : base(declaration, container, semanticModel)
        {
        }

        public PropertyInfo PropertyInfo
        {
            get
            {
                return propertyInfo ?? (propertyInfo = ((IHasType)DeclaringType).Type.GetProperty(Symbol.Name, Flags));
            }
        }

        public IPropertyWithSymbols Symbols
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
