using CSharpDom.TestTarget.Structs.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithInternalEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithInternalEvent));
        }

        [TestMethod]
        public void TestStructWithPrivateEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithPrivateEvent));
        }

        [TestMethod]
        public void TestStructWithPublicEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithPublicEvent));
        }

        [TestMethod]
        public void TestStructWithStaticEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithStaticEvent));
        }
    }
}
