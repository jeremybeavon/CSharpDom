using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class AbstractPartialClassAbstractMethodWithCodeAnalysis :
        EditableAbstractMethod<
            AttributeGroupWithCodeAnalysis,
            IAbstractPartialTypeWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            MethodParameterWithCodeAnalysis>,
        IHasSyntax<MethodDeclarationSyntax>
    {
        private readonly AbstractMethodWithCodeAnalysis method;

        public AbstractPartialClassAbstractMethodWithCodeAnalysis(
            ClassMemberVisibilityModifier visibility,
            ITypeReferenceWithCodeAnalysis returnType,
            string name,
            IEnumerable<MethodParameterWithCodeAnalysis> parameters)
            : this(new AbstractMethodWithCodeAnalysis(visibility, returnType, name, parameters))
        {
        }

        internal AbstractPartialClassAbstractMethodWithCodeAnalysis(AbstractMethodWithCodeAnalysis method)
        {
            this.method = method;
            method.DeclaringTypeFunc = () => DeclaringType.Class;
        }
        
        public MethodWithCodeAnalysis Method
        {
            get { return method.Method; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return method.Attributes; }
            set { method.Attributes = value; }
        }

        public override IAbstractPartialTypeWithCodeAnalysis DeclaringType
        {
            get { return method.Method.Node.GetParent<IAbstractPartialTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override IList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return method.GenericParameters; }
            set { method.GenericParameters = value; }
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

        public MethodDeclarationSyntax Syntax
        {
            get { return method.Syntax; }
            set { method.Syntax = value; }
        }

        public override AbstractMemberVisibilityModifier Visibility
        {
            get { return method.Visibility; }
            set { method.Visibility = value; }
        }
    }
}
