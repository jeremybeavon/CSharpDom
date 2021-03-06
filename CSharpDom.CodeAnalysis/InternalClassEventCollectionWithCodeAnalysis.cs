﻿using System;
using System.Collections.Generic;
using System.Linq;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalClassEventCollectionWithCodeAnalysis<TClass> : ClassEventCollectionWithCodeAnalysis
        where TClass : class, IHasNode<ClassDeclarationSyntax>
    {
        private readonly InternalClassTypeWithCodeAnalysis<TClass> classType;
        private readonly ClassEventPropertyListWrapper<TClass, ClassEventPropertyWithCodeAnalysis> eventProperties;
        private readonly ClassEventPropertyListWrapper<TClass, ExplicitInterfaceEventWithCodeAnalysis> explicitInterfaceEvents;
        private readonly ClassEventListWrapper<TClass, ClassEventWithCodeAnalysis> events;

        internal InternalClassEventCollectionWithCodeAnalysis(InternalClassTypeWithCodeAnalysis<TClass> classType)
        {
            this.classType = classType;
            eventProperties = new ClassEventPropertyListWrapper<TClass, ClassEventPropertyWithCodeAnalysis>(
                classType.InternalNode,
                () => new ClassEventPropertyWithCodeAnalysis(),
                syntax => syntax.ExplicitInterfaceSpecifier == null);
            explicitInterfaceEvents = new ClassEventPropertyListWrapper<TClass, ExplicitInterfaceEventWithCodeAnalysis>(
                classType.InternalNode,
                () => new ExplicitInterfaceEventWithCodeAnalysis(),
                syntax => syntax.ExplicitInterfaceSpecifier != null);
            events = new ClassEventListWrapper<TClass, ClassEventWithCodeAnalysis>(
                classType.InternalNode,
                () => new ClassEventWithCodeAnalysis());
        }

        public override ICollection<ClassEventPropertyWithCodeAnalysis> EventProperties
        {
            get { return eventProperties; }
            set { classType.Members.CombineList(nameof(EventProperties), value.Select(item => item.Syntax)); }
        }

        public override ICollection<ExplicitInterfaceEventWithCodeAnalysis> ExplicitInterfaceEvents
        {
            get { return explicitInterfaceEvents; }
            set { classType.Members.CombineList(nameof(ExplicitInterfaceEvents), value.Select(item => item.Syntax)); }
        }
        
        public override ICollection<ClassEventWithCodeAnalysis> Events
        {
            get { return events; }
            set { classType.Members.CombineList(nameof(Events), value.Select(item => item.Syntax)); }
        }
    }
}
