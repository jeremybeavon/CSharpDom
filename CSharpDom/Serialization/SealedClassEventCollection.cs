﻿using CSharpDom.Common;
using System.Collections.Generic;
using System;
using System.Collections;

namespace CSharpDom.Serialization
{
    public sealed class SealedClassEventCollection :
        ISealedClassEventCollection<SealedClassEvent, ClassEventProperty, ProtectedOverrideEvent, ExplicitInterfaceEvent>
    {
        public SealedClassEventCollection()
        {
            ProtectedOverrideEvents = new List<ProtectedOverrideEvent>();
            Events = new List<SealedClassEvent>();
            EventProperties = new List<ClassEventProperty>();
            ExplicitInterfaceEvents = new List<ExplicitInterfaceEvent>();
        }

        public List<ProtectedOverrideEvent> ProtectedOverrideEvents { get; set; }

        public List<SealedClassEvent> Events { get; set; }

        public List<ClassEventProperty> EventProperties { get; set; }

        public List<ExplicitInterfaceEvent> ExplicitInterfaceEvents { get; set; }

        public int Count
        {
            get { return ProtectedOverrideEvents.Count + Events.Count + EventProperties.Count + ExplicitInterfaceEvents.Count; }
        }

        IReadOnlyCollection<ClassEventProperty> IHasEventProperties<ClassEventProperty>.EventProperties
        {
            get { return EventProperties; }
        }

        IReadOnlyCollection<ProtectedOverrideEvent> IHasProtectedOverrideEvents<ProtectedOverrideEvent>.ProtectedOverrideEvents
        {
            get { return ProtectedOverrideEvents; }
        }

        IReadOnlyCollection<ExplicitInterfaceEvent> IHasExplicitInterfaceEvents<ExplicitInterfaceEvent>.ExplicitInterfaceEvents
        {
            get { return ExplicitInterfaceEvents; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitSealedClassEventCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitSealedClassEventCollectionChildren(this, visitor);
        }

        public IEnumerator<SealedClassEvent> GetEnumerator()
        {
            return Events.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}