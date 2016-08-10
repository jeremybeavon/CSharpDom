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
            TestClassAsync(typeof(ClassWithNestedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithEventPropertyWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithInternalEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewStaticEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewVirtualEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithOverrideEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithSealedOverrideEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithStaticEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithVirtualEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithVirtualEventProperty));
        }
    }
}
