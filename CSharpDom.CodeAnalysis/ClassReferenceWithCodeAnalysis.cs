using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using CSharpDom.Editable;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassReferenceWithCodeAnalysis :
        EditableClassReference<GenericParameterWithCodeAnalysis>,
        ITypeReferenceWithCodeAnalysis//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly IHasChild<;
        private readonly Lazy<GenericParameters> genericParameters;

        internal ClassReferenceWithCodeAnalysis(AssemblyWithCodeAnalysis assembly, TypeReference type)
        {
            this.type = type;
            genericParameters = new Lazy<GenericParameters>(() => new GenericParameters(assembly, type));
        }

        public override IReadOnlyList<GenericParameterWithCodeAnalysis> GenericParameters
        {
            get { return genericParameters.Value.GenericParametersWithCodeAnalysis; }
        }

        public override string Name
        {
            get { return type.Name(); }
        }

        public TypeReference TypeReference
        {
            get { return type; }
        }


        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitClassReferenceWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
