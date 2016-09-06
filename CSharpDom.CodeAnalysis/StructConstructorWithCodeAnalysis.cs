using System;
using System.Collections.Generic;
using System.Reflection;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructConstructorWithCodeAnalysis :
        EditableStructConstructor<
            AttributeGroupWithCodeAnalysis,
            IStructType,
            ConstructorParameterWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>,
        IHasSyntax<ConstructorDeclarationSyntax>,
        IHasId
    {
        private readonly Guid internalId;
        private readonly ConstructorWithCodeAnalysis constructor;

        private StructConstructorWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return constructor.Attributes; }
            set { constructor.Attributes = value; }
        }

        public override MethodBodyWithCodeAnalysis Body
        {
            get { return constructor.Body; }
            set { constructor.Body = value; }
        }
        
        public override IList<ConstructorParameterWithCodeAnalysis> Parameters
        {
            get { return constructor.Parameters; }
            set { constructor.Parameters = value; }
        }
        
        public override StructMemberVisibilityModifier Visibility
        {
            get { return Syntax.Modifiers.ToStructMemberVisibilityModifier(); }
            set
            {
                ConstructorDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithStructMemberVisibilityModifier(value));
            }
        }

        public ConstructorDeclarationSyntax Syntax
        {
            get { return constructor.Syntax; }
            set { constructor.Syntax = value; }
        }

        Guid IHasId.InternalId
        {
            get { return internalId; }
        }
    }
}
