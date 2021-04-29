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
    [DisplayMeta("MField", "MForm", "fa-keyboard")]
    public class MFormFieldActivity : ICodeActivity
    {
        //  public ILogger Logger;

#pragma warning disable BL0005 // Component parameter should not be set outside of its component.

        public void Execute(
           [DisplayMeta("Fields")]
           [DefaultValue("Fields")]
           IList<IMField> pMFields,

           [DisplayMeta("Row")]
           [DefaultValue("mFormRow")]
           int pRow,

           [DisplayMeta("Value Type")]
           [DefaultValue("typeof(string)")]
           Type pFieldType,

           [DisplayMeta("Display")]
           string pDisplay,

           [DisplayMeta("Name")]
           string pName,

           [DisplayMeta("Additional Attributes")]
           Attribute[] pAdditionalAttributes
          )
        {
            MField field = new MField()
            {
                Property = pName,
                PropertyType = pFieldType,
                Attributes = new Attribute[] {
                    new RowAttribute(pRow),
                    new DisplayAttribute() {
                        Name = pDisplay ?? pName
                }}
            };
            if (pAdditionalAttributes != null)
                field.Attributes = field.Attributes.Concat(pAdditionalAttributes).ToArray();
            pMFields.Add(field);
        }

#pragma warning restore BL0005 // Component parameter should not be set outside of its component.

    }
}
