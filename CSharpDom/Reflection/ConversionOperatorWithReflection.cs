using CSharpDom.BaseClasses;
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
            ParameterWithReflection>,
        IHasMethodInfo,
        IVisitable<IReflectionVisitor>
    {
        private readonly ITypeWithReflection declaringType;
        private readonly MethodInfo method;
        private readonly Lazy<Attributes> attributes;
        private readonly ParameterWithReflection parameter;
        private readonly ITypeReferenceWithReflection returnType;

        internal ConversionOperatorWithReflection(ITypeWithReflection declaringType, MethodInfo method)
        {
            this.declaringType = declaringType;
            this.method = method;
            attributes = new Lazy<Attributes>(() => new Attributes(method));
            parameter = new ParameterWithReflection(method.GetParameters()[0]);
            returnType = TypeReferenceWithReflectionFactory.CreateReference(method.ReturnType);
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

        public override ParameterWithReflection Parameter
        {
            get { return parameter; }
        }
        
        public override IReadOnlyCollection<AttributeWithReflection> ReturnAttributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override ITypeReferenceWithReflection ReturnType
        {
            get { return returnType; }
        }

        public MethodInfo MethodInfo
        {
            get { return method; }
        }


        public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitConversionOperatorWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }
    }
}
