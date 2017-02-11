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
            TestClass(typeof(ClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            TestClass(typeof(ClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            TestClass(typeof(ClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithInternalEventPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithNewEventPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestClassWithNewStaticEventPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNewStaticEventProperty));
        }

        //[TestMethod]
        //public void TestClassWithNewVirtualEventPropertyUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithNewVirtualEventProperty));
        //}

        [TestMethod]
        public void TestClassWithOverrideEventPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestClassWithPrivateEventPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestClassWithProtectedEventPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalEventPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithPublicEventPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithPublicEventProperty));
        }

        //[TestMethod]
        //public void TestClassWithSealedOverrideEventPropertyUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithSealedOverrideEventProperty));
        //}

        [TestMethod]
        public void TestClassWithStaticEventPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestClassWithVirtualEventPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithVirtualEventProperty));
        }
    }
}
