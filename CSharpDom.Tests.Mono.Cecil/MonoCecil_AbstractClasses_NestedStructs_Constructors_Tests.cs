using CSharpDom.TestTarget.AbstractClasses.NestedStructs.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedStructs_Constructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        public MonoCecil_AbstractClasses_NestedStructs_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithConstructorWith1AttributeUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithConstructorWith1ParameterUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithConstructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithConstructorWith2ParametersUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithInternalConstructorUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithInternalConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithConstructorWithParametersWithAttributesUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithConstructorWithParametersWithModifiersUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithPrivateConstructorUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPrivateConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithPublicConstructorUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPublicConstructor));
        }
    }
}
