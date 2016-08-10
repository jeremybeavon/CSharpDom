using CSharpDom.TestTarget.Classes.NestedStaticClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedStaticClasses_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedStaticClassWithEventWith1AttributeUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithInternalEventUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPrivateEventUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPublicEventUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithPublicEvent));
        }
    }
}
