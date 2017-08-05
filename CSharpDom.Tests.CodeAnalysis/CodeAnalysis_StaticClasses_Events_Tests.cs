using CSharpDom.TestTarget.StaticClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStaticClassWithEventWith1AttributeUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStaticClassWithInternalEventUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithPrivateEventUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithPublicEventUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPublicEvent));
        }
    }
}
