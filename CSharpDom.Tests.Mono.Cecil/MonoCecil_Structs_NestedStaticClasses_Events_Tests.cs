using CSharpDom.TestTarget.Structs.NestedStaticClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedStaticClasses_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedStaticClassWithEventWith1AttributeUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithInternalEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithInternalEvent));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPrivateEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPublicEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithPublicEvent));
        }
    }
}
