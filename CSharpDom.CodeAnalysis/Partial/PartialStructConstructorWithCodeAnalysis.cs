using System;
using System.Collections.Generic;
using System.Reflection;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System.Linq;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class PartialStructConstructorWithCodeAnalysis :
        EditableStructConstructor<
            AttributeGroupWithCodeAnalysis,
            IPartialStructTypeWithCodeAnalysis,
            ConstructorParameterWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>,
        IHasSyntax<ConstructorDeclarationSyntax>
    {
        private readonly StructConstructorWithCodeAnalysis constructor;

        public PartialStructConstructorWithCodeAnalysis(
            StructMemberVisibilityModifier visibility,
            string name,
            IEnumerable<ConstructorParameterWithCodeAnalysis> parameters,
            MethodBodyWithCodeAnalysis body)
            : this(new StructConstructorWithCodeAnalysis(visibility, name, parameters, body))
        {
        }

        internal PartialStructConstructorWithCodeAnalysis(StructConstructorWithCodeAnalysis constructor)
        {
            this.constructor = constructor;
            constructor.DeclaringTypeFunc = () => DeclaringType.Struct;
        }
        
        public StructConstructorWithCodeAnalysis Constructor
        {
            get { return constructor; }
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

        public override IPartialStructTypeWithCodeAnalysis DeclaringType
        {
            get { return constructor.Constructor.Node.GetParentNode<IPartialStructTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override IList<ConstructorParameterWithCodeAnalysis> Parameters
        {
            get { return constructor.Parameters; }
            set { constructor.Parameters = value; }
        }
        
        public override StructMemberVisibilityModifier Visibility
        {
            get { return constructor.Visibility; }
            set { constructor.Visibility = value; }
        }

        public ConstructorDeclarationSyntax Syntax
        {
            get { return constructor.Syntax; }
            set { constructor.Syntax = value; }
        }
    }
}
