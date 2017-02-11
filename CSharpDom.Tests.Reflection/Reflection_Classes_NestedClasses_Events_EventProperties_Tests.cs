using CSharpDom.TestTarget.Classes.NestedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedClasses_Events_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedClassWithEventPropertyWith1AccessorAttributeUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithEventPropertyWith1AttributeUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithInternalEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewStaticEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewVirtualEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithOverrideEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithSealedOverrideEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithStaticEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithVirtualEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithVirtualEventProperty));
        }
    }
}
