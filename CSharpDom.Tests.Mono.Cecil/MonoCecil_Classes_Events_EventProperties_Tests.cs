using CSharpDom.TestTarget.Classes.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_Events_EventProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithEventPropertyWith1AccessorAttributeUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithInternalEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithNewEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestClassWithNewStaticEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNewStaticEventProperty));
        }

        //[TestMethod]
        //public void TestClassWithNewVirtualEventPropertyUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithNewVirtualEventProperty));
        //}

        [TestMethod]
        public void TestClassWithOverrideEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestClassWithPrivateEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestClassWithProtectedEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithPublicEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestClassWithSealedOverrideEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestClassWithStaticEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestClassWithVirtualEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithVirtualEventProperty));
        }
    }
}
