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
            TestClass(typeof(ClassWithNestedSealedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithEventPropertyWith1AttributeUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithInternalEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewStaticEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithOverrideEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPrivateEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedInternalEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPublicEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithSealedOverrideEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithStaticEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithStaticEventProperty));
        }
    }
}
