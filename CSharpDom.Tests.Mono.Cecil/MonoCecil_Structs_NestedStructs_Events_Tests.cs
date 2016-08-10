using CSharpDom.TestTarget.Structs.NestedStructs.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedStructs_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedStructWithEventWith1AttributeUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithEventWithGenericDelegateUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithInternalEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithInternalEvent));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPrivateEvent));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPublicEvent));
        }
    }
}
