using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using CSharpDom.Linq.Expressions;
using CSharpDom.NotSupported;
using System.Collections.Generic;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyClassAutoProperty :
        AbstractClassAutoProperty<
            AttributeGroupNotSupported,
            IClassType,
            ReadOnlyTypeReference,
            ReadOnlyClassAccessor,
            IExpression>
    {
        private readonly ClassAutoProperty property;
        private readonly ReadOnlyClassAccessor getAccessor;
        private readonly ReadOnlyTypeReference propertyType;
        private readonly ReadOnlyClassAccessor setAccessor;
        private readonly IExpression initialValue;

        public ReadOnlyClassAutoProperty(ClassAutoProperty property)
        {
            this.property = property;
            propertyType = new ReadOnlyTypeReference(property.Type);
            if (property.EmptyAccessors != null)
            {
                getAccessor = new ReadOnlyClassAccessor(property.EmptyAccessors.GetAccessorVisibility);
                setAccessor = new ReadOnlyClassAccessor(property.EmptyAccessors.SetAccessorVisibility);
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

        public override IClassType DeclaringType
        {
            get { return null; }
        }

        public override ReadOnlyClassAccessor GetAccessor
        {
            get { return getAccessor; }
        }

        public override ClassMemberInheritanceModifier InheritanceModifier
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

        public override ReadOnlyClassAccessor SetAccessor
        {
            get { return setAccessor; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return property.Visibility; }
        }
    }
}
