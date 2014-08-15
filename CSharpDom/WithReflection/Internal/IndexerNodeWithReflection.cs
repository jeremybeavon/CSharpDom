using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection;
using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithReflection.Internal
{
    internal class IndexerNodeWithReflection : IndexerNodeWithSymbols, IIndexerWithReflection
    {
        private const BindingFlags InstanceFlags = ReflectionMemberHelper.InstanceFlags;
        private PropertyInfo propertyInfo;

        public IndexerNodeWithReflection(
            IndexerDeclarationSyntax declaration,
            IBasicMemberContainer container,
            SemanticModel semanticModel)
            : base(declaration, container, semanticModel)
        {
        }

        public PropertyInfo PropertyInfo
        {
            get
            {
                if (propertyInfo == null)
                {
                    ImmutableArray<IParameterSymbol> parameters = Symbol.Parameters;
                    PropertyInfo[] properties = ((IHasType)DeclaringType).Type.GetProperties(InstanceFlags)
                        .Where(property => ReflectionMemberHelper.IsMatch(property.GetIndexParameters(), parameters))
                        .ToArray();
                    propertyInfo = ReflectionMemberHelper.ValidateMember(properties);
                }

                return propertyInfo;
            }
        }

        public IIndexerWithSymbols Symbols
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
