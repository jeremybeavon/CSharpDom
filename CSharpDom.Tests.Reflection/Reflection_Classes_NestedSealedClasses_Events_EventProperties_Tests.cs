using CSharpDom.TestTarget.Classes.NestedSealedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedSealedClasses_Events_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedSealedClassWithEventPropertyWith1AccessorAttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithEventPropertyWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithInternalEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewStaticEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithOverrideEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPrivateEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedInternalEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPublicEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithSealedOverrideEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithStaticEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticEventProperty));
        }
    }
}
