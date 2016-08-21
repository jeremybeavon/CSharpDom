using System;
using CSharpDom.BaseClasses;
using CSharpDom.Common.Expressions;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class UnnamedAttributeValueWithCodeAnalysis :
        EditableUnnamedAttributeValue<IExpression>,
        IHasSyntax<AttributeArgumentSyntax>,
        IHasId
    {
        private readonly Guid internalId;
        private readonly Func<AttributeArgumentSyntax> getArgument;
        private readonly Action<AttributeArgumentSyntax> setArgument;

        internal UnnamedAttributeValueWithCodeAnalysis(AttributeWithCodeAnalysis parent)
        {
            internalId = Guid.NewGuid();
            Parent = parent;
            getArgument = () => Parent.UnnamedValueList.GetChild(this);
            setArgument = syntax => Parent.UnnamedValueList.SetChild(this, syntax);
        }

        public AttributeArgumentSyntax Syntax
        {
            get { return getArgument(); }
        }

        Guid IHasId.InternalId
        {
            get { return internalId; }
        }

        internal AttributeWithCodeAnalysis Parent { get; set; }
    }
}
