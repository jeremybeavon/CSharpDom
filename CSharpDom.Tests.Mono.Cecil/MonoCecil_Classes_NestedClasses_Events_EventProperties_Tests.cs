using CSharpDom.TestTarget.Classes.NestedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedClasses_Events_EventProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedClassWithEventPropertyWith1AccessorAttributeUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithInternalEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewStaticEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewStaticEventProperty));
        }

        //[TestMethod]
        //public void TestClassWithNestedClassWithNewVirtualEventPropertyUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithNestedClassWithNewVirtualEventProperty));
        //}

        [TestMethod]
        public void TestClassWithNestedClassWithOverrideEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPublicEventProperty));
        }

        //[TestMethod]
        //public void TestClassWithNestedClassWithSealedOverrideEventPropertyUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideEventProperty));
        //}

        [TestMethod]
        public void TestClassWithNestedClassWithStaticEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithVirtualEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithVirtualEventProperty));
        }
    }
}
