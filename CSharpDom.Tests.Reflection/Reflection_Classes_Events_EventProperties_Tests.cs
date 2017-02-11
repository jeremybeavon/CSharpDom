using CSharpDom.TestTarget.Classes.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_Events_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithEventPropertyWith1AccessorAttributeUsingReflection()
        {
            TestClass(typeof(ClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithEventPropertyWith1AttributeUsingReflection()
        {
            TestClass(typeof(ClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            TestClass(typeof(ClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithInternalEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithNewEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestClassWithNewStaticEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestClassWithNewVirtualEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public void TestClassWithOverrideEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestClassWithPrivateEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestClassWithProtectedEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithPublicEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestClassWithSealedOverrideEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestClassWithStaticEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestClassWithVirtualEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithVirtualEventProperty));
        }
    }
}
