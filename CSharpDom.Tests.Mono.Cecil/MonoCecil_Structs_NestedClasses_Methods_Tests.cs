using CSharpDom.TestTarget.Structs.NestedClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedClasses_Methods_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithMethodWith1AttributeUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWith1GenericParameterUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWith1ReturnAttributeUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWith2GenericParametersUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalMethodUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithInternalMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewMethodUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticMethodUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewVirtualMethodUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewVirtualMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithOverrideMethodUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithParametersWithAttributesUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithParametersWithModifiersUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateMethodUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedMethodUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalMethodUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicMethodUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPublicMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithSealedOverrideMethodUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithStaticMethodUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithStaticMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithVirtualMethodUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithVirtualMethod));
        }
    }
}
