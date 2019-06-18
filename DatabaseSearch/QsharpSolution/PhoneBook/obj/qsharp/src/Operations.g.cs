#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.PhoneBook\",\"Name\":\"Set\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Database_Search/QsharpSolution/PhoneBook/Operations.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"desired\"]},\"Type\":{\"Case\":\"Result\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":15},\"Item2\":{\"Line\":1,\"Column\":22}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q1\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":34}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Result\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.PhoneBook\",\"Name\":\"Set\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Database_Search/QsharpSolution/PhoneBook/Operations.qs\",\"Position\":{\"Item1\":6,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.PhoneBook\",\"Name\":\"SHIFT\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Database_Search/QsharpSolution/PhoneBook/Operations.qs\",\"Position\":{\"Item1\":14,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":17},\"Item2\":{\"Line\":1,\"Column\":18}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.PhoneBook\",\"Name\":\"SHIFT\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Database_Search/QsharpSolution/PhoneBook/Operations.qs\",\"Position\":{\"Item1\":15,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.PhoneBook\",\"Name\":\"SHIFT\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Database_Search/QsharpSolution/PhoneBook/Operations.qs\",\"Position\":{\"Item1\":18,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.PhoneBook\",\"Name\":\"CSHIFT\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Database_Search/QsharpSolution/PhoneBook/Operations.qs\",\"Position\":{\"Item1\":21,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":18},\"Item2\":{\"Line\":1,\"Column\":19}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.PhoneBook\",\"Name\":\"CSHIFT\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Database_Search/QsharpSolution/PhoneBook/Operations.qs\",\"Position\":{\"Item1\":21,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.PhoneBook\",\"Name\":\"ICNOT\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Database_Search/QsharpSolution/PhoneBook/Operations.qs\",\"Position\":{\"Item1\":25,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":17},\"Item2\":{\"Line\":1,\"Column\":18}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.PhoneBook\",\"Name\":\"ICNOT\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Database_Search/QsharpSolution/PhoneBook/Operations.qs\",\"Position\":{\"Item1\":26,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.PhoneBook\",\"Name\":\"ICNOT\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Database_Search/QsharpSolution/PhoneBook/Operations.qs\",\"Position\":{\"Item1\":31,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.PhoneBook\",\"Name\":\"IC_1q\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Database_Search/QsharpSolution/PhoneBook/Operations.qs\",\"Position\":{\"Item1\":35,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"controls\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":17},\"Item2\":{\"Line\":1,\"Column\":25}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"gate\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":41}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"gate_qubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":66},\"Item2\":{\"Line\":1,\"Column\":76}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.PhoneBook\",\"Name\":\"IC_1q\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Database_Search/QsharpSolution/PhoneBook/Operations.qs\",\"Position\":{\"Item1\":35,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.PhoneBook\",\"Name\":\"IC_mq\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Database_Search/QsharpSolution/PhoneBook/Operations.qs\",\"Position\":{\"Item1\":42,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"controls\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":17},\"Item2\":{\"Line\":1,\"Column\":25}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"gate\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":41}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"gate_qubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":68},\"Item2\":{\"Line\":1,\"Column\":79}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.PhoneBook\",\"Name\":\"IC_mq\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Database_Search/QsharpSolution/PhoneBook/Operations.qs\",\"Position\":{\"Item1\":42,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.PhoneBook\",\"Name\":\"GateTest\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Database_Search/QsharpSolution/PhoneBook/Operations.qs\",\"Position\":{\"Item1\":48,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q1\"]},\"Type\":{\"Case\":\"Result\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":21},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q2\"]},\"Type\":{\"Case\":\"Result\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":36}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Result\"},{\"Case\":\"Result\"}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Result\"},{\"Case\":\"Result\"}]]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.PhoneBook\",\"Name\":\"GateTest\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Database_Search/QsharpSolution/PhoneBook/Operations.qs\",\"Position\":{\"Item1\":48,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.PhoneBook\",\"Name\":\"PhoneBookSearch\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Database_Search/QsharpSolution/PhoneBook/Operations.qs\",\"Position\":{\"Item1\":66,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q0\"]},\"Type\":{\"Case\":\"Result\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":30}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q1\"]},\"Type\":{\"Case\":\"Result\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":41},\"Item2\":{\"Line\":1,\"Column\":43}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q2\"]},\"Type\":{\"Case\":\"Result\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":54},\"Item2\":{\"Line\":1,\"Column\":56}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Result\"},{\"Case\":\"Result\"},{\"Case\":\"Result\"}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Result\"},{\"Case\":\"Result\"},{\"Case\":\"Result\"}]]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.PhoneBook\",\"Name\":\"PhoneBookSearch\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Database_Search/QsharpSolution/PhoneBook/Operations.qs\",\"Position\":{\"Item1\":66,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.PhoneBook
{
    public partial class Set : Operation<(Result,Qubit), QVoid>, ICallable
    {
        public Set(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Result,Qubit)>, IApplyData
        {
            public In((Result,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item2;
                }
            }
        }

        String ICallable.Name => "Set";
        String ICallable.FullName => "Quantum.PhoneBook.Set";
        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<(Result,Qubit), QVoid> Body => (__in__) =>
        {
            var (desired,q1) = __in__;
#line 8 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
            var current = MicrosoftQuantumIntrinsicM.Apply(q1);
#line 9 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
            if ((desired != current))
            {
#line 10 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
                MicrosoftQuantumIntrinsicX.Apply(q1);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((Result,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Result desired, Qubit q1)
        {
            return __m__.Run<Set, (Result,Qubit), QVoid>((desired, q1));
        }
    }

    public partial class SHIFT : Controllable<IQArray<Qubit>>, ICallable
    {
        public SHIFT(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "SHIFT";
        String ICallable.FullName => "Quantum.PhoneBook.SHIFT";
        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var q = __in__;
#line 17 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
            MicrosoftQuantumIntrinsicX.Apply(q[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,q) = __in__;
#line hidden
            MicrosoftQuantumIntrinsicX.Controlled.Apply((__controlQubits__, q[0L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> q)
        {
            return __m__.Run<SHIFT, IQArray<Qubit>, QVoid>(q);
        }
    }

    public partial class CSHIFT : Operation<IQArray<Qubit>, QVoid>, ICallable
    {
        public CSHIFT(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "CSHIFT";
        String ICallable.FullName => "Quantum.PhoneBook.CSHIFT";
        protected IControllable<IQArray<Qubit>> SHIFT
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var q = __in__;
#line 23 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
            SHIFT.Controlled.Apply((new QArray<Qubit>(q[0L]), new QArray<Qubit>(q[1L], q[2L])));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.SHIFT = this.Factory.Get<IControllable<IQArray<Qubit>>>(typeof(SHIFT));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> q)
        {
            return __m__.Run<CSHIFT, IQArray<Qubit>, QVoid>(q);
        }
    }

    public partial class ICNOT : Controllable<IQArray<Qubit>>, ICallable
    {
        public ICNOT(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ICNOT";
        String ICallable.FullName => "Quantum.PhoneBook.ICNOT";
        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var q = __in__;
#line 28 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
            MicrosoftQuantumIntrinsicX.Apply(q[0L]);
#line 29 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
            MicrosoftQuantumIntrinsicX.Controlled.Apply((new QArray<Qubit>(q[0L]), q[1L]));
#line 30 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
            MicrosoftQuantumIntrinsicX.Apply(q[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,q) = __in__;
#line hidden
            MicrosoftQuantumIntrinsicX.Controlled.Apply((__controlQubits__, q[0L]));
#line hidden
            MicrosoftQuantumIntrinsicX.Controlled.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(q[0L]), q[1L])));
#line hidden
            MicrosoftQuantumIntrinsicX.Controlled.Apply((__controlQubits__, q[0L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> q)
        {
            return __m__.Run<ICNOT, IQArray<Qubit>, QVoid>(q);
        }
    }

    public partial class IC_1q : Operation<(IQArray<Qubit>,IControllable,Qubit), QVoid>, ICallable
    {
        public IC_1q(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IControllable,Qubit)>, IApplyData
        {
            public In((IQArray<Qubit>,IControllable,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "IC_1q";
        String ICallable.FullName => "Quantum.PhoneBook.IC_1q";
        protected ICallable MicrosoftQuantumCanonApplyToEach
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IControllable,Qubit), QVoid> Body => (__in__) =>
        {
            var (controls,gate,gate_qubit) = __in__;
#line 37 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumIntrinsicX, controls));
#line 38 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
            gate.Controlled.Apply((controls, gate_qubit));
#line 39 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumIntrinsicX, controls));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEach<>));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IControllable,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> controls, IControllable gate, Qubit gate_qubit)
        {
            return __m__.Run<IC_1q, (IQArray<Qubit>,IControllable,Qubit), QVoid>((controls, gate, gate_qubit));
        }
    }

    public partial class IC_mq : Operation<(IQArray<Qubit>,IControllable,IQArray<Qubit>), QVoid>, ICallable
    {
        public IC_mq(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IControllable,IQArray<Qubit>)>, IApplyData
        {
            public In((IQArray<Qubit>,IControllable,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "IC_mq";
        String ICallable.FullName => "Quantum.PhoneBook.IC_mq";
        protected ICallable MicrosoftQuantumCanonApplyToEach
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IControllable,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (controls,gate,gate_qubits) = __in__;
#line 44 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumIntrinsicX, controls));
#line 45 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
            gate.Controlled.Apply((controls, gate_qubits));
#line 46 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumIntrinsicX, controls));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEach<>));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IControllable,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> controls, IControllable gate, IQArray<Qubit> gate_qubits)
        {
            return __m__.Run<IC_mq, (IQArray<Qubit>,IControllable,IQArray<Qubit>), QVoid>((controls, gate, gate_qubits));
        }
    }

    public partial class GateTest : Operation<(Result,Result), (Result,Result)>, ICallable
    {
        public GateTest(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Result,Result)>, IApplyData
        {
            public In((Result,Result) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        public class Out : QTuple<(Result,Result)>, IApplyData
        {
            public Out((Result,Result) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "GateTest";
        String ICallable.FullName => "Quantum.PhoneBook.GateTest";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> MicrosoftQuantumIntrinsicResetAll
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Qubit>,IControllable,Qubit), QVoid> IC_1q
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> Set
        {
            get;
            set;
        }

        public override Func<(Result,Result), (Result,Result)> Body => (__in__) =>
        {
            var (q1,q2) = __in__;
#line hidden
            {
#line 51 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
                var q = Allocate.Apply(3L);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 52 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
                    Set.Apply((Result.Zero, q[0L]));
#line 53 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
                    Set.Apply((q1, q[1L]));
#line 54 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
                    Set.Apply((q2, q[2L]));
#line 56 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
                    IC_1q.Apply((new QArray<Qubit>(q[1L]), MicrosoftQuantumIntrinsicX, q[2L]));
#line 58 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
                    var res1 = MicrosoftQuantumIntrinsicM.Apply(q[1L]);
#line 59 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
                    var res2 = MicrosoftQuantumIntrinsicM.Apply(q[2L]);
#line 61 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
                    MicrosoftQuantumIntrinsicResetAll.Apply(q);
#line 62 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
                    return (res1, res2);
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(q);
                }
            }
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicResetAll = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.ResetAll));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.IC_1q = this.Factory.Get<ICallable<(IQArray<Qubit>,IControllable,Qubit), QVoid>>(typeof(IC_1q));
            this.Set = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Set));
        }

        public override IApplyData __dataIn((Result,Result) data) => new In(data);
        public override IApplyData __dataOut((Result,Result) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Result,Result)> Run(IOperationFactory __m__, Result q1, Result q2)
        {
            return __m__.Run<GateTest, (Result,Result), (Result,Result)>((q1, q2));
        }
    }

    public partial class PhoneBookSearch : Operation<(Result,Result,Result), (Result,Result,Result)>, ICallable
    {
        public PhoneBookSearch(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Result,Result,Result)>, IApplyData
        {
            public In((Result,Result,Result) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        public class Out : QTuple<(Result,Result,Result)>, IApplyData
        {
            public Out((Result,Result,Result) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "PhoneBookSearch";
        String ICallable.FullName => "Quantum.PhoneBook.PhoneBookSearch";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> MicrosoftQuantumIntrinsicResetAll
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicSWAP
        {
            get;
            set;
        }

        protected IControllable<IQArray<Qubit>> ICNOT
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Qubit>,IControllable,Qubit), QVoid> IC_1q
        {
            get;
            set;
        }

        protected IControllable<IQArray<Qubit>> SHIFT
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> Set
        {
            get;
            set;
        }

        public override Func<(Result,Result,Result), (Result,Result,Result)> Body => (__in__) =>
        {
            var (q0,q1,q2) = __in__;
#line 69 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
            var n1 = 1L;
#line 70 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
            var n2 = 2L;
#line hidden
            {
#line 72 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
                var q = Allocate.Apply((n1 + n2));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 74 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
                    Set.Apply((q0, q[0L]));
#line 75 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
                    Set.Apply((q1, q[1L]));
#line 76 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
                    Set.Apply((q2, q[2L]));
#line 80 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
                    IC_1q.Apply((new QArray<Qubit>(q[0L], q[1L]), MicrosoftQuantumIntrinsicH, q[2L]));
#line 84 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
                    SHIFT.Apply(new QArray<Qubit>(q[0L], q[1L]));
#line 85 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
                    MicrosoftQuantumIntrinsicSWAP.Controlled.Apply((new QArray<Qubit>(q[0L]), (q[1L], q[2L])));
#line 86 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
                    ICNOT.Controlled.Apply((new QArray<Qubit>(q[0L]), new QArray<Qubit>(q[1L], q[2L])));
#line 87 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
                    MicrosoftQuantumIntrinsicSWAP.Controlled.Apply((new QArray<Qubit>(q[0L]), (q[1L], q[2L])));
#line 88 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
                    SHIFT.Apply(new QArray<Qubit>(q[0L], q[1L]));
#line 92 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
                    var res0 = MicrosoftQuantumIntrinsicM.Apply(q[0L]);
#line 93 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
                    var res1 = MicrosoftQuantumIntrinsicM.Apply(q[1L]);
#line 94 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
                    var res2 = MicrosoftQuantumIntrinsicM.Apply(q[2L]);
#line 95 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
                    MicrosoftQuantumIntrinsicResetAll.Apply(q);
#line 96 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Database_Search\\QsharpSolution\\PhoneBook\\Operations.qs"
                    return (res0, res1, res2);
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(q);
                }
            }
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicResetAll = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.ResetAll));
            this.MicrosoftQuantumIntrinsicSWAP = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.SWAP));
            this.ICNOT = this.Factory.Get<IControllable<IQArray<Qubit>>>(typeof(ICNOT));
            this.IC_1q = this.Factory.Get<ICallable<(IQArray<Qubit>,IControllable,Qubit), QVoid>>(typeof(IC_1q));
            this.SHIFT = this.Factory.Get<IControllable<IQArray<Qubit>>>(typeof(SHIFT));
            this.Set = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Set));
        }

        public override IApplyData __dataIn((Result,Result,Result) data) => new In(data);
        public override IApplyData __dataOut((Result,Result,Result) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Result,Result,Result)> Run(IOperationFactory __m__, Result q0, Result q1, Result q2)
        {
            return __m__.Run<PhoneBookSearch, (Result,Result,Result), (Result,Result,Result)>((q0, q1, q2));
        }
    }
}