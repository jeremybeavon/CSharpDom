//using System;
//using System.Collections.Generic;
//using CSharpDom.BaseClasses;
//using CSharpDom.CodeAnalysis.Internal;
//using System.Reflection;
//using Microsoft.CodeAnalysis.CSharp.Syntax;

//namespace CSharpDom.CodeAnalysis
//{
//    public sealed class SealedClassEventPropertyWithCodeAnalysis :
//        AbstractSealedClassEventProperty<
//            AttributeGroupWithCodeAnalysis,
//            ITypeWithCodeAnalysis,
//            DelegateReferenceWithCodeAnalysis,
//            MethodBodyWithCodeAnalysis>
//    {
//        private readonly EventPropertyWithCodeAnalysis @event;
//        private readonly IInternalTypeWithCodeAnalysis declaringType;

//        internal SealedClassEventPropertyWithCodeAnalysis(IInternalTypeWithCodeAnalysis declaringType, EventDefinition @event)
//        {
//            this.@event = new EventPropertyWithCodeAnalysis(declaringType, @event);
//            this.declaringType = declaringType;
//        }

//        public override MethodBodyWithCodeAnalysis AddBody
//        {
//            get { return @event.AddBody; }
//        }

//        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
//        {
//            get { return @event.Attributes; }
//        }

//        public override ITypeWithCodeAnalysis DeclaringType
//        {
//            get { return @event.DeclaringType; }
//        }

//        public override DelegateReferenceWithCodeAnalysis EventType
//        {
//            get { return @event.EventType; }
//        }

//        public override SealedClassMemberInheritanceModifier InheritanceModifier
//        {
//            get { return @event.EventDefinition.SealedClassInheritanceModifier(declaringType); }
//        }

//        public override string Name
//        {
//            get { return @event.Name; }
//        }

//        public override MethodBodyWithCodeAnalysis RemoveBody
//        {
//            get { return @event.RemoveBody; }
//        }

//        public override ClassMemberVisibilityModifier Visibility
//        {
//            get { return @event.EventDefinition.AddMethod.ClassVisibility(); }
//        }

//        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> AddAttributes
//        {
//            get { return @event.AddAttributes; }
//        }

//        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> RemoveAttributes
//        {
//            get { return @event.RemoveAttributes; }
//        }
//    }
//}
