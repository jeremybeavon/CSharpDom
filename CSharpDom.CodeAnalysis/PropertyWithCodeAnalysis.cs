//using System.Collections.Generic;
//using CSharpDom.Common;
//using CSharpDom.Editable;
//using System.Reflection;
//using Microsoft.CodeAnalysis.CSharp.Syntax;

//namespace CSharpDom.CodeAnalysis
//{
//    public sealed class PropertyWithCodeAnalysis<TAccessor> :
//        EditableProperty<
//            AttributeGroupWithCodeAnalysis,
//            IClassType,
//            ITypeReferenceWithCodeAnalysis,
//            TAccessor>
//        where TAccessor : IAccessor
//    {
//        private readonly Node<PropertyWithCodeAnalysis<TAccessor>, PropertyDeclarationSyntax> node;
//        private readonly IClassType declaringType;
//        private readonly ClassAccessorWithCodeAnalysis getAccessor;
//        private readonly ClassAccessorWithCodeAnalysis setAccessor;

//        internal PropertyWithCodeAnalysis(IClassType declaringType)
//        {
//            node = new Node<PropertyWithCodeAnalysis<TAccessor>, PropertyDeclarationSyntax>(this);
//            property = new PropertyWithCodeAnalysis(declaringType, propertyInfo);
//            this.declaringType = declaringType;
//            if (property.GetAccessor != null)
//            {
//                getAccessor = new ClassAccessorWithCodeAnalysis(this, property.GetAccessor);
//            }

//            if (property.SetAccessor != null)
//            {
//                setAccessor = new ClassAccessorWithCodeAnalysis(this, property.SetAccessor);
//            }
//        }

//        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
//        {
//            get { return property.Attributes; }
//        }

//        public override IClassType DeclaringType
//        {
//            get { return property.DeclaringType; }
//        }

//        public override ClassAccessorWithCodeAnalysis GetAccessor
//        {
//            get { return getAccessor; }
//        }

//        public override ClassMemberInheritanceModifier InheritanceModifier
//        {
//            get { return property.PropertyDefinition.InheritanceModifier(declaringType); }
//        }

//        public override string Name
//        {
//            get { return property.Name; }
//        }

//        public override ITypeReferenceWithCodeAnalysis PropertyType
//        {
//            get { return property.PropertyType; }
//        }

//        public override ClassAccessorWithCodeAnalysis SetAccessor
//        {
//            get { return setAccessor; }
//        }

//        public override ClassMemberVisibilityModifier Visibility
//        {
//            get { return property.PropertyDefinition.ClassVisibility(); }
//        }
//    }
//}
