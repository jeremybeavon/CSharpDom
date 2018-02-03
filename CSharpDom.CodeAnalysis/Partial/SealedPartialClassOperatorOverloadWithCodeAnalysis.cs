using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class SealedPartialClassOperatorOverloadWithCodeAnalysis :
        EditableOperatorOverload<
            AttributeGroupWithCodeAnalysis,
            ISealedPartialTypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            OperatorParameterWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>,
        IHasSyntax<OperatorDeclarationSyntax>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly SealedClassOperatorOverloadWithCodeAnalysis operatorOverload;

        public SealedPartialClassOperatorOverloadWithCodeAnalysis(
            ClassMemberVisibilityModifier visibility,
            ITypeReferenceWithCodeAnalysis returnType,
            OperatorOverloadType operatorType,
            IEnumerable<OperatorParameterWithCodeAnalysis> parameters,
            MethodBodyWithCodeAnalysis body)
            : this(new SealedClassOperatorOverloadWithCodeAnalysis(visibility, returnType, operatorType, parameters, body))
        {
        }

        internal SealedPartialClassOperatorOverloadWithCodeAnalysis(
            SealedClassOperatorOverloadWithCodeAnalysis operatorOverload)
        {
            this.operatorOverload = operatorOverload;
        }

        public SealedClassOperatorOverloadWithCodeAnalysis OperatorOverload
        {
            get { return operatorOverload; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return operatorOverload.Attributes; }
            set { operatorOverload.Attributes = value; }
        }

        public override MethodBodyWithCodeAnalysis Body
        {
            get { return operatorOverload.Body; }
            set { operatorOverload.Body = value; }
        }

        public override ISealedPartialTypeWithCodeAnalysis DeclaringType
        {
            get { return operatorOverload.OperatorOverload.OperatorOverload.Node.GetParent<ISealedPartialTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override OperatorOverloadType OperatorType
        {
            get { return operatorOverload.OperatorType; }
            set { operatorOverload.OperatorType = value; }
        }

        public override IList<OperatorParameterWithCodeAnalysis> Parameters
        {
            get { return operatorOverload.Parameters; }
            set { operatorOverload.Parameters = value; }
        }

        public override ITypeReferenceWithCodeAnalysis ReturnType
        {
            get { return operatorOverload.ReturnType; }
            set { operatorOverload.ReturnType = value; }
        }
        
        public OperatorDeclarationSyntax Syntax
        {
            get { return operatorOverload.Syntax; }
            set { operatorOverload.Syntax = value; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitOperatorOverloadWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
