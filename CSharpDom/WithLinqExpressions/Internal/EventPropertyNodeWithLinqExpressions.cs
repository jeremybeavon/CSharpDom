﻿using System;
using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithReflection.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions.Internal
{
    internal class EventPropertyNodeWithLinqExpressions : EventPropertyNodeWithReflection, IEventPropertyWithLinqExpressions
    {
        public EventPropertyNodeWithLinqExpressions(
            EventDeclarationSyntax declaration,
            IMemberContainer container,
            SemanticModel semanticModel)
            : base(declaration, container, semanticModel)
        {
        }

        public IEventPropertyWithReflection Reflection
        {
            get { return this; }
        }

        ITypeWithLinqExpressions IHasDeclaringType<ITypeWithLinqExpressions>.DeclaringType
        {
            get { return (ITypeWithLinqExpressions)DeclaringType; }
        }

        public void Accept(ILinqExpressionsVisitor visitor)
        {
            Accept(new LinqExpressionsNodeVisitor(visitor));
        }
    }
}
