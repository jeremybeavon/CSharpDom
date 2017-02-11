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
            TestClass(typeof(ClassWithNestedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithInternalEventPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewEventPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewStaticEventPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithNewStaticEventProperty));
        }

        //[TestMethod]
        //public void TestClassWithNestedClassWithNewVirtualEventPropertyUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithNestedClassWithNewVirtualEventProperty));
        //}

        [TestMethod]
        public void TestClassWithNestedClassWithOverrideEventPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateEventPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedEventPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalEventPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicEventPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithPublicEventProperty));
        }

        //[TestMethod]
        //public void TestClassWithNestedClassWithSealedOverrideEventPropertyUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideEventProperty));
        //}

        [TestMethod]
        public void TestClassWithNestedClassWithStaticEventPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithVirtualEventPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithVirtualEventProperty));
        }
    }
}
