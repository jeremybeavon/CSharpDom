using CSharpDom.TestTarget.AbstractClasses.NestedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedClasses_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        public Reflection_AbstractClasses_NestedClasses_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithConstructorWith1AttributeUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithConstructorWith1ParameterUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithConstructorWith2ParametersUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithInternalConstructorUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithConstructorWithParametersWithAttributesUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithConstructorWithParametersWithModifiersUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPrivateConstructorUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedConstructorUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedInternalConstructorUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPublicConstructorUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithPublicConstructor));
        }
    }
}
