using System;
using Easy.Portal.Web.Models.Basics;
using Easy.Portal.Web.Views.Components;
using FluentAssertions;
using Tynamix.ObjectFiller;
using Xunit;

namespace Easy.Portal.Web.Tests.Unit.Components
{
	public partial class StudentFormComponentTests
	{
		[Fact]
		public void ShouldInitializeComponent()
        {
			// given when
			var initialStudentFormComponent = new StudentFormComponent();

			//then
			initialStudentFormComponent.StudentNameTextBox.Should().BeNull();
		}

		[Fact]
		public void ShouldRenderComponent()
        {
			//given

			ComponentState componentState = ComponentState.Content;
			//string randomText = new MnemonicString().ToString();

			//when
			this.renderedStudentFormCompenent = RenderComponent<StudentFormCompenent>();

			//then
			this.renderedStudentFormCompenent.Instance.State.Should().Be(componentState);

			this.renderedStudentFormCompenent.Instance.StudentNameTextBox.Should().NotBeNull();

			this.renderedStudentFormCompenent.Instance.StudentNameTextBox.PlaceHolder.Should().Be("Name");
        }
	}
}

