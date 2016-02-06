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
    public sealed class ReadOnlyClassConstructor :
        AbstractClassConstructor<AttributeGroupNotSupported, IClassType, ReadOnlyMethodParameter, ReadOnlyMethodBody>
    {
        private readonly IClassType declaringType;
        private readonly ClassConstructor constructor;
        private readonly ReadOnlyMethodBody body;
        private readonly IReadOnlyList<ReadOnlyMethodParameter> parameters;

        public ReadOnlyClassConstructor(IClassType declaringType, ClassConstructor constructor)
        {
            this.declaringType = declaringType;
            this.constructor = constructor;
            body = new ReadOnlyMethodBody(constructor.Statements);
            parameters = constructor.Parameters.ToArray(parameter => new ReadOnlyMethodParameter(parameter));
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override ReadOnlyMethodBody Body
        {
            get { return body; }
        }

        public override IClassType DeclaringType
        {
            get { return declaringType; }
        }

        public override IReadOnlyList<ReadOnlyMethodParameter> Parameters
        {
            get { return parameters; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return constructor.Visibility; }
        }
    }
}
