using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using CSharpDom.Wrappers.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpDom.CodeAnalysis
{
    public sealed class AccessorWithCodeAnalysis :
        AbstractAccessor<AttributeGroupWithCodeAnalysis, MethodBodyWithCodeAnalysis>
    {
        private readonly IReadOnlyCollection<AttributeGroupWithCodeAnalysis> attributes;
        private readonly Lazy<MethodBodyWithCodeAnalysis> body;

        internal AccessorWithCodeAnalysis(AccessorDeclarationSyntax syntax)
        {
            Syntax = syntax;
            attributes = new ReadOnlyCollectionWrapper<AttributeListSyntax, AttributeGroupWithCodeAnalysis>(
                syntax.AttributeLists,
                collection => new AttributeGroupWithCodeAnalysis(collection))
            body = new Lazy<MethodBodyWithCodeAnalysis>(
                () => method.IsDefined(assembly, typeof(CompilerGeneratedAttribute)) ? null : new MethodBodyWithCodeAnalysis(method));
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes.Value.AttributesWithCodeAnalysis; }
        }

        public override MethodBodyWithCodeAnalysis Body
        {
            get { return body.Value; }
        }

        public AccessorDeclarationSyntax Syntax { get; private set; }
    }
}
