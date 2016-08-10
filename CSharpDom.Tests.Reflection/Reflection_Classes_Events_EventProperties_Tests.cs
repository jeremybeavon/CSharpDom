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
            TestClassAsync(typeof(ClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithEventPropertyWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            TestClassAsync(typeof(ClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithInternalEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithNewEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestClassWithNewStaticEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestClassWithNewVirtualEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public void TestClassWithOverrideEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestClassWithPrivateEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestClassWithProtectedEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithPublicEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestClassWithSealedOverrideEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestClassWithStaticEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestClassWithVirtualEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithVirtualEventProperty));
        }
    }
}
