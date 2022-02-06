using System;
using Microsoft.AspNetCore.Components;

namespace Easy.Portal.Web.Views.Bases
{
    public partial class TextBoxBase : ComponentBase
    {
		[Parameter]
        public string Value { get; set; }

        [Parameter]
        public string PlaceHolder { get; set; }

        public void SetValue(string value) => this.Value = value;
    }
}

