using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class AbstractClassMethodWithCodeAnalysis :
        EditableClassMethod<
            AttributeGroupWithCodeAnalysis,
            IAbstractTypeWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            MethodParameterWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>,
        IHasSyntax<MethodDeclarationSyntax>,
        IHasNode<MethodDeclarationSyntax>
    {
        private readonly ClassMethodWithCodeAnalysis method;

        public AbstractClassMethodWithCodeAnalysis(
            ClassMemberVisibilityModifier visibility,
            ITypeReferenceWithCodeAnalysis returnType,
            string name,
            IEnumerable<MethodParameterWithCodeAnalysis> parameters,
            MethodBodyWithCodeAnalysis body)
            : this(new ClassMethodWithCodeAnalysis(visibility, returnType, name, parameters, body))
        {
        }

        internal AbstractClassMethodWithCodeAnalysis(ClassMethodWithCodeAnalysis method = null)
        {
            this.method = method ?? new ClassMethodWithCodeAnalysis();
            this.method.DeclaringTypeFunc = () => DeclaringType.Class;
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

        public override IAbstractTypeWithCodeAnalysis DeclaringType
        {
            get { return method.Method.Method.Node.GetParentNode<IAbstractTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override IList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return method.GenericParameters; }
            set { method.GenericParameters = value; }
        }

        public override ClassMemberInheritanceModifier InheritanceModifier
        {
            get { return method.InheritanceModifier; }
            set { method.InheritanceModifier = value; }
        }

        public override bool IsAsync
        {
            get { return method.IsAsync; }
            set { method.IsAsync = value; }
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

        public override ICollection<AttributeGroupWithCodeAnalysis> ReturnAttributes
        {
            get { return method.ReturnAttributes; }
            set { method.ReturnAttributes = value; }
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

        public MethodDeclarationSyntax Syntax
        {
            get { return method.Syntax; }
            set { method.Syntax = value; }
        }
        
        INode<MethodDeclarationSyntax> IHasNode<MethodDeclarationSyntax>.Node
        {
            get { return method.Method.Method.Node; }
        }

        internal ClassMethodWithCodeAnalysis InternalMethod
        {
            get { return method; }
        }
    }
}
