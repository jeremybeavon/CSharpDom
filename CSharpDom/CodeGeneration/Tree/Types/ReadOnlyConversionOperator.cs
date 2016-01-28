using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyConversionOperator :
        AbstractConversionOperator<
            AttributeGroupNotSupported,
            IType,
            ReadOnlyTypeReference,
            ReadOnlyOperatorParameter,
            ReadOnlyMethodBody>
    {
        private readonly ConversionOperator conversionOperator;
        private readonly ReadOnlyMethodBody body;
        private readonly ReadOnlyOperatorParameter parameter;
        private readonly ReadOnlyTypeReference returnType;

        public ReadOnlyConversionOperator(ConversionOperator conversionOperator)
        {
            this.conversionOperator = conversionOperator;
            body = new ReadOnlyMethodBody(conversionOperator.Body);
            parameter = new ReadOnlyOperatorParameter(conversionOperator.ParameterName, conversionOperator.ParameterType);
            returnType = new ReadOnlyTypeReference(conversionOperator.ReturnType);
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

        public override ConversionOperatorType OperatorType
        {
            get { return conversionOperator.OperatorType; }
        }

        public override ReadOnlyOperatorParameter Parameter
        {
            get { return parameter; }
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> ReturnAttributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override ReadOnlyTypeReference ReturnType
        {
            get { return returnType; }
        }
    }
}
