using CSharpDom.BaseClasses;
using CSharpDom.NotSupported;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class ConversionOperatorWithReflection :
        AbstractConversionOperator<
            AttributeWithReflection,
            ITypeWithReflection,
            ITypeReferenceWithReflection,
            OperatorParameterWithReflection,
            ILMethodBodyWithReflectionEmit>,
        IHasMethodInfo//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly ITypeWithReflection declaringType;
        private readonly MethodInfo method;
        private readonly Lazy<Attributes> attributes;
        private readonly OperatorParameterWithReflection parameter;
        private readonly ITypeReferenceWithReflection returnType;
        private readonly Lazy<Attributes> returnAttributes;
        private readonly Lazy<ILMethodBodyWithReflectionEmit> body;

        internal ConversionOperatorWithReflection(ITypeWithReflection declaringType, MethodInfo method)
        {
            this.declaringType = declaringType;
            this.method = method;
            attributes = new Lazy<Attributes>(() => new Attributes(method));
            parameter = new OperatorParameterWithReflection(new ParameterWithReflection(method.GetParameters()[0]));
            returnType = TypeReferenceWithReflectionFactory.CreateReference(method.ReturnType);
            returnAttributes = new Lazy<Attributes>(() => new Attributes(method.ReturnParameter));
            body = new Lazy<ILMethodBodyWithReflectionEmit>(() => new ILMethodBodyWithReflectionEmit(method));
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }

        public override ITypeWithReflection DeclaringType
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

        public override OperatorParameterWithReflection Parameter
        {
            get { return parameter; }
        }
        
        public override IReadOnlyCollection<AttributeWithReflection> ReturnAttributes
        {
            get { return returnAttributes.Value.AttributesWithReflection; }
        }

        public override ITypeReferenceWithReflection ReturnType
        {
            get { return returnType; }
        }

        public MethodInfo MethodInfo
        {
            get { return method; }
        }

        public override ILMethodBodyWithReflectionEmit Body
        {
            get { return body.Value; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitConversionOperatorWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
