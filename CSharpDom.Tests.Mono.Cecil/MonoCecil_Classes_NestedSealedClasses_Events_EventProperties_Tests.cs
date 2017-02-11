using CSharpDom.TestTarget.Classes.NestedSealedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedSealedClasses_Events_EventProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedSealedClassWithEventPropertyWith1AccessorAttributeUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithInternalEventPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewEventPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewStaticEventPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithOverrideEventPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPrivateEventPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedEventPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedInternalEventPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPublicEventPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithSealedOverrideEventPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithStaticEventPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithStaticEventProperty));
        }
    }
}
