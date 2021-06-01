﻿using Coreflow.Interfaces;
using Coreflow.Objects;
using MComponents.MForm;
using MComponents.Shared.Attributes;
using System;
using System.Collections.Generic;
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

           [DisplayMeta("AdditionalHeaders")]
           [DefaultValue("_InputFileAdditionalHeaders")]
           IDictionary<string, string> pAdditionalHeaders
          )
        {
            var field = new FileFieldGenerator()
            {
                FileInputName = pFileName,
                Attributes = new Attribute[] {
                    new RowAttribute(pRow)
                },
                AdditionalHeaders = pAdditionalHeaders
            };

            pMFields.Add(field);
        }

#pragma warning restore BL0005 // Component parameter should not be set outside of its component.


    }
}
