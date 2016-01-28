using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System.Collections.Generic;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyUnaryOperator :
        AbstractOperatorOverload<
            AttributeGroupNotSupported,
            IType,
            ReadOnlyTypeReference,
            ReadOnlyOperatorParameter,
            ReadOnlyMethodBody>
    {
        private static readonly IDictionary<UnaryOperatorType, OperatorOverloadType> operatorTypes =
            new Dictionary<UnaryOperatorType, OperatorOverloadType>()
            {
                { UnaryOperatorType.BitwiseNot, OperatorOverloadType.BitwiseNot },
                { UnaryOperatorType.Decrement, OperatorOverloadType.Decrement },
                { UnaryOperatorType.False, OperatorOverloadType.False },
                { UnaryOperatorType.Increment, OperatorOverloadType.Increment },
                { UnaryOperatorType.LogicalNot, OperatorOverloadType.LogicalNot },
                { UnaryOperatorType.Minus, OperatorOverloadType.Minus },
                { UnaryOperatorType.Plus, OperatorOverloadType.Plus },
                { UnaryOperatorType.True, OperatorOverloadType.True }
            };

        private readonly UnaryOperator unaryOperator;
        private readonly ReadOnlyMethodBody body;
        private readonly IReadOnlyList<ReadOnlyOperatorParameter> parameters;
        private readonly ReadOnlyTypeReference returnType;

        public ReadOnlyUnaryOperator(UnaryOperator unaryOperator)
        {
            this.unaryOperator = unaryOperator;
            body = new ReadOnlyMethodBody(unaryOperator.Body);
            parameters = new ReadOnlyOperatorParameter[]
            {
                new ReadOnlyOperatorParameter(unaryOperator.ParameterName, unaryOperator.ParameterType)
            };
            returnType = new ReadOnlyTypeReference(unaryOperator.ReturnType);
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override ReadOnlyMethodBody Body
        {
            get { return body; }
        }

        public override IType DeclaringType
        {
            get { return null; }
        }

        public override OperatorOverloadType OperatorType
        {
            get { return operatorTypes[unaryOperator.OperatorType]; }
        }

        public override IReadOnlyList<ReadOnlyOperatorParameter> Parameters
        {
            get { return parameters; }
        }

        public override ReadOnlyTypeReference ReturnType
        {
            get { return returnType; }
        }
    }
}