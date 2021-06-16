using Coreflow.Interfaces;
using Coreflow.Objects;
using MComponents.MForm;
using MComponents.Shared.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coreflow.Activities.MComponents.File
{
    [DisplayMeta("MField File", "MForm", "fa-keyboard")]
    public class MFormFieldFileActivity : ICodeActivity
    {

#pragma warning disable BL0005 // Component parameter should not be set outside of its component.

        public void Execute(
           [DisplayMeta("Fields")]
           [DefaultValue("Fields")]
           IList<IMField> pMFields,

           [DisplayMeta("Row")]
           [DefaultValue("mFormRow")]
           int pRow,

           [DisplayMeta("File Name")]
           string pFileName,

           [DisplayMeta("Property Name")]
           string pName,

           [DisplayMeta("AdditionalHeaders")]
           [DefaultValue("_InputFileAdditionalHeaders")]
           IDictionary<string, string> pAdditionalHeaders,

           [DisplayMeta("Attributes")]
           Attribute[] pAdditionalAttributes,

           [DisplayMeta("Accept")]
           string pAccept
          )
        {
            var field = new FileComplexPropertyField()
            {
                Property = pName,
                FileInputName = pFileName,
                Attributes = new Attribute[] {
                    new RowAttribute(pRow),
                    new DisplayAttribute() {
                        Name = pFileName
                    },
                },
                AdditionalHeaders = pAdditionalHeaders,
                Accept = pAccept
            };
            if (pAdditionalAttributes != null)
                field.Attributes = field.Attributes.Concat(pAdditionalAttributes).ToArray();
            pMFields.Add(field);
        }

#pragma warning restore BL0005 // Component parameter should not be set outside of its component.


    }
}
