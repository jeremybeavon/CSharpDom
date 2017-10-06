using CSharpDom.BaseClasses.Editable;
using System;
using System.Collections.Generic;
using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class AbstractPartialClassDestructorWithCodeAnalysis :
        EditableDestructor<AttributeGroupWithCodeAnalysis, IAbstractPartialTypeWithCodeAnalysis, MethodBodyWithCodeAnalysis>,
        IHasSyntax<DestructorDeclarationSyntax>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly AbstractClassDestructorWithCodeAnalysis destructor;

        public AbstractPartialClassDestructorWithCodeAnalysis(
            string name,
            MethodBodyWithCodeAnalysis body)
            : this(new AbstractClassDestructorWithCodeAnalysis(name, body))
        {
        }
        
        internal AbstractPartialClassDestructorWithCodeAnalysis(AbstractClassDestructorWithCodeAnalysis destructor)
        {
            this.destructor = destructor;
            destructor.DeclaringTypeFunc = () => DeclaringType.Class;
        }

        public AbstractClassDestructorWithCodeAnalysis Destructor
        {
            get { return destructor; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return destructor.Attributes; }
            set { destructor.Attributes = value; }
        }

        public override MethodBodyWithCodeAnalysis Body
        {
            get { return destructor.Body; }
            set { destructor.Body = value; }
        }

        public override IAbstractPartialTypeWithCodeAnalysis DeclaringType
        {
            get { return destructor.Destructor.Destructor.Node.GetParentNode<IAbstractPartialTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }
        
        public DestructorDeclarationSyntax Syntax
        {
            get { return destructor.Syntax; }
            set { destructor.Syntax = value; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitDestructorWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
