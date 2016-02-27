using CSharpDom.BaseClasses;
using CSharpDom.NotSupported;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Mono.Cecil
{
    public sealed class ConversionOperatorWithMonoCecil :
        AbstractConversionOperator<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            ITypeReferenceWithMonoCecil,
            OperatorParameterWithMonoCecil,
            ILMethodBodyWithMonoCecilEmit>,
        IHasMethodInfo//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly ITypeWithMonoCecil declaringType;
        private readonly MethodInfo method;
        private readonly Lazy<Attributes> attributes;
        private readonly OperatorParameterWithMonoCecil parameter;
        private readonly ITypeReferenceWithMonoCecil returnType;
        private readonly Lazy<Attributes> returnAttributes;
        private readonly Lazy<ILMethodBodyWithMonoCecilEmit> body;

        internal ConversionOperatorWithMonoCecil(ITypeWithMonoCecil declaringType, MethodInfo method)
        {
            this.declaringType = declaringType;
            this.method = method;
            attributes = new Lazy<Attributes>(() => new Attributes(method));
            parameter = new OperatorParameterWithMonoCecil(new ParameterWithMonoCecil(method.GetParameters()[0]));
            returnType = TypeReferenceWithMonoCecilFactory.CreateReference(method.ReturnType);
            returnAttributes = new Lazy<Attributes>(() => new Attributes(method.ReturnParameter));
            body = new Lazy<ILMethodBodyWithMonoCecilEmit>(() => new ILMethodBodyWithMonoCecilEmit(method));
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

        public MethodInfo MethodInfo
        {
            get { return method; }
        }

        public override ILMethodBodyWithMonoCecilEmit Body
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
