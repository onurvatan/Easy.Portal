using System;
using Easy.Portal.Web.Models.Basics;
using Easy.Portal.Web.Views.Bases;
using Microsoft.AspNetCore.Components;

namespace Easy.Portal.Web.Views.Components
{
	public partial class StudentFormCompenent:ComponentBase 
	{
        public TextBoxBase StudentNameTextBox { get; set; }


        public ComponentState State { get; set; }

        protected override void OnInitialized()
        {
            this.State = ComponentState.Content;
        }
    }
}

