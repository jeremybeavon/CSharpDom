using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedAbstractClasses_Events_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedAbstractClassWithEventPropertyWith1AccessorAttributeUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithEventPropertyWith1AttributeUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithInternalEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewStaticEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewVirtualEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithOverrideEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPrivateEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedInternalEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPublicEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithSealedOverrideEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithStaticEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithVirtualEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithVirtualEventProperty));
        }
    }
}
