using CSharpDom.TestTarget.StaticClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_Methods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStaticClassWithMethodWith1AttributeUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWith1GenericParameterUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWith1ReturnAttributeUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWith2GenericParametersUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithGenericParameterBaseSealedClassConstraintUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWithGenericParameterBaseSealedClassConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithGenericParameterSealedClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWithGenericParameterSealedClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithGenericParameterSealedClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWithGenericParameterSealedClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithGenericParameterSealedClassConstraintUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWithGenericParameterSealedClassConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithGenericParameterStructConstraintUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithInternalMethodUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithInternalMethod));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithParametersWithAttributesUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithParametersWithModifiersUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStaticClassWithPrivateMethodUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestStaticClassWithPublicMethodUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithPublicMethod));
        }
    }
}
