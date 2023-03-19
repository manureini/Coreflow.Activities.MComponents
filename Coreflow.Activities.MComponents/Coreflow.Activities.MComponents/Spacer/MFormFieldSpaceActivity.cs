using Coreflow.Interfaces;
using Coreflow.Objects;
using MComponents.MForm;
using MComponents.Shared.Attributes;
using System;
using System.Collections.Generic;

namespace Coreflow.Activities.MComponents.Spacer
{
    [DisplayMeta("MField Space", "MForm", "fa-keyboard")]
    public class MFormFieldSpaceActivity : ICodeActivity
    {
#pragma warning disable BL0005 // Component parameter should not be set outside of its component.

        public void Execute(
           [DisplayMeta("Fields")]
           [DefaultValue("Fields")]
           IList<IMField> pMFields,

           [DisplayMeta("Row")]
           [DefaultValue("mFormRow")]
           int pRow,

           [DisplayMeta("Height")]
           int pHeight
          )
        {
            var field = new MFieldSpaceGenerator()
            {
                Height = pHeight,
                Attributes = new Attribute[] {
                    new RowAttribute(pRow)
                }
            };

            pMFields.Add(field);
        }

#pragma warning restore BL0005 // Component parameter should not be set outside of its component.

    }
}
