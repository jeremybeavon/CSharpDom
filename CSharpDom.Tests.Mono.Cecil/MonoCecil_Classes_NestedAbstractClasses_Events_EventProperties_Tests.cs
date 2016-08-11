using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedAbstractClasses_Events_EventProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedAbstractClassWithEventPropertyWith1AccessorAttributeUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithInternalEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewStaticEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticEventProperty));
        }

        //[TestMethod]
        //public void TestClassWithNestedAbstractClassWithNewVirtualEventPropertyUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewVirtualEventProperty));
        //}

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithOverrideEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPrivateEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedInternalEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPublicEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicEventProperty));
        }

        //[TestMethod]
        //public void TestClassWithNestedAbstractClassWithSealedOverrideEventPropertyUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithNestedAbstractClassWithSealedOverrideEventProperty));
        //}

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithStaticEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithVirtualEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithVirtualEventProperty));
        }
    }
}
