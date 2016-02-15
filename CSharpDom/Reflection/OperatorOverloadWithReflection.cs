using CSharpDom.BaseClasses;
using CSharpDom.NotSupported;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class OperatorOverloadWithReflection :
        AbstractOperatorOverload<
            AttributeWithReflection,
            ITypeWithReflection,
            ITypeReferenceWithReflection,
            OperatorParameterWithReflection,
            ILMethodBodyWithReflectionEmit>//,
        //IVisitable<IReflectionVisitor>
    {
        private static readonly IDictionary<string, OperatorOverloadType> operatorTypes =
            new Dictionary<string, OperatorOverloadType>()
            {
                { "op_BitwiseAnd", OperatorOverloadType.And },
                { "op_OnesComplement", OperatorOverloadType.BitwiseNot },
                { "op_Decrement", OperatorOverloadType.Decrement },
                { "op_Division", OperatorOverloadType.Divide },
                { "op_Equality", OperatorOverloadType.Equal },
                { "op_ExclusiveOr", OperatorOverloadType.ExclusiveOr },
                { "op_False", OperatorOverloadType.False },
                { "op_GreaterThan", OperatorOverloadType.GreaterThan },
                { "op_GreaterThanOrEqual", OperatorOverloadType.GreaterThanOrEqual },
                { "op_Increment", OperatorOverloadType.Increment },
                { "op_LeftShift", OperatorOverloadType.LeftShift },
                { "op_LessThan", OperatorOverloadType.LessThan },
                { "op_LessThanOrEqual", OperatorOverloadType.LessThanOrEqual },
                { "op_LogicalNot", OperatorOverloadType.LogicalNot },
                { "op_Subtraction", OperatorOverloadType.Minus },
                { "op_UnaryNegation", OperatorOverloadType.Minus },
                { "op_Modulus", OperatorOverloadType.Modulo },
                { "op_Multiply", OperatorOverloadType.Multiply },
                { "op_Inequality", OperatorOverloadType.NotEqual },
                { "op_BitwiseOr", OperatorOverloadType.Or },
                { "op_Addition", OperatorOverloadType.Plus },
                { "op_UnaryPlus", OperatorOverloadType.Plus },
                { "op_RightShift", OperatorOverloadType.RightShift },
                { "op_True", OperatorOverloadType.True }
            };
        private readonly ITypeWithReflection declaringType;
        private readonly MethodInfo method;
        private readonly Lazy<Attributes> attributes;
        private readonly ITypeReferenceWithReflection returnType;
        private readonly Lazy<Parameters<OperatorParameterWithReflection>> parameters;
        private readonly Lazy<ILMethodBodyWithReflectionEmit> body;

        internal OperatorOverloadWithReflection(ITypeWithReflection declaringType, MethodInfo method)
        {
            this.declaringType = declaringType;
            this.method = method;
            attributes = new Lazy<Attributes>(() => new Attributes(method));
            returnType = TypeReferenceWithReflectionFactory.CreateReference(method.ReturnType);
            parameters = new Lazy<Parameters<OperatorParameterWithReflection>>(
                () => new Parameters<OperatorParameterWithReflection>(method, parameter => new OperatorParameterWithReflection(parameter)));
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

        public override OperatorOverloadType OperatorType
        {
            get { return operatorTypes[method.Name]; }
        }

        public override IReadOnlyList<OperatorParameterWithReflection> Parameters
        {
            get { return parameters.Value.ParametersWithReflection; }
        }

        public override ITypeReferenceWithReflection ReturnType
        {
            get { return returnType; }
        }

        public override ILMethodBodyWithReflectionEmit Body
        {
            get { return body.Value; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitOperatorOverloadWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
