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
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithConstructorWith1ParameterUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithConstructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithConstructorWith2ParametersUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithInternalConstructorUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithInternalConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithConstructorWithParametersWithAttributesUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithConstructorWithParametersWithModifiersUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithPrivateConstructorUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithPrivateConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithPublicConstructorUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithPublicConstructor));
        }
    }
}
