﻿using System;
using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithReflection.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions.Internal
{
    internal class IndexerNodeWithLinqExpressions : IndexerNodeWithReflection, IIndexerWithLinqExpressions
    {
        public IndexerNodeWithLinqExpressions(
            IndexerDeclarationSyntax declaration,
            IBasicMemberContainer container,
            SemanticModel semanticModel)
            : base(declaration, container, semanticModel)
        {
        }

        public IIndexerWithReflection Reflection
        {
            get { return this; }
        }

        IBasicTypeWithLinqExpressions IHasDeclaringType<IBasicTypeWithLinqExpressions>.DeclaringType
        {
            get { return (IBasicTypeWithLinqExpressions)DeclaringType; }
        }
    }
}
