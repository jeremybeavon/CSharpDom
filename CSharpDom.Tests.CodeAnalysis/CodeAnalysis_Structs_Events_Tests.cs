using CSharpDom.TestTarget.Structs.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithInternalEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithInternalEvent));
        }

        [TestMethod]
        public async Task TestStructWithPrivateEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestStructWithPublicEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithPublicEvent));
        }

        [TestMethod]
        public async Task TestStructWithStaticEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithStaticEvent));
        }
    }
}
