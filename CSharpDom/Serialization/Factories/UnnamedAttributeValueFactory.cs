using CSharpDom.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Serialization.Factories
{
    public sealed class UnnamedAttributeValueFactory : AbstractFactory<IUnnamedAttributeValue, UnnamedAttributeValue>
    {
        public UnnamedAttributeValueFactory(IUnnamedAttributeValue unnamedAttributeValue)
            : base(unnamedAttributeValue)
        {
        }

        public override void VisitUnnamedAttributeValue(IUnnamedAttributeValue unnamedAttributeValue)
        {
            Value = new UnnamedAttributeValue()
            {
                RawValue = unnamedAttributeValue.RawValue
            };
        }
    }
}
