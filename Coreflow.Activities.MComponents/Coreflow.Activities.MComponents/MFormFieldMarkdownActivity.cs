using Coreflow.Interfaces;
using Coreflow.Objects;
using MComponents.MForm;
using MComponents.Shared.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Coreflow.Activities.MComponents
{
    [DisplayMeta("MField Text", "MForm", "fa-keyboard")]
    public class MFormFieldMarkdownActivity : ICodeActivity
    {

#pragma warning disable BL0005 // Component parameter should not be set outside of its component.

        public void Execute(
           [DisplayMeta("Fields")]
           [DefaultValue("Fields")]
           IList<IMField> pMFields,

           [DisplayMeta("Row")]
           [DefaultValue("mFormRow")]
           int pRow,

           [DisplayMeta("Text")]
           string pText
          )
        {

            var field = new MarkdownMFieldGenerator()
            {
                Text = pText,
                Attributes = new Attribute[] {
                    new RowAttribute(pRow)
                }
            };
             
            pMFields.Add(field);
        }

#pragma warning restore BL0005 // Component parameter should not be set outside of its component.

    }
}
