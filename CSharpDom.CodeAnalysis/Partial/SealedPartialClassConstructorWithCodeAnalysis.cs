using System;
using System.Collections.Generic;
using System.Reflection;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class SealedPartialClassConstructorWithCodeAnalysis :
        EditableClassConstructor<
            AttributeGroupWithCodeAnalysis,
            ISealedPartialTypeWithCodeAnalysis,
            ConstructorParameterWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>,
        IHasSyntax<ConstructorDeclarationSyntax>
    {
        private readonly SealedClassConstructorWithCodeAnalysis constructor;

        public SealedPartialClassConstructorWithCodeAnalysis(
            ClassMemberVisibilityModifier visibility,
            string name,
            IEnumerable<ConstructorParameterWithCodeAnalysis> parameters,
            MethodBodyWithCodeAnalysis body)
            : this(new SealedClassConstructorWithCodeAnalysis(visibility, name, parameters, body))
        {
        }

        internal SealedPartialClassConstructorWithCodeAnalysis(SealedClassConstructorWithCodeAnalysis constructor)
        {
            this.constructor = constructor;
            constructor.DeclaringTypeFunc = () => DeclaringType.Class;
        }

        internal SealedClassConstructorWithCodeAnalysis Constructor
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

        public override ISealedPartialTypeWithCodeAnalysis DeclaringType
        {
            get { return constructor.Constructor.Constructor.Node.GetParentNode<ISealedPartialTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override IList<ConstructorParameterWithCodeAnalysis> Parameters
        {
            get { return constructor.Parameters; }
            set { constructor.Parameters = value; }
        }

        public override ClassMemberVisibilityModifier Visibility
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
