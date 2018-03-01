using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using CSharpDom.Linq.Expressions;
using CSharpDom.NotSupported;
using System.Collections.Generic;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyStructAutoProperty :
        AbstractStructAutoProperty<
            AttributeGroupNotSupported,
            IStructType,
            ReadOnlyTypeReference,
            ReadOnlyStructAccessor,
            IExpression>
    {
        private readonly StructAutoProperty property;
        private readonly ReadOnlyStructAccessor getAccessor;
        private readonly ReadOnlyTypeReference propertyType;
        private readonly ReadOnlyStructAccessor setAccessor;
        private readonly IExpression initialValue;

        public ReadOnlyStructAutoProperty(StructAutoProperty property)
        {
            this.property = property;
            propertyType = new ReadOnlyTypeReference(property.Type);
            if (property.EmptyAccessors != null)
            {
                getAccessor = new ReadOnlyStructAccessor(property.EmptyAccessors.GetAccessorVisibility);
                setAccessor = new ReadOnlyStructAccessor(property.EmptyAccessors.SetAccessorVisibility);
            }
            
            if (property.InitialValue != null)
            {
                initialValue = LinqExpressionBuilder.BuildExpression(property.InitialValue);
            }
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override IStructType DeclaringType
        {
            get { return null; }
        }

        public override ReadOnlyStructAccessor GetAccessor
        {
            get { return getAccessor; }
        }

        public override StructMemberInheritanceModifier InheritanceModifier
        {
            get { return property.InheritanceModifier; }
        }

        public override IExpression InitialValue => initialValue;

        public override string Name
        {
            get { return property.Name; }
        }

        public override ReadOnlyTypeReference PropertyType
        {
            get { return propertyType; }
        }

        public override ReadOnlyStructAccessor SetAccessor
        {
            get { return setAccessor; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get { return property.Visibility; }
        }
    }
}
