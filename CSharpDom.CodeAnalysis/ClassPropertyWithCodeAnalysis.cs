﻿//using System.Collections.Generic;
//using CSharpDom.Common;
//using CSharpDom.Editable;
//using System.Reflection;
//using Microsoft.CodeAnalysis.CSharp.Syntax;

//namespace CSharpDom.CodeAnalysis
//{
//    public sealed class ClassPropertyWithCodeAnalysis :
//        EditableClassProperty<
//            AttributeGroupWithCodeAnalysis,
//            IClassType,
//            ITypeReferenceWithCodeAnalysis,
//            ClassAccessorWithCodeAnalysis>
//    {
//        private readonly Node<PropertyDeclarationSyntax> node;
//        private readonly IClassType declaringType;
//        private readonly ClassAccessorWithCodeAnalysis getAccessor;
//        private readonly ClassAccessorWithCodeAnalysis setAccessor;

//        internal ClassPropertyWithCodeAnalysis(IClassType declaringType)
//        {
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

//        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
//        {
//            get { return property.Attributes; }
//        }

//        public override ITypeWithCodeAnalysis DeclaringType
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
