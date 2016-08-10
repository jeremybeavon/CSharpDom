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
            TestClassAsync(typeof(ClassWithNestedSealedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithInternalEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewStaticEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithOverrideEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPrivateEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedInternalEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPublicEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithSealedOverrideEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithStaticEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticEventProperty));
        }
    }
}
