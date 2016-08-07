using CSharpDom.BaseClasses;
using CSharpDom.NotSupported;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;
using System;
using System.Collections.Generic;
using System.Reflection;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public sealed class ConversionOperatorWithMonoCecil :
        AbstractConversionOperator<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            ITypeReferenceWithMonoCecil,
            OperatorParameterWithMonoCecil,
            ILMethodBodyWithMonoCecilCil>,
        IHasMethodDefinition//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly ITypeWithMonoCecil declaringType;
        private readonly MethodDefinition method;
        private readonly Lazy<Attributes> attributes;
        private readonly OperatorParameterWithMonoCecil parameter;
        private readonly ITypeReferenceWithMonoCecil returnType;
        private readonly Lazy<Attributes> returnAttributes;
        private readonly Lazy<ILMethodBodyWithMonoCecilCil> body;

        internal ConversionOperatorWithMonoCecil(ITypeWithMonoCecil declaringType, MethodDefinition method)
        {
            this.declaringType = declaringType;
            this.method = method;
            AssemblyWithMonoCecil assembly = declaringType.Assembly;
            attributes = new Lazy<Attributes>(() => new Attributes(assembly, method));
            parameter = new OperatorParameterWithMonoCecil(new ParameterWithMonoCecil(assembly, method.Parameters[0], method));
            returnType = TypeReferenceWithMonoCecilFactory.CreateReference(declaringType.Assembly, method.ReturnType, method);
            returnAttributes = new Lazy<Attributes>(() => new Attributes(assembly, method.MethodReturnType));
            body = new Lazy<ILMethodBodyWithMonoCecilCil>(() => new ILMethodBodyWithMonoCecilCil(method));
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return attributes.Value.AttributesWithMonoCecil; }
        }

        public override ITypeWithMonoCecil DeclaringType
        {
            get { return declaringType; }
        }

        public override ConversionOperatorType OperatorType
        {
            get
            {
                switch (method.Name)
                {
                    case "op_Implicit":
                        return ConversionOperatorType.Implicit;
                    case "op_Explicit":
                        return ConversionOperatorType.Explicit;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public override OperatorParameterWithMonoCecil Parameter
        {
            get { return parameter; }
        }
        
        public override IReadOnlyCollection<AttributeWithMonoCecil> ReturnAttributes
        {
            get { return returnAttributes.Value.AttributesWithMonoCecil; }
        }

        public override ITypeReferenceWithMonoCecil ReturnType
        {
            get { return returnType; }
        }

        public MethodDefinition MethodDefinition
        {
            get { return method; }
        }

        public override ILMethodBodyWithMonoCecilCil Body
        {
            get { return body.Value; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitConversionOperatorWithMonoCecil(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
