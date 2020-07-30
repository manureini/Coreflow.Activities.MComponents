using Coreflow.Interfaces;
using Coreflow.Objects;
using MComponents.MForm;
using MComponents.Shared.Attributes;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Coreflow.Activities.MComponents
{
    [DisplayMeta("MField", "MForm", "fa-keyboard")]
    public class MFormFieldActivity : ICodeActivity
    {
      //  public ILogger Logger;

        public void Execute(
           [DisplayMeta("MFields")]
           [DefaultValue("mFields")]
           IList<IMPropertyField> pMFields,

           [DisplayMeta("Row")]
           [DefaultValue("formRow")]
           int pRow,

           [DisplayMeta("Name")]
           string pName
          )
        {
            pMFields.Add(new MField()
            {
                Property = pName,
                PropertyType = typeof(string),
                Attributes = new[] { new RowAttribute(pRow) }
            });
        }
    }
}
