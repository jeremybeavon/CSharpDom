using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class SealedPartialClassMethodWithCodeAnalysis :
        EditableSealedClassMethod<
            AttributeGroupWithCodeAnalysis,
            ISealedPartialTypeWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            MethodParameterWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>,
        IHasSyntax<MethodDeclarationSyntax>
    {
        private readonly SealedClassMethodWithCodeAnalysis method;

        public SealedPartialClassMethodWithCodeAnalysis(
            ClassMemberVisibilityModifier visibility,
            ITypeReferenceWithCodeAnalysis returnType,
            string name,
            IEnumerable<MethodParameterWithCodeAnalysis> parameters,
            MethodBodyWithCodeAnalysis body)
            : this(new SealedClassMethodWithCodeAnalysis(visibility, returnType, name, parameters, body))
        {
        }

        internal SealedPartialClassMethodWithCodeAnalysis(SealedClassMethodWithCodeAnalysis method)
        {
            this.method = method;
            method.DeclaringTypeFunc = () => DeclaringType.Class;
        }
        
        public MethodWithBodyWithCodeAnalysis Method
        {
            get { return method.Method; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return method.Attributes; }
            set { method.Attributes = value; }
        }

        public override MethodBodyWithCodeAnalysis Body
        {
            get { return method.Body; }
            set { method.Body = value; }
        }

        public override ISealedPartialTypeWithCodeAnalysis DeclaringType
        {
            get { return Method.Method.Node.GetParentNode<ISealedPartialTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override IList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return method.GenericParameters; }
            set { method.GenericParameters = value; }
        }

        public override SealedClassMemberInheritanceModifier InheritanceModifier
        {
            get { return Syntax.Modifiers.ToSealedClassMemberInheritanceModifier(); }
            set
            {
                MethodDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithSealedClassMemberInheritanceModifier(value));
            }
        }
        
        public override string Name
        {
            get { return method.Name; }
            set { method.Name = value; }
        }

        public override IList<MethodParameterWithCodeAnalysis> Parameters
        {
            get { return method.Parameters; }
            set { method.Parameters = value; }
        }

        public override ITypeReferenceWithCodeAnalysis ReturnType
        {
            get { return method.ReturnType; }
            set { method.ReturnType = value; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return method.Visibility; }
            set { method.Visibility = value; }
        }

        public override bool IsAsync
        {
            get { return method.IsAsync; }
            set { method.IsAsync = value; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> ReturnAttributes
        {
            get { return method.ReturnAttributes; }
            set { method.ReturnAttributes = value; }
        }

        public MethodDeclarationSyntax Syntax
        {
            get { return method.Syntax; }
            set { method.Syntax = value; }
        }

        internal SealedClassMethodWithCodeAnalysis InternalMethod
        {
            get { return method; }
        }
    }
}
