using Coreflow.CodeCreators;
using Coreflow.Interfaces;
using Coreflow.Objects;
using System.Collections.Generic;
using System.Linq;

namespace Coreflow.Activities.MComponents
{
    public class MFormRowCodeCreator : AbstractSingleSequenceCreator, IParametrized
    {
        public List<IArgument> Arguments { get; set; } = new List<IArgument>();

        public MFormRowCodeCreator() : base()
        {
        }

        public MFormRowCodeCreator(ICodeCreatorContainerCreator pParentContainerCreator) : base(pParentContainerCreator)
        {
        }

        public override string Name => "MRow";

        public override string Category => "MForm";

        public override string Icon => "fa-keyboard";

        public override void ToSequenceCode(FlowBuilderContext pBuilderContext, FlowCodeWriter pCodeWriter, ICodeCreatorContainerCreator pContainer)
        { 
            if (!pBuilderContext.CurrentSymbols.Any(s => s.Name == "mFormRow"))
            {
                pCodeWriter.AppendLineTop("int mFormRow = 0;");
            }

            pCodeWriter.AppendLineTop("int formRow = mFormRow++;");

            AddCodeCreatorsCode(pBuilderContext, pCodeWriter);
        }

        public CodeCreatorParameter[] GetParameters()
        {
            return new[] { new CodeCreatorParameter() {
                 Direction = VariableDirection.In,
                 Name = "Row",
                 Type = typeof(int).MakeByRefType(),
                 DefaultValueCode = "mFieldRow"
                }
            };
        }
    }

}
